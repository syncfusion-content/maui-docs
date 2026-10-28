# MAUI Controls

Use `sf new maui` to create an empty MAUI project or a project containing
Syncfusion controls. Control selection is separate from package operations.

## Create a project

Omit `--control` or specify `empty` to create an empty project:

```text
sf new maui -n MyApp
sf new maui -n MyApp --control empty
```

Select one or more controls with `--control`:

```text
sf new maui -n MyApp --control datagrid
sf new maui -n MyApp --control datagrid combobox
sf new maui -n MyApp --control cartesian-chart circular-chart
```

## Available control families

The existing top ten control families are:

- DataGrid
- ListView
- Scheduler
- Charts
- AssistView
- Rich Text Editor
- ComboBox
- Maps
- Image Editor
- TreeView

Charts is one control family with these six choices:

- Cartesian Chart (`cartesian-chart`)
- Circular Chart (`circular-chart`)
- Polar Chart (`polar-chart`)
- Pyramid Chart (`pyramid-chart`)
- Funnel Chart (`funnel-chart`)
- Sunburst Chart (`sunburst-chart`)

## Packages and controls

Package commands manage NuGet package references. For example,
`sf add maui inputs` adds the Inputs package; it does not generate control
files. A control ID such as `combobox` selects generated content only through
project creation with `--control`.

## Compatibility

For project creation, the hidden `--template` option remains accepted as a
compatibility alias for `--control`. The legacy control ID `charts` continues
to resolve to `cartesian-chart`; new selections use the concrete chart IDs.
