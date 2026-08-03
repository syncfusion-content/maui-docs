---
layout: post
title: System Requirements for Syncfusion® .NET MAUI | Syncfusion
description: Describes the system requirements for installing the Syncfusion® .NET MAUI Components and lists the supported platforms, .NET versions, and development environments.
platform: MAUI
control: Installation and Deployment
documentation: UG
---

# System Requirements for .NET MAUI

The following are the system requirements for using the Syncfusion<sup>®</sup> .NET MAUI platform.

<style>
  /* ---------- Shared grid + card ---------- */
  .req-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 14px;
    margin: 0 0 8px 0;
  }
  .form-card {
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
    transition: all 0.25s ease;
    color: inherit;
  }
  .form-card:hover {
    transform: translateY(-3px);
    box-shadow: 0 10px 25px rgba(0,0,0,0.08);
    border-color: #D5D5D5;
  }
  .form-card .label {
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 0.6px;
    text-transform: uppercase;
    color: #6B6B6B;
    margin: 0;
  }
  .form-card .value {
    font-size: 15px;
    color: #1F1F1F;
    line-height: 1.5;
    margin: 0;
  }
  @media (max-width: 900px) {
    .form-card { flex: 0 0 calc(50% - 10px); max-width: calc(50% - 10px); }
  }
  @media (max-width: 600px) {
    .form-card { flex: 0 0 100%; max-width: 100%; }
  }

  /* ---------- Operating Systems: tinted feature list ---------- */
  .os-list {
    display: flex;
    flex-direction: column;
    gap: 10px;
    margin: 0 0 8px 0;
  }
  .os-row {
    display: flex;
    align-items: center;
    gap: 16px;
    padding: 14px 16px;
    border-radius: 12px;
    border: 1px solid #E6E6E6;
    background: #ffffff;
    transition: all 0.2s ease;
  }
  .os-row:hover {
    background: #F7F9FC;
    border-color: #D5D5D5;
  }
  .os-row .os-body { flex: 1; }
  .os-row .os-name {
    font-size: 15px;
    font-weight: 600;
    color: #1F1F1F;
    margin: 0 0 2px 0;
  }
  .os-row .os-version {
    font-size: 13px;
    color: #0078D4;
    font-weight: 600;
    margin: 0;
  }
  .os-row .os-editions {
    font-size: 13px;
    color: #555;
    line-height: 1.5;
    margin: 0;
  }

  /* ---------- Hardware Environment: stat tiles ---------- */
  .hw-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 14px;
    margin: 0 0 8px 0;
  }
  .hw-tile {
    position: relative;
    padding: 22px 20px;
    border-radius: 14px;
    background: linear-gradient(135deg, #F2F6FF 0%, #E8F0FE 100%);
    border: 1px solid #D6E0F5;
    overflow: hidden;
  }
  .hw-tile::after {
    content: "";
    position: absolute;
    right: -20px;
    top: -20px;
    width: 80px;
    height: 80px;
    border-radius: 50%;
    background: rgba(0, 120, 212, 0.08);
  }
  .hw-tile .hw-label {
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 0.6px;
    text-transform: uppercase;
    color: #005A9E;
    margin: 0 0 6px 0;
  }
  .hw-tile .hw-value {
    font-size: 17px;
    font-weight: 600;
    color: #1F1F1F;
    line-height: 1.4;
    margin: 0;
  }
  @media (max-width: 900px) { .hw-grid { grid-template-columns: 1fr 1fr; } }
  @media (max-width: 600px) { .hw-grid { grid-template-columns: 1fr; } }

  /* ---------- Development Environment: icon-led horizontal cards ---------- */
  .dev-list {
    display: flex;
    flex-direction: column;
    gap: 12px;
    margin: 0 0 8px 0;
  }
  .dev-row {
    display: flex;
    align-items: center;
    gap: 16px;
    padding: 16px 18px;
    border-radius: 12px;
    background: #ffffff;
    border: 1px solid #E6E6E6;
    transition: all 0.2s ease;
  }
  .dev-row:hover {
    border-color: #C5C5C5;
    box-shadow: 0 6px 18px rgba(0,0,0,0.06);
  }
  .dev-row .dev-logo {
    flex: 0 0 48px;
    width: 48px;
    height: 48px;
    border-radius: 12px;
    display: inline-flex;
    align-items: center;
    justify-content: center;
    font-size: 22px;
    color: #ffffff;
    font-weight: 700;
    font-family: "Segoe UI", system-ui, sans-serif;
  }
  .dev-row.vs2026 .dev-logo { background: linear-gradient(135deg, #854CC7 0%, #5E2D9C 100%); }
  .dev-row.vs2022 .dev-logo { background: linear-gradient(135deg, #6E4FCC 0%, #4A2A99 100%); }
  .dev-row.vscode .dev-logo { background: linear-gradient(135deg, #0078D7 0%, #00509E 100%); }
  .dev-row .dev-name {
    font-size: 15px;
    font-weight: 600;
    color: #1F1F1F;
    margin: 0;
  }
  .dev-row .dev-version {
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
  .dev-row .dev-version .dot {
    width: 8px;
    height: 8px;
    border-radius: 50%;
    background: #2E7D32;
    display: inline-block;
  }
  .dev-row.vscode .dev-version .dot { background: #0078D7; }

  /* ---------- .NET Versions: colorful gradient tiles ---------- */
  .net-grid {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 16px;
    margin: 0 0 8px 0;
  }
  .net-tile {
    position: relative;
    padding: 26px 24px;
    border-radius: 16px;
    color: #ffffff;
    overflow: hidden;
    border: 1px solid transparent;
    transition: transform 0.25s ease, box-shadow 0.25s ease;
  }
  .net-tile:hover {
    transform: translateY(-4px);
    box-shadow: 0 14px 30px rgba(0,0,0,0.15);
  }
  .net-tile.net10 { background: linear-gradient(135deg, #512BD4 0%, #2B0A8C 100%); }
  .net-tile.net9  { background: linear-gradient(135deg, #0078D4 0%, #00509E 100%); }
  .net-tile::before {
    content: "";
    position: absolute;
    right: -30px;
    bottom: -30px;
    width: 140px;
    height: 140px;
    border-radius: 50%;
    background: rgba(255,255,255,0.08);
  }
  .net-tile::after {
    content: "";
    position: absolute;
    right: 20px;
    top: 20px;
    width: 60px;
    height: 60px;
    border-radius: 50%;
    background: rgba(255,255,255,0.1);
  }
  .net-tile .net-label {
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 0.8px;
    text-transform: uppercase;
    color: rgba(255,255,255,0.85);
    margin: 0 0 6px 0;
  }
  .net-tile .net-version {
    font-size: 32px;
    font-weight: 700;
    line-height: 1.1;
    margin: 0;
    font-family: "Segoe UI", system-ui, sans-serif;
  }
  .net-tile .net-status {
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
  .net-tile .net-status .dot {
    width: 8px;
    height: 8px;
    border-radius: 50%;
    background: #6FFFB0;
    box-shadow: 0 0 6px #6FFFB0;
  }
  @media (max-width: 700px) { .net-grid { grid-template-columns: 1fr; } }

  /* ---------- Supported Platforms: styled table ---------- */
  .platform-table {
    width: 100%;
    border-collapse: separate;
    border-spacing: 0;
    border: 1px solid #E6E6E6;
    border-radius: 12px;
    overflow: hidden;
    background: #ffffff;
    margin: 0 0 8px 0;
    font-size: 14px;
  }
  .platform-table thead th {
    background: #F4F7FB;
    color: #1F1F1F;
    text-align: left;
    font-weight: 700;
    font-size: 13px;
    letter-spacing: 0.4px;
    text-transform: uppercase;
    padding: 12px 16px;
    border-bottom: 1px solid #E6E6E6;
  }
  .platform-table tbody td {
    padding: 14px 16px;
    border-bottom: 1px solid #F0F0F0;
    vertical-align: top;
    color: #1F1F1F;
  }
  .platform-table tbody tr:last-child td { border-bottom: none; }
  .platform-table tbody tr:hover { background: #FAFCFF; }
  .platform-table .plat-cell {
    font-weight: 600;
  }
</style>

## Requirements at a Glance

<div class="req-grid">
  <div class="form-card">
    <p class="label">Operating Systems</p>
    <p class="value">Windows 11 (21H2+), Windows 10 (1909+), Windows Server 2016/2019/2022</p>
  </div>
  <div class="form-card">
    <p class="label">Hardware</p>
    <p class="value">x86 or x64 processor, 4 GB RAM (minimum), 16 GB (recommended), up to 210 GB free disk space</p>
  </div>
  <div class="form-card">
    <p class="label">Development Environment</p>
    <p class="value">Visual Studio 2026 18.0.0, Visual Studio 2022 17.8.0, Visual Studio Code</p>
  </div>
  <div class="form-card">
    <p class="label">.NET Versions</p>
    <p class="value">.NET 9.0, .NET 10.0</p>
  </div>
  <div class="form-card">
    <p class="label">Supported Platforms</p>
    <p class="value">Android, iOS, macOS, Windows</p>
  </div>
</div>

## Operating Systems

The following operating systems are supported.

<div class="os-list">
  <div class="os-row">
    <div class="os-body">
      <p class="os-name">Windows 11</p>
      <p class="os-editions">Home, Pro, Pro Education, Pro for Workstations, Enterprise, and Education</p>
    </div>
    <p class="os-version">Version 21H2 or higher</p>
  </div>
  <div class="os-row">
    <div class="os-body">
      <p class="os-name">Windows 10</p>
      <p class="os-editions">Home, Professional, Education, and Enterprise</p>
    </div>
    <p class="os-version">Version 1909 or higher</p>
  </div>
  <div class="os-row">
    <div class="os-body">
      <p class="os-name">Windows Server 2022</p>
      <p class="os-editions">Standard and Datacenter</p>
    </div>
    <p class="os-version">Latest release</p>
  </div>
  <div class="os-row">
    <div class="os-body">
      <p class="os-name">Windows Server 2019</p>
      <p class="os-editions">Standard and Datacenter</p>
    </div>
    <p class="os-version">Latest release</p>
  </div>
  <div class="os-row">
    <div class="os-body">
      <p class="os-name">Windows Server 2016</p>
      <p class="os-editions">Standard and Datacenter</p>
    </div>
    <p class="os-version">Latest release</p>
  </div>
</div>

## Hardware Environment

<div class="hw-grid">
  <div class="hw-tile">
    <p class="hw-label">Processor</p>
    <p class="hw-value">x86 or x64</p>
  </div>
  <div class="hw-tile">
    <p class="hw-label">RAM</p>
    <p class="hw-value">4 GB (minimum)<br>16 GB (recommended)</p>
  </div>
  <div class="hw-tile">
    <p class="hw-label">Hard Disk</p>
    <p class="hw-value">Up to 210 GB of free space</p>
  </div>
</div>

## Development Environment

Our .NET MAUI components are compatible with the following development environments.

<div class="dev-list">
  <div class="dev-row vs2026">
    <div class="dev-logo">VS</div>
    <p class="dev-name">Visual Studio 2026</p>
    <span class="dev-version"><span class="dot"></span>Version 18.0.0</span>
  </div>
  <div class="dev-row vs2022">
    <div class="dev-logo">VS</div>
    <p class="dev-name">Visual Studio 2022</p>
    <span class="dev-version"><span class="dot"></span>Version 17.8.0</span>
  </div>
  <div class="dev-row vscode">
    <div class="dev-logo">VS</div>
    <p class="dev-name">Visual Studio Code</p>
    <span class="dev-version"><span class="dot"></span>Supported</span>
  </div>
</div>


> **Reference**
>
> For more information on .NET MAUI support in Visual Studio Code, see the [announcing the .NET MAUI extension for Visual Studio Code](https://devblogs.microsoft.com/visualstudio/announcing-the-dotnet-maui-extension-for-visual-studio-code/) blog post.

## Supported .NET Versions

The following .NET versions are supported.

<div class="net-grid">
  <div class="net-tile net10">
    <p class="net-label">Latest</p>
    <p class="net-version">.NET 10.0</p>
    <span class="net-status"><span class="dot"></span>Supported</span>
  </div>
  <div class="net-tile net9">
    <p class="net-label">Previous</p>
    <p class="net-version">.NET 9.0</p>
    <span class="net-status"><span class="dot"></span>Supported</span>
  </div>
</div>

## Supported Platforms

.NET Multi-platform App UI (.NET MAUI) apps can be developed for the following platforms.

<table class="platform-table">
  <thead>
    <tr>
      <th style="width: 28%;">Platform</th>
      <th>Supported Version</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><span class="plat-cell">Android</span></td>
      <td>Android 5.0 (API 21) or higher</td>
    </tr>
    <tr>
      <td><span class="plat-cell">iOS</span></td>
      <td>iOS 12.2 or higher</td>
    </tr>
    <tr>
      <td><span class="plat-cell">macOS</span></td>
      <td>macOS 12 or higher, using Mac Catalyst</td>
    </tr>
    <tr>
      <td><span class="plat-cell">Windows</span></td>
      <td>Windows 11 and Windows 10 version 1809 or higher, using Windows UI Library (WinUI) 3</td>
    </tr>
  </tbody>
</table>


> **Additional Information**
>
> Learn more about the [Windows UI Library (WinUI) 3](https://learn.microsoft.com/en-us/windows/apps/winui/winui3/).
