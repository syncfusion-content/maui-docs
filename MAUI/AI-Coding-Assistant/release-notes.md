---
layout: post
title: Release Notes - Syncfusion MAUI AI Coding Assistants | Syncfusion
description: Explore the release notes for Syncfusion MAUI AI Coding Assistants, covering MCP Server, Skills, and Agentic UI Builder updates across all versions.
control: Syncfusion MAUI AI Coding Assistants Release Notes
platform: MAUI
documentation: ug
domainurl: ##DomainURL##
---

# Syncfusion MAUI AI Coding Assistants Release Notes

This document provides information about the changes and new features included in each version of the Syncfusion MAUI AI Coding Assistants, including the [Syncfusion.Maui.MCP](https://www.nuget.org/packages/Syncfusion.Maui.MCP) MCP Server, Skills, Agentic UI Builder and so on.

## MCP Server

**(v1.0.0) - August 3, 2026**

**Feature**

- The [Syncfusion.Maui.MCP](https://www.nuget.org/packages/Syncfusion.Maui.MCP) .NET packages is now available on NuGet, enabling seamless integration of Syncfusion MAUI controls with MCP-based workflows.
- Introduced the **search_docs** coding assistant tool, which provides contextual documentation, code samples, API guidance, and configuration examples for Syncfusion controls directly within the development workflow.

## Skills

**Features**

- Introduced [Agent Skills](https://www.syncfusion.com/explore/agent-skills) — a set of lightweight, modular capabilities that extend the AI Coding Assistants with specialized knowledge, including pre-defined instructions, best practices, and curated code patterns for building MAUI applications with Syncfusion components.
- Each skill is defined in a simple, readable `SKILL.md` file that specifies the correct setup, required modules, current APIs and patterns, and what a valid implementation looks like for a given component.
- Works as a standard, lightweight approach supported by modern AI development tools: install skills, the tool detects them, and the relevant skill is automatically applied to the user's prompt.

## Agentic UI Builder

**(v1.0.0) - Jun 5, 2026**

**Features**

- Evolved the [Agentic UI Builder](https://www.syncfusion.com/explore/agentic-ui-builder) architecture with Agent Skills, bringing implementation guidance directly into the project environment for more project-aware, context-grounded UI generation.
- Made UI generation easier to customize and align with internal coding standards and conventions.
- Streamlined the local development experience while preserving the same AI-assisted UI generation workflow developers already rely on.
