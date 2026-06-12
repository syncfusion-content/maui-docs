---
layout: post
title: About .NET MAUI Barcode Generator control | Syncfusion
description: Learn here all about introduction of Syncfusion .NET MAUI Barcodes(SfBarcodeGenerator) control with key features and more.
platform: maui
control: SfBarcodeGenerator
documentation: ug
---

# .NET MAUI Barcode Generator Overview

The Syncfusion<sup>&reg;</sup> [.NET MAUI Barcode Generator](https://www.syncfusion.com/maui-controls/maui-barcodes) is a data visualization control used to generate and display data in a machine-readable format. It provides a perfect approach to encode text using supported symbology types.

![.NET MAUI Barcode Genrator Control](images/overview/maui-one-dimensional-barcode.png)

![.NET MAUI Barcode Genrator Control](images/overview/maui-two-dimensional-barcode.png)

## Business use cases

- Retail and billing systems that require barcode-based product identification and checkout processing.
- Inventory management applications that depend on efficient tracking of items using readable codes.
- Logistics and shipment systems that rely on barcode labeling for packages and deliveries.
- Ticketing and access control solutions that use QR codes or Data Matrix for validation and entry.

## Key features

* **One-dimensional barcodes** support multiple linear symbologies such as [`Code128`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code128.html), [`EAN8`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN8.html),[`EAN13`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.EAN13.html), [`UPC-A`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCA.html), [`UPC-E`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.UPCE.html), [`Code39`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39.html), [`Code39 Extended`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code39Extended.html), [`Code93`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Code93.html), and [`Codabar`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.Codabar.html).
* **Two-dimensional barcode** include [`QR code`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.QRCode.html) and [`Data Matrix`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.DataMatrix.html) formats for compact and high-density data encoding.
* **Barcode customization** allows modifying properties such as `BackgroundColor`, [`ForegroundColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_ForegroundColor), and [`Module`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SymbologyBase.html#Syncfusion_Maui_Barcode_SymbologyBase_Module) size for better readability.
* **Text customization** enables displaying encoded values with configurable position and styling.

## Globalization

The following table summarizes the globalization support available in this control.

<img src="../Images/partial-support.svg" alt="partial-support" width="16" align="center" /> Partial Support   
<img src="../Images/no-support.svg" alt="no-support" width="16" align="center"/> No Support  
<img src="../Images/not-applicable.svg" alt="not-applicable" width="16" align="center"/> Not Applicable

<table>
<tr>
<th align="center">Control</th>
<th align="center">Localization</th>
<th align="center">RTL</th>
<th align="center">Time zone</th>
<th align="center">Screen reader</th>
<th align="center">Keyboard navigation</th>
</tr>
<tr>
<td><a href="/maui/barcode-generator/overview">Barcode Generator<a></td>
<td align="center"><img src="../Images/no-support.svg" alt="not" width="16" /></td>
<td align="center"><img src="../Images/not-applicable.svg" alt="not-applicable" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/no-support.svg" alt="no-support" width="16" /></td>
<td align="center"><img src="../Images/partial-support.svg" alt="partial-support" width="16" /></td>
</tr> 
</table>

## Related controls

- [DataGrid](https://help.syncfusion.com/maui/datagrid/overview) for managing and displaying barcode-related data in tabular format.  
- [ListView](https://help.syncfusion.com/maui/listview/overview) for presenting barcode items in list-based layouts.
- [Treemap](https://help.syncfusion.com/maui/treemap/overview) for visualize barcode usage or distribution patterns in a hierarchical, comparative view.

## See Also

Explore further resources:

- [Getting Started](https://help.syncfusion.com/maui/barcode-generator/getting-started) shows how to begin using the Barcode Generator step by step.  
- [One Dimensional Symbology](https://help.syncfusion.com/maui/barcode-generator/one-dimensional-symbology) explains supported linear barcode types and usage.  
- [Customization](https://help.syncfusion.com/maui/barcode-generator/customization) shows how to customize barcode appearance and behavior.
- [UI Kit](https://www.syncfusion.com/demos/maui#maui-ui-control) provides interactive demos and ready-made UI examples.  

## Resources

<style>
.form-card {
   flex: 0 0 calc(33.33% - 14px);
   border: 1px solid #ddd;
   border-radius: 12px;
   overflow: hidden;
   background: white;
   box-sizing: border-box;
   transition: 0.3s ease;
}
.form-card:hover {
   text-decoration: none;
   transform: translateY(-4px);
   box-shadow: 0 8px 24px rgba(0,0,0,0.08);
}
.form-image {
   width: 100%;
   height: 100%;
   object-fit: cover;
   display: block;
   cursor: pointer;
   transition: 0.3s ease;
}
.form-image:hover {
   transform: scale(1.02);
}
.form-content {
   padding: 16px;
}
.form-title {
   margin-top: 0px;
   margin: 0 0 10px;
   font-size: 20px;
   font-weight: 600;
   color: #000000;
}
.form-link {
   color: #0078D4;
   text-decoration: none;
}
.form-description {
   margin-top: 14px;
   font-size: 13px;
   color: #000000;
   line-height: 1.6;
}
.source-icon {
   display: inline-flex;
   align-items: center;
   justify-content: center;
   width: 36px;
   height: 36px;
   border-radius: 50%;
   background: #f3f4f6;
   color: #0078D4;
   text-decoration: none;
   transition: 0.3s ease;
   margin-top: 12px;
}
.source-icon:hover {
   background: #0078D4;
   color: white;
}
/* Popup Modal */
#imageModal {
   display: none;
   position: fixed;
   z-index: 9999;
   left: 0;
   top: 0;
   width: 100%;
   height: 100%;
   background: rgba(0,0,0,0.85);
   justify-content: center;
   align-items: center;
   padding: 20px;
   box-sizing: border-box;
}
#popupImage {
   max-width: 90%;
   max-height: 90%;
   border-radius: 14px;
   box-shadow: 0 10px 30px rgba(0,0,0,0.4);
   animation: zoomIn 0.25s ease;
}
.close-popup {
   position: absolute;
   top: 20px;
   right: 30px;
   color: white;
   font-size: 42px;
   cursor: pointer;
   font-weight: bold;
}
@key frames zoomIn {
   from {
       transform: scale(0.9);
       opacity: 0;
   }
   to {
       transform: scale(1);
       opacity: 1;
   }
}
@media(max-width:900px) {
   .form-card {
       flex: 0 0 calc(50% - 10px);
   }
}
@media(max-width:600px) {
   .form-card {
       flex: 0 0 100%;
   }
}
</style>

<div style="display:flex; flex-wrap:wrap; gap:20px; margin-top:20px;">
<!-- Card 1 -->
<a href="https://www.syncfusion.com/maui-controls/maui-barcodes" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Feature Tour</h3>
    <div class="form-description">
      Walk through highlights and core capabilities.
    </div>
  </div>
</a>
<!-- Card 2 -->
<a href="https://github.com/syncfusion/maui-demos/tree/master/MAUI/Barcode" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Showcase Samples</h3>
    <div class="form-description">
      Explore sample scenarios for real apps.
    </div>
  </div>
</a>
<!-- Card 3 -->
<a href="https://www.syncfusion.com/tutorial-videos/maui/barcode" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Tutorial Videos</h3>
    <div class="form-description">
      Step‑by‑step guidance through video tutorials.
    </div>
  </div>
</a>
<!-- Card 4 -->
<a href="https://support.syncfusion.com/kb/cross-platforms/category/76" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore KB's</h3>
    <div class="form-description">
      Find quick solutions and step‑by‑step guidance.
    </div>
  </div>
</a>
<!-- Card 5 -->
<a href="https://www.syncfusion.com/blogs/category/net-maui" class="form-card" target="_blank">
  <div class="form-content">
    <h3 class="form-title">Explore Blogs</h3>
    <div class="form-description">
      Read insights, tutorials, and developer journeys.
    </div>
  </div>
</a>