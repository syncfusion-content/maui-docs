---
layout: post
title: AI Integration with Syncfusion® A2UI for .NET MAUI | Syncfusion®
description: Connect a .NET MAUI application to an A2UI v0.9 agent and render its responses as MAUI Syncfusion® components.
control: AI Integration
platform: MAUI
documentation: ug
---

# AI Integration with Syncfusion® A2UI for .NET MAUI

This guide explains how to connect a .NET MAUI host to an A2UI v0.9 agent. The host sends user prompts to the agent using JSON-RPC 2.0 `message/send`, extracts the A2UI messages from the response, and renders the resulting surface with Syncfusion® .NET MAUI controls.

The [Getting Started](./getting-started) guide shows how to render a static A2UI surface. This page covers the agent request and response flow using the A2UI Composer MAUI sample as a reference.

## Prerequisites

| Requirement | Version or details |
| --- | --- |
| .NET MAUI | Follow the [Getting Started prerequisites](./getting-started); the Composer sample targets .NET 10. |
| Syncfusion® A2UI for .NET MAUI | `Syncfusion.Maui.A2UI`. See [Getting Started](./getting-started) to install the NuGet package and register the Syncfusion® license. |
| A2UI agent | An agent that accepts A2UI-compatible JSON-RPC 2.0 `message/send` requests and returns A2UI v0.9 messages. |

To run the Composer sample's bundled agent locally, you also need:

- Windows and PowerShell, because the sample's automatic agent bootstrap uses a PowerShell script and a Windows Python virtual environment.
- Python 3.10 or later.
- Credentials for an AI provider configured in the agent's `Agent\.env` file. The bundled configuration defaults to Azure OpenAI; it can also be configured for other supported providers.

Register a Syncfusion® license key before rendering Syncfusion® controls. See [Register License Key in a .NET MAUI application](https://help.syncfusion.com/maui/licensing).

## What AI integration does

The Syncfusion® A2UI for .NET MAUI package is the rendering half of the integration. The agent, its model, and its provider credentials are separate from the MAUI renderer. The host application is responsible for:

1. Sending the user's prompt to the agent in a JSON-RPC `message/send` request. The prompt is sent in `params.message.parts[0].text`.
2. Reading A2UI messages from the agent's JSON-RPC response. The Composer sample accepts A2UI messages in data parts such as `data.a2uiEnvelope`, as well as JSON contained in text parts.
3. Processing the messages with a `SurfaceHost` configured with the catalog used by the agent.
4. Binding the resulting `SurfaceModel` to an `A2uiSurface` view.
5. Handling errors and, where needed, forwarding actions from rendered controls back to the agent.

The agent must emit component IDs and properties supported by the catalog registered in the host. See [Supported Components](./supported-components) for the Syncfusion® adapters available in the MAUI catalog.

## How the Composer sample works

The sample implements a prompt-and-render flow:

1. The user enters a request in the Composer workspace.
2. The MAUI app sends a JSON-RPC 2.0 `message/send` request to the Composer Agent. The request includes the current conversation history and, for follow-up prompts, the current A2UI surface as context.
3. The agent returns an A2A response. The app extracts A2UI messages from the response's artifacts, status message, or result message.
4. The app merges the response with the current message history, creates a fresh `SurfaceHost`, processes the messages, and binds the resulting `SurfaceModel` to an `A2uiSurface`.
5. The workspace displays both the live Syncfusion® surface and the generated A2UI JSON.

The sample's default agent endpoint is `http://127.0.0.1:8080/`. When the agent cannot be reached, the Composer uses its offline preview generator so the workspace can still demonstrate sample surfaces. An agent request or response error is also shown in the workspace rather than being treated as a successful live AI response.

### Register the MAUI renderer

In a MAUI application, register Syncfusion® Core and the A2UI Syncfusion® components in `MauiProgram.cs`:

{% tabs %}
{% highlight c# %}

using Syncfusion.Maui.A2UI.SyncfusionComponents;
using Syncfusion.Maui.Core.Hosting;

var builder = MauiApp.CreateBuilder();

builder
    .UseMauiApp<App>()
    .ConfigureSyncfusionCore()
    .UseA2UIWithSyncfusionComponents();

{% endhighlight %}
{% endtabs %}

`UseA2UIWithSyncfusionComponents()` registers the combined MAUI catalog and renderers. The default catalog ID is `syncfusion-maui`. The Composer sample builds its host directly instead, combining the basic and Syncfusion® catalogs under `syncfusion-a2ui-catalog`; if you use that custom catalog setup, the agent's `createSurface.catalogId` must use the same ID.

### Send a prompt to the agent

The following request shape matches the Composer sample. Use an `HttpClient` to send it to the agent endpoint:

{% tabs %}
{% highlight c# %}

using System.Net.Http.Json;

var requestId = $"req-{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}";
var request = new
{
    jsonrpc = "2.0",
    id = requestId,
    method = "message/send",
    @params = new
    {
        message = new
        {
            kind = "message",
            messageId = requestId,
            role = "user",
            parts = new[] { new { text = prompt } }
        }
    }
};

using var response = await httpClient.PostAsJsonAsync(
    agentUrl,
    request,
    cancellationToken);
response.EnsureSuccessStatusCode();

{% endhighlight %}
{% endtabs %}

The sample parses the response's A2A result and extracts A2UI messages from `result.artifacts[].parts[]`, `result.status.message.parts[]`, or `result.message.parts[]`. For example, a data part can contain an `a2uiEnvelope` array. A text part can contain JSON inside `<a2ui-json>...</a2ui-json>` tags. Validate and handle unsuccessful HTTP responses, JSON-RPC errors, failed agent statuses, or responses without A2UI messages.

### Process and render the response

The Composer sample creates a combined catalog, processes the A2UI JSON, and binds the surface model to `A2uiSurface`. The essential flow is:

{% tabs %}
{% highlight c# %}

var catalog = SyncfusionComponentRegistry.CombineCatalog(
    "syncfusion-a2ui-catalog",
    functions: BasicFunctions.All);

var host = new SurfaceHost(
    new[] { catalog },
    SyncfusionComponentRegistry.CombinedRenderers(),
    markdownRenderer: new BasicMarkdownRenderer());

host.ProcessJson(messagesJson);
var surface = host.Processor.Model.GetSurface(surfaceId);

var surfaceView = new A2uiSurface
{
    Host = host,
    Surface = surface
};
surfaceView.Rebuild();

{% endhighlight %}
{% endtabs %}

This host construction follows the Composer sample's custom catalog configuration. For the standard package setup, use `UseA2UIWithSyncfusionComponents()` and the registered `SurfaceHost` as described in [Getting Started](./getting-started). Ensure the surface ID passed to `GetSurface` matches the `surfaceId` in the agent's `createSurface` operation.

## Run the Composer sample

The Composer sample includes a Python A2A agent under `A2UIComposer\Agent`. Before the first launch:

1. Create `A2UIComposer\Agent\.env` and configure the provider credentials. For the default Azure OpenAI provider, set `MODEL_NAME`, `AZURE_API_KEY`, and `AZURE_API_BASE`. Keep secrets out of source control.
2. Open the MAUI solution in Visual Studio and select a Windows target, or run the app from the `A2UIComposer\A2UIComposer` project.
3. Launch the app. On startup, the sample runs `Agent\scripts\bootstrap-agent.ps1` to prepare the Python environment, then starts the agent on port `8080`. The first bootstrap can take longer and requires internet access to install Python dependencies from PyPI. Later launches reuse the installed environment.
4. Open **Create** or **Workspace**, enter a prompt such as `Show a data grid with order information`, and submit it. The generated surface appears in the live preview; the JSON tab displays the A2UI message history.

The app checks the agent's `/healthz` endpoint before making a live request. The Composer sample manages the bundled agent's lifetime and stops it when the app exits; do not start a second agent on the same port while using this managed startup.

The sample project also defines Android, iOS, and Mac Catalyst target frameworks, but its bundled automatic agent bootstrap is Windows-specific. On those platforms, configure an agent endpoint reachable from the device. In particular, `127.0.0.1` refers to the device itself, not the development computer. Use HTTPS for a remotely hosted production agent.

## Customize the integration

- **Agent endpoint.** The sample's `A2uiAgentClient.DefaultEndpoint` is `http://127.0.0.1:8080/`. For a hosted agent or an agent running on another machine, configure the client to use the appropriate reachable URL. The agent and client must agree on the request path and JSON-RPC/A2A protocol.
- **Provider credentials.** Configure the agent's provider and model in its environment. Do not place API keys in the MAUI application or commit them to source control.
- **Catalog ID.** The `catalogId` in `createSurface` must match the catalog registered by the MAUI host. The standard MAUI setup uses `syncfusion-maui`; the Composer sample uses `syncfusion-a2ui-catalog`.
- **Conversation context.** The Composer sample includes earlier prompts and the current surface in follow-up requests so the agent can refine the existing UI. Resetting the workspace clears that context and the current surface.
- **User actions.** The Composer sample listens for `SurfaceHost.ActionDispatched` and displays actions in its Action Stream inspector. It does not forward those action payloads to the agent. To build a bidirectional workflow, add application logic that sends the selected action to the agent and processes its response.

## Verify the integration

1. Confirm the agent is healthy at `http://127.0.0.1:8080/healthz` when running the Windows Composer sample.
2. Submit a prompt. Confirm the workspace reports a live agent response, and that a JSON-RPC `message/send` request is sent to the configured endpoint.
3. Confirm the response contains A2UI messages and a surface is rendered in the live preview.
4. Submit a follow-up request and confirm the existing surface is included as context and updated or replaced according to the returned A2UI messages.
5. Interact with a rendered control. In the Composer sample, confirm the interaction appears in the Action Stream inspector. It is not sent to the agent unless you add the action-forwarding logic described above.
6. Stop or disconnect the agent and submit a prompt again. The sample should indicate that an offline preview is being used; it should not present that fallback as a successful live agent response.

## Common questions

- **Why am I seeing an offline preview?** — Check that the agent started successfully, that `/healthz` responds, and that the provider credentials and model settings in `Agent\.env` are valid. The Composer sample intentionally falls back to local previews when the agent is unavailable.
- **Why is my component not rendered?** — Check that the agent uses the same `catalogId` as the MAUI host and emits component IDs supported by the registered catalog. See [Supported Components](./supported-components).
- **Why does the sample's loopback endpoint fail on a mobile device?** — `127.0.0.1` points to the device. Use a reachable development-machine address or a deployed HTTPS endpoint, and configure the sample's agent client accordingly.
- **Why don't control interactions update the agent's response?** — The Composer sample records dispatched actions in its inspector but does not send them back to the agent. Implement the action request flow in the host application if the experience requires agent responses to user actions.

## See also

- [Overview](./overview)
- [Getting Started](./getting-started)
- [Supported Components](./supported-components)
- [A2UI v0.9 protocol](https://a2ui.org/specification/v0.9-a2ui/)
