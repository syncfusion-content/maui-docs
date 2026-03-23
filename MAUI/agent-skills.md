---
layout: post
title: Syncfusion .NET MAUI Agent Skills for AI Assistants | Syncfusion
description: Learn how to install and use Syncfusion Agent Skills to enhance AI assistants with accurate Syncfusion .NET MAUI component guidance.
control: Skills
platform: maui
documentation: ug
---

# Syncfusion .NET MAUI Agent Skills for AI Assistants

This guide introduces **Syncfusion .NET MAUI Skills**, a knowledge package that enables AI assistants (VS Code, Cursor, CodeStudio, etc.) to understand and generate accurate Syncfusion® .NET MAUI code using official APIs, patterns, and theming guidelines.

Syncfusion® Skills eliminate common issues with generic AI suggestions by grounding the assistant in accurate Syncfusion® component usage patterns, API structures, supported features, and project-specific configuration.

## Installation

Choose one of the following commands to install [Syncfusion® .NET MAUI component skills](https://github.com/syncfusion/maui-ui-components-skills.git) based on your preference. Users can also explore Syncfusion skills from the [marketplace](https://skills.sh/syncfusion/).

```bash
# Install all component skills at once
npx skills add syncfusion/maui-ui-components-skills -y

# Choose and install skills interactively from the terminal
npx skills add syncfusion/maui-ui-components-skills
```

This registers the Syncfusion® skill pack so your AI assistant can automatically load it in supported IDEs such as [Code Studio](https://help.syncfusion.com/code-studio/reference/configure-properties/skills), [Visual Studio Code](https://code.visualstudio.com/docs/copilot/customization/agent-skills), and [Cursor](https://cursor.com/docs/skills).

To learn more about the Skills CLI, refer [here](https://skills.sh/docs). 

## What's included

1. **Component Usage & API Knowledge** - Curated, Skill-based guidance that captures how to add, configure, and compose Syncfusion® .NET MAUI components, including key properties, events, required NuGet packages, and common integration patterns.
2. **Patterns & Best Practices** - Practical recommendations for API structures, MVVM data-binding approaches, and feature configuration workflows (for example, paging, sorting, and filtering for data components). All guidance is authored directly within the Skill file rather than being fetched from documentation.
3. **Design-System Guidance** - Includes information related to themes, dark/light variants, and icon usage patterns across Syncfusion® .NET MAUI components.

## How Syncfusion® Agent Skills Work

1. **Reads the relevant Skill files based on the user's query**, with the assistant retrieving component usage patterns, APIs, and best-practice guidance from the installed Syncfusion® Skills.
2. **Enforces Syncfusion® best practices**, including:
   - Referencing the correct NuGet packages for each component.
   - Applying MVVM data-binding patterns and platform-specific initialisation (for example, `MauiProgram.cs` handler registration).
   - Adding the correct theme resource dictionaries and style imports.
3. **Generates component-accurate code**, avoiding invalid properties or unsupported patterns.

### Using the AI Assistant

Once skills are installed, the assistant can be used to generate and update Syncfusion® .NET MAUI code for tasks such as:

- "Add a DataGrid with paging, sorting, and filtering."
- "Create a Scheduler with week view and drag-drop."
- "Apply the Material Dark theme to all Syncfusion components."

## See also

- [Agent Skills Standards](https://agentskills.io/home)
- [SKills CLI](https://skills.sh/docs)