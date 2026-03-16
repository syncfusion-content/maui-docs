---
layout: post
title: SyncfusionMAUIAssistant MCP Server | Syncfusion
description: Learn how to configure and use SyncfusionMAUIAssistant MCP server for intelligent code generation, documentation, and troubleshooting in .NET MAUI apps.
platform: MAUI
control: Getting started with SyncfusionMAUIAssistant MCP Server
documentation: ug
---

# SyncfusionMAUIAssistant MCP Server

## Overview

The `SyncfusionMAUIAssistant` is a specialized [Model Context Protocol (MCP)](https://modelcontextprotocol.io/docs/getting-started/intro) server that provides intelligent assistance for developers using Syncfusion's .NET MAUI component libraries. This tool seamlessly integrates with compatible [MCP clients](https://modelcontextprotocol.io/clients) to enhance your development workflow when building .NET MAUI applications with Syncfusion<sup style="font-size:70%">&reg;</sup> components.

### Key Benefits

* Intelligent code generation for Syncfusion<sup style="font-size:70%">&reg;</sup> .NET MAUI components.
* Detailed component documentation and usage examples.
* Troubleshooting assistance for common integration challenges.

## Prerequisites

Before using `SyncfusionMAUIAssistant`, ensure you have:

* Required [node](https://nodejs.org/en/) version >= 18
* A [compatible MCP client](https://modelcontextprotocol.io/clients) (VS Code with GitHub Copilot, [Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio](https://www.syncfusion.com/code-studio/), etc.)
* An active Syncfusion<sup style="font-size:70%">&reg;</sup> license (any of the following):
  - [Commercial License](https://www.syncfusion.com/sales/unlimitedlicense)
  - [Free Community License](https://www.syncfusion.com/products/communitylicense)
  - [Free Trial](https://www.syncfusion.com/account/manage-trials/start-trials)
* An active [API KEY](https://syncfusion.com/account/api-key)

## Unlimited Access

Syncfusion<sup style="font-size:70%">&reg;</sup> offers unlimited access to this MCP server. There are no restrictions on:

* Number of requests
* Components usage
* Query types
* Usage duration

This ensures users can fully leverage Syncfusion<sup style="font-size:70%">&reg;</sup> components to enhance their development experience without limitations.

## Installation and setup

Before you can invoke the `SyncfusionMAUIAssistant` MCP server, you need to configure your MCP client with these core settings. The **Generic MCP Server Settings** shown below are identical across all clients:

### Generic MCP Server Settings

- **npm package name**: `@syncfusion/maui-assistant`
- **Type**: stdio (standard input/output transport)
- **Command**: npx
- **Arguments**: -y
- **Server name**: syncfusionMAUIAssistant

You need to add your [Syncfusion API key](https://syncfusion.com/account/api-key) as an env parameter in the configuration file:

```json
"env": {
  "Syncfusion_API_Key": "YOUR_API_KEY"
}
```

`SyncfusionMAUIAssistant` can be configured in various MCP clients. Below are setup instructions for popular environment:

### Syncfusion<sup style="font-size:70%">&reg;</sup> Code Studio

* In [Code Studio](https://www.syncfusion.com/code-studio/), open MCP Marketplace, find `SyncfusionMAUIAssistant`, and click Install.
* When prompted, enter your [Syncfusion API key](https://syncfusion.com/account/api-key) and click Submit to register.
* It installs locally on your machine and appears in the Installed list.
* The server is ready for use in Code Studio.

For additional details, see the Code Studio [documentation](https://help.syncfusion.com/code-studio/reference/configure-properties/mcp/marketplace).

### VS Code (GitHub Copilot MCP)

1. To configure an MCP server for a specific workspace, you can create a `.vscode/mcp.json` file in your workspace folder.

```json
{
  "servers": {
    "syncfusion-maui-assistant": {
      "type": "stdio",
      "command": "npx",
      "args": [
        "-y",
        "@syncfusion/maui-assistant@latest"
      ],
      "env": {
        "Syncfusion_API_Key": "YOUR_API_KEY"
      }
    }
  }
}
```

2. After updating the configuration in settings.json, you'll notice a "Start" option at the top of the config. This allows you to easily start the `SyncfusionMAUIAssistant` server directly from the settings interface without additional commands.

3. Confirm that `SyncfusionMAUIAssistant` is being used (this does not happen automatically). Look for a statement in the output, which is similar to:
    * `SyncfusionMAUIAssistant is running...` (in VS Code)

### Cursor

To configure an MCP server for a specific workspace, you can create a .cursor/mcp.json file in your workspace folder.

```json
{
  "mcpServers": {
    "syncfusion-maui-assistant": {
      "type": "stdio",
      "command": "npx",
      "args": [
        "-y",
        "@syncfusion/maui-assistant@latest"
      ],
      "env": {
       "Syncfusion_API_Key": "YOUR_API_KEY"
      }
    }
  }
}
```

### JetBrains IDEs

1. Go to Settings -> Tools -> AI Assistant -> Model Context Protocol (MCP).
2. Click + Add to add a new MCP server configuration.
3. In the New MCP Server dialog, switch the dropdown as `As JSON` and add the following config:

```json
{
  "mcpServers": {
    "syncfusion-maui-assistant": {
      "command": "npx",
      "args": [
        "-y",
        "@syncfusion/maui-assistant@latest"
      ],
      "env": {
       "Syncfusion_API_Key": "YOUR_API_KEY"
      }
    }
  }
}
```

4. Click OK and Apply.

> For more detailed information about configuring MCP servers in various clients, refer to the official documentations.
  * [VS Code](https://code.visualstudio.com/docs/copilot/chat/mcp-servers#_add-an-mcp-server)
  * [Cursor](https://cursor.com/docs/context/mcp#using-mcp-json)
  * [JetBrains](https://www.jetbrains.com/help/ai-assistant/mcp.html#connect-to-an-mcp-server)
  * [Windsurf](https://docs.windsurf.com/windsurf/cascade/mcp#mcp-config-json)

## Usage

To activate the SyncfusionMAUIAssistant MCP server:

1. Start your prompt with one of the following:
    * 'SyncfusionMAUIAssistant'
    * '/syncfusion-maui-assistant'
    * '/syncfusion-maui'
    * '@syncfusion-maui'
    * '@ask_syncfusion_maui'
    * 'maui'

   In VS Code, you can also use #SyncfusionMAUIAssistant to explicitly invoke the MCP server.

2. Grant the SyncfusionMAUIAssistant MCP server a permission to run for this session, workspace, or always.
3. For best results, start a new chat for each new topic to maintain clean context.

### Mode availability

Syncfusion<sup style="font-size:70%">&reg;</sup> MCP Servers provide full access to all AI interaction modes — Ask/Chat, Edit, and Agent — across supported MCP clients.

### Best Practices for Effective Usage

1. `Be specific`: Mention both platform and component (e.g., "How do I create a Syncfusion MAUI DataGrid with paging and filtering?").
2. `Provide context`: Include details about your use case for more targeted solutions.
3. `Use descriptive queries`: Avoid vague questions that lack necessary context.
4. `Start fresh for new topics`: Begin a new chat session when switching components or topics.

### Example Queries

Here are some effective ways to use `SyncfusionMAUIAssistant`:

 * "Create a Syncfusion .NET MAUI DataGrid component with paging, sorting and filtering"
 * "How do I implement data binding with Syncfusion .NET MAUI Scheduler?"

## Troubleshooting

If you encounter issues:

 * Verify your API key is correctly configured.
 * Ensure the MCP server is enabled in your client's tools selection.
 * Check that you're using a compatible MCP client version.
 * Try restarting your development environment.

## Support

Product support is available through the following mediums.

* [Support ticket](https://support.syncfusion.com/support/tickets/create) - Guaranteed Response in 24 hours \| Unlimited tickets \| Holiday support
* [Community forum](https://www.syncfusion.com/forums/maui)
* [Request feature or report bug](https://www.syncfusion.com/feedback/maui)
* Live chat

## See also

* [Syncfusion .NET MAUI Documentation](https://help.syncfusion.com/maui/introduction/overview)