---
layout: post
title: System Requirements for .NET MAUI | Syncfusion®
description: Describes system requirements for Syncfusion® .NET MAUI Components, including supported platforms, .NET versions, and development environments.
platform: MAUI
control: Installation and Deployment
documentation: UG
---

# System Requirements for .NET MAUI

The following are the system requirements for using the Syncfusion<sup>®</sup> .NET MAUI platform.

<style>
  /* ---------- Shared grid + card ---------- */
  .requirements-grid {
    display: flex;
    flex-wrap: wrap;
    grid-template-columns: 1fr 1fr;
    gap: 14px;
    margin: 0 0 8px 0;
  }
  .info-card {
    flex: 0 0 calc(33.33% - 14px);
    max-width: calc(33.33% - 14px);
    box-sizing: border-box;
    padding: 18px 18px 16px 18px;
    border-radius: 14px;
    border: 1px solid #E6E6E6;
    background: #ffffff;
    display: flex;
    flex-direction: column;
    gap: 8px;
    color: inherit;
  }
  .info-card .label {
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 0.6px;
    text-transform: uppercase;
    color: #6B6B6B;
    margin: 0;
  }
  .info-card .value {
    font-size: 15px;
    color: #1F1F1F;
    line-height: 1.5;
    margin: 0;
  }
  @media (max-width: 600px) {
    .info-card { flex: 0 0 calc(50% - 10px); max-width: calc(50% - 10px); }
  }
  @media (max-width: 350px) {
    .info-card { flex: 0 0 100%; max-width: 100%; }
  }

  /* ---------- Operating Systems: tinted feature list ---------- */
  .system-requirements-list {
    display: flex;
    flex-direction: column;
    gap: 10px;
    margin: 0 0 8px 0;
  }
  .system-requirement-row {
    display: flex;
    align-items: center;
    gap: 16px;
    padding: 14px 16px;
    border-radius: 12px;
    border: 1px solid #E6E6E6;
    background: #ffffff;
  }
  .system-requirement-row .system-requirement-body { flex: 1; }
  .system-requirement-row .system-requirement-name {
    font-size: 15px;
    font-weight: 600;
    color: #1F1F1F;
    margin: 0 0 2px 0;
  }
  .system-requirement-row .system-requirement-version {
    font-size: 13px;
    color: #0078D4;
    font-weight: 600;
    margin: 0;
  }
  .system-requirement-row .system-requirement-editions {
    font-size: 13px;
    color: #555;
    line-height: 1.5;
    margin: 0;
  }

  /* ---------- Hardware Environment: stat tiles ---------- */
  .hardware-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 14px;
    margin: 0 0 8px 0;
  }
  .hardware-tile {
    position: relative;
    padding: 22px 20px;
    border-radius: 14px;
    background: linear-gradient(135deg, #F2F6FF 0%, #E8F0FE 100%);
    border: 1px solid #D6E0F5;
    overflow: hidden;
  }
  .hardware-tile::after {
    content: "";
    position: absolute;
    right: -20px;
    top: -20px;
    width: 80px;
    height: 80px;
    border-radius: 50%;
    background: rgba(0, 120, 212, 0.08);
  }
  .hardware-tile .hardware-label {
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 0.6px;
    text-transform: uppercase;
    color: #005A9E;
    margin: 0 0 6px 0;
  }
  .hardware-tile .hardware-value {
    font-size: 17px;
    font-weight: 600;
    color: #1F1F1F;
    line-height: 1.4;
    margin: 0;
  }
  @media (max-width: 900px) { .hardware-grid { grid-template-columns: 1fr 1fr; } }
  @media (max-width: 600px) { .hardware-grid { grid-template-columns: 1fr; } }

  /* ---------- Development Environment: icon-led horizontal cards ---------- */
  .development-list {
    display: flex !important;
    flex-direction: column !important;
    gap: 12px !important;
    margin: 0 0 8px 0;
  }
  .development-row {
    display: flex !important;
    align-items: center !important;
    gap: 16px;
    padding: 16px 18px;
    border-radius: 12px;
    background: #ffffff;
    border: 1px solid #E6E6E6;
  }
  .development-row .development-logo {
    flex: 0 0 48px;
    width: 48px;
    height: 48px;
    border-radius: 12px;
    display: inline-flex !important;
    align-items: center !important;
    justify-content: center !important;
    font-size: 22px;
    color: #ffffff;
    font-weight: 700;
    font-family: "Segoe UI", system-ui, sans-serif;
  }
  .development-row.vs2026 .development-logo { background: linear-gradient(135deg, #854CC7 0%, #5E2D9C 100%); }
  .development-row.vs2022 .development-logo { background: linear-gradient(135deg, #6E4FCC 0%, #4A2A99 100%); }
  .development-row.code .development-logo { background: linear-gradient(135deg, #0078D7 0%, #00509E 100%); }
  .development-row.rider .development-logo { background: linear-gradient(135deg, #FE315D 0%, #C40030 100%); }
  .development-row .development-name {
    font-size: 15px;
    font-weight: 600;
    color: #1F1F1F;
    margin: 0;
  }
  .development-row .development-version {
    margin-left: auto;
    display: inline-flex;
    align-items: center;
    gap: 6px;
    padding: 5px 12px;
    border-radius: 999px;
    background: #F1F4F9;
    color: #1F1F1F;
    font-size: 13px;
    font-weight: 600;
  }
  .development-row .development-version .dot {
    width: 8px;
    height: 8px;
    border-radius: 50%;
    background: #2E7D32;
    display: inline-block;
  }
  .development-row.code .development-version .dot { background: #0078D7; }

  /* ---------- .NET Versions: colorful gradient tiles ---------- */
  .net-version-grid {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 16px;
    margin: 0 0 8px 0;
  }
  .net-version-tile {
    position: relative;
    padding: 26px 24px;
    border-radius: 16px;
    color: #ffffff;
    overflow: hidden;
    border: 1px solid transparent;
  }
  .net-version-tile.net-version-10 { background: linear-gradient(135deg, #512BD4 0%, #2B0A8C 100%); }
  .net-version-tile.net-version-9  { background: linear-gradient(135deg, #0078D4 0%, #00509E 100%); }
  .net-version-tile::before {
    content: "";
    position: absolute;
    right: -30px;
    bottom: -30px;
    width: 140px;
    height: 140px;
    border-radius: 50%;
    background: rgba(255,255,255,0.08);
  }
  .net-version-tile::after {
    content: "";
    position: absolute;
    right: 20px;
    top: 20px;
    width: 60px;
    height: 60px;
    border-radius: 50%;
    background: rgba(255,255,255,0.1);
  }
  .net-version-tile .net-version-label {
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 0.8px;
    text-transform: uppercase;
    color: rgba(255,255,255,0.85);
    margin: 0 0 6px 0;
  }
  .net-version-tile .net-version-number {
    font-size: 32px;
    font-weight: 700;
    line-height: 1.1;
    margin: 0;
    font-family: "Segoe UI", system-ui, sans-serif;
  }
  .net-version-tile .net-version-status {
    display: inline-flex;
    align-items: center;
    gap: 6px;
    margin-top: 14px;
    padding: 4px 12px;
    border-radius: 999px;
    background: rgba(255,255,255,0.18);
    font-size: 12px;
    font-weight: 600;
    letter-spacing: 0.3px;
  }
  .net-version-tile .net-version-status .dot {
    width: 8px;
    height: 8px;
    border-radius: 50%;
    background: #6FFFB0;
    box-shadow: 0 0 6px #6FFFB0;
  }
  @media (max-width: 700px) { .net-version-grid { grid-template-columns: 1fr; } }

  /* ---------- Supported Platforms: styled list (div-based) ---------- */
  .platform-requirements-table {
    width: 100%;
    border: 1px solid #E6E6E6;
    border-radius: 12px;
    overflow: hidden;
    background: #ffffff;
    margin: 0 0 8px 0;
    font-size: 14px;
    font-family: "Segoe UI", system-ui, -apple-system, BlinkMacSystemFont, sans-serif;
  }
  .platform-requirements-table .platform-requirements-header,
  .platform-requirements-table .platform-requirements-row {
    display: flex;
    align-items: stretch;
    width: 100%;
  }
  .platform-requirements-table .platform-requirements-header {
    background: #F4F7FB;
    color: #1F1F1F;
    text-align: left;
    font-weight: 700;
    font-size: 13px;
    letter-spacing: 0.4px;
    text-transform: uppercase;
    border-bottom: 1px solid #E6E6E6;
  }
  .platform-requirements-table .platform-requirements-header .header-cell,
  .platform-requirements-table .platform-requirements-row .row-cell {
    box-sizing: border-box;
    padding: 12px 14px;
    min-width: 0;
    word-wrap: break-word;
    overflow-wrap: break-word;
  }
  .platform-requirements-table .platform-requirements-row {
    border-bottom: 1px solid #F0F0F0;
    color: #1F1F1F;
  }
  .platform-requirements-table .platform-requirements-row:last-child { border-bottom: none; }
  .platform-requirements-table .platform-requirements-row .row-cell {
    padding-top: 14px;
    padding-bottom: 14px;
  }
  .platform-requirements-table .platform-cell {
    font-weight: 600;
  }
</style>

## Operating Systems & Hardware

The following table summarizes the operating systems and hardware required to develop, build, and run Syncfusion<sup>®</sup> .NET MAUI applications on Windows and macOS (Mac Catalyst).

<div class="platform-requirements-table">
  <div class="platform-requirements-header">
    <div class="header-cell" style="flex: 0 0 22%;">Category</div>
    <div class="header-cell" style="flex: 1 1 39%;">Windows</div>
    <div class="header-cell" style="flex: 1 1 39%;">macOS (Mac Catalyst)</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 22%;"><span class="platform-cell">Operating System</span></div>
    <div class="row-cell" style="flex: 1 1 39%;">Windows 10 version 1909 or later &bull; Windows Server 2019 or later</div>
    <div class="row-cell" style="flex: 1 1 39%;">macOS 12 or later</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 22%;"><span class="platform-cell">Development Tools</span></div>
    <div class="row-cell" style="flex: 1 1 39%;">Visual Studio 2022 or later (with .NET MAUI workload), .NET SDK, Android SDK &amp; JDK</div>
    <div class="row-cell" style="flex: 1 1 39%;">Visual Studio Code, Xcode, Command Line Tools, .NET SDK, Android SDK &amp; JDK</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 22%;"><span class="platform-cell">Architecture</span></div>
    <div class="row-cell" style="flex: 1 1 39%;">x86 / x64</div>
    <div class="row-cell" style="flex: 1 1 39%;">Apple Silicon (M1+) recommended</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 22%;"><span class="platform-cell">Processor</span></div>
    <div class="row-cell" style="flex: 1 1 39%;">1.8 GHz or faster, quad-core recommended</div>
    <div class="row-cell" style="flex: 1 1 39%;">1.8 GHz or faster, quad-core recommended</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 22%;"><span class="platform-cell">Memory</span></div>
    <div class="row-cell" style="flex: 1 1 39%;">Minimum 4 GB RAM &bull; Recommended 16 GB RAM</div>
    <div class="row-cell" style="flex: 1 1 39%;">Minimum 4 GB RAM &bull; Recommended 16 GB RAM</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 22%;"><span class="platform-cell">Disk Space</span></div>
    <div class="row-cell" style="flex: 1 1 39%;">Up to 210 GB available storage</div>
    <div class="row-cell" style="flex: 1 1 39%;">Up to 210 GB available storage</div>
  </div>
</div>


## Development Environment

Our .NET MAUI components are compatible with the following development environments.

<div class="development-list">
  <div class="development-row vs2026">
    <div class="development-logo">VS</div>
    <p class="development-name">Visual Studio 2026</p>
    <span class="development-version"><span class="dot"></span>Version 18.0.0 or later</span>
  </div>
  <div class="development-row vs2022">
    <div class="development-logo">VS</div>
    <p class="development-name">Visual Studio 2022</p>
    <span class="development-version"><span class="dot"></span>Version 17.8.0 or later</span>
  </div>
  <div class="development-row code">
    <div class="development-logo">VS</div>
    <p class="development-name">Visual Studio Code</p>
    <span class="development-version"><span class="dot"></span>Supports all versions</span>
  </div>
  <div class="development-row rider">
    <div class="development-logo">JR</div>
    <p class="development-name">JetBrains Rider</p>
    <span class="development-version"><span class="dot"></span>Version 2025.1 or later</span>
  </div>
</div>


<style>
  /* Padding inside note-style blockquotes (Reference / Additional Information) */
  blockquote.note,
  blockquote:has(> p > strong:first-child) {
    padding: 8px 16px !important;
    border-left-width: 4px !important;
  }
</style>

> **Reference**
>
> For more information on .NET MAUI support in Visual Studio Code, see the [announcing the .NET MAUI extension for Visual Studio Code](https://devblogs.microsoft.com/visualstudio/announcing-the-dotnet-maui-extension-for-visual-studio-code/) blog post.

## Supported .NET Versions

The following .NET versions are supported.

<div class="net-version-grid">
  <div class="net-version-tile net-version-10">
    <p class="net-version-label">Long Term Support</p>
    <p class="net-version-number">.NET 10.0</p>
    <span class="net-version-status"><span class="dot"></span>Supported</span>
  </div>
  <div class="net-version-tile net-version-9">
    <p class="net-version-label">Standard Term Support</p>
    <p class="net-version-number">.NET 9.0</p>
    <span class="net-version-status"><span class="dot"></span>Supported</span>
  </div>
</div>

## Supported Platforms

.NET Multi-platform App UI (.NET MAUI) apps can be developed for the following platforms.

<div class="platform-requirements-table">
  <div class="platform-requirements-header">
    <div class="header-cell" style="flex: 0 0 28%;">Platform</div>
    <div class="header-cell" style="flex: 1 1 auto;">Supported Version</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 28%;"><span class="platform-cell">Android</span></div>
    <div class="row-cell" style="flex: 1 1 auto;">Android 5.0 (API 21) or higher</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 28%;"><span class="platform-cell">iOS</span></div>
    <div class="row-cell" style="flex: 1 1 auto;">iOS 12.2 or higher</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 28%;"><span class="platform-cell">macOS</span></div>
    <div class="row-cell" style="flex: 1 1 auto;">macOS 12 or higher, using Mac Catalyst</div>
  </div>
  <div class="platform-requirements-row">
    <div class="row-cell" style="flex: 0 0 28%;"><span class="platform-cell">Windows</span></div>
    <div class="row-cell" style="flex: 1 1 auto;">Windows 11 and Windows 10 version 1809 or higher, using Windows UI Library (WinUI) 3</div>
  </div>
</div>


> **Additional Information**
>
> Learn more about the [Windows UI Library (WinUI) 3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/).
