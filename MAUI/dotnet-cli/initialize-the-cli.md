---
layout: post
title: Initialize the Syncfusion .NET CLI | Syncfusion®
description: Learn how to start the Syncfusion® .NET CLI (sf), navigate the interactive main menu, and follow the keyboard conventions used across all workflows.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Initialize the Syncfusion<sup>®</sup> .NET CLI

After installation, run `sf` in an interactive terminal to open the main menu. The menu shows the current CLI version and groups the available operations.

![Syncfusion .NET CLI main menu](images/cli-main-menu.png)

## Main menu operations

| Group | Operation | Command reference |
| --- | --- | --- |
| Project creation | Create a new project | `sf new` |
| Package management | Add a package to an existing project | `sf add` |
| Package management | Update a package in an existing project | `sf update` |
| Discovery | List available packages | `sf list <platform> packages` |
| Discovery | List installed packages in an existing project | `sf list <platform> installed` |
| Discovery | Search for packages | `sf search` |
| Help and information | View CLI information | `sf info` |
| Help and information | Show help | `sf help` |
| Exit | Exit | `Ctrl+C` |

N> Package removal is temporarily disabled. The **Remove a package** operation does not appear in the menu while improvements are in progress.

## Keyboard navigation

| Key | Action |
| --- | --- |
| Up / Down | Move through the options |
| Enter | Choose the focused option, or continue |
| Space | Toggle a checkbox in a multi-selection list |
| Escape | Cancel the current question and return to the menu |
| `Ctrl+C` | Exit the interactive session with exit code 130 |

Single-choice menus focus the first option. Multi-selection screens start with no entries selected and require at least one selection when controls are included. Escape on the main menu keeps the menu open. `Ctrl+C` prints `The operation was canceled.`

N> Complete direct commands remain usable without opening the menu. Every wizard input has a command equivalent, so scripts can pass `--no-interactive` and supply each value as an option.