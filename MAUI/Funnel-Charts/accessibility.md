---
layout: post
platform: maui
title: Accessibility in .NET MAUI Funnel Charts | Syncfusion®
description: Learn about accessibility features in Syncfusion® .NET MAUI Funnel Charts for inclusive design and keyboard navigation.
control: SfFunnelChart
documentation: ug
---

# Accessibility in .NET MAUI Funnel Charts

Enhance .NET MAUI Funnel Charts' accessibility with user-friendly design, ensuring inclusive features for seamless navigation and usability for all users. Funnel chart sections are fully accessible with individual focus and screen reader announcements.

## Chart Elements and Announcements

<table>
<tr>
<th>Element</th>
<th>Format</th>
<th>Example</th>
</tr>
<tr>
<td>Chart Title</td>
<td>Text</td>
<td>"Sales Conversion Funnel"</td>
</tr>
<tr>
<td>Funnel Section</td>
<td>Label + Value</td>
<td>"Conversion 1500 users"</td>
</tr>
<tr>
<td>Section with Percentage</td>
<td>Label + Value + Percentage</td>
<td>"Leads 5000 users 100%"</td>
</tr>
<tr>
<td>Series Legend Item</td>
<td>Series Name</td>
<td>"Sales Pipeline"</td>
</tr>
</table>

## Keyboard Navigation

### Windows (Narrator)

<table>
<tr>
<th>Key Combination</th>
<th>Description</th>
</tr>
<tr>
<td>CapsLock + Right Arrow</td>
<td>Move to the next chart element</td>
</tr>
<tr>
<td>CapsLock + Left Arrow</td>
<td>Move to the previous chart element</td>
</tr>
<tr>
<td>CapsLock + Up Arrow</td>
<td>Announce the element text</td>
</tr>
<tr>
<td>Tab</td>
<td>Move focus to next interactive elements like buttons, checkbox</td>
</tr>
</table>

### macOS (VoiceOver)

<table>
<tr>
<th>Key Combination</th>
<th>Description</th>
</tr>
<tr>
<td>VO + Right Arrow</td>
<td>Move to the next element (VO is Control + Option)</td>
</tr>
<tr>
<td>VO + Left Arrow</td>
<td>Move to the previous element</td>
</tr>
<tr>
<td>VO + Up Arrow</td>
<td>Announce the element text</td>
</tr>
</table>

## Gesture Navigation

### Android (TalkBack)

<table>
<tr>
<th>Gesture</th>
<th>Description</th>
</tr>
<tr>
<td>Fling Right</td>
<td>Move to the next chart element</td>
</tr>
<tr>
<td>Fling Left</td>
<td>Move to the previous chart element</td>
</tr>
<tr>
<td>Single Tap</td>
<td>Move focus to elements</td>
</tr>
<tr>
<td>Double Tap</td>
<td>Activate focused element (enable tooltip/selection)</td>
</tr>
</table>

### iOS (VoiceOver)

<table>
<tr>
<th>Gesture</th>
<th>Description</th>
</tr>
<tr>
<td>Swipe Right (One finger)</td>
<td>Move to the next element</td>
</tr>
<tr>
<td>Swipe Left (One finger)</td>
<td>Move to the previous element</td>
</tr>
<tr>
<td>Single Tap</td>
<td>Move focus to elements</td>
</tr>
<tr>
<td>Double Tap</td>
<td>Activate focused element (enable tooltip/selection)</td>
</tr>
</table>

## Enable Accessibility
To enable accessibility support on your device:
| Platform | Steps |
|----------|-------|
| **Android** | Settings → Accessibility → TalkBack → Toggle "On" |
| **Windows** | Settings → Accessibility → Turn on Narrator (or press Windows key + Enter) |
| **iOS** | Settings → Accessibility → VoiceOver → Toggle "On" |
| **macOS** | System Preferences → Accessibility → VoiceOver → Check "Enable VoiceOver" |

## Related Documentation

- [Syncfusion MAUI Cartesian Charts Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)