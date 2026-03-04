# Enums and Supporting Types

This page lists the public enums and supporting types used by `SfTabView`.

## Enums

### `TabBarPlacement`

- `Bottom` – below content
- `Top` – above content
- `Left` – left of content
- `Right` – right of content

### `TabWidthMode`

- `Default` – tab headers share available header space
- `SizeToContent` – tab header width fits each header’s content

### `TabIndicatorPlacement`

- `Bottom` – indicator below header content
- `Fill` – indicator fills header region
- `Top` – indicator above header content
- `Left` – indicator left of header content
- `Right` – indicator right of header content

### `TabImagePosition`

- `Bottom`, `Left`, `Right`, `Top` – where the `SfTabItem.ImageSource` is placed relative to text

### `TabBarDisplayMode`

- `Image` – show image only
- `Text` – show text only
- `Default` – show both

### `IndicatorWidthMode`

- `Fit` – indicator width fits header content width
- `Stretch` – indicator width stretches to header width

## Supporting types

### `TabItemCollection`

`TabItemCollection` derives from `ObservableCollection<SfTabItem>` and is used by `SfTabView.Items`.

### EventArgs

#### `TabSelectionChangedEventArgs`

- `OldIndex` (`double`, internal set)
- `NewIndex` (`double`, internal set)
- `Handled` (`bool`, public get/set)

#### `SelectionChangingEventArgs`

- Inherits `CancelEventArgs`
- `Index` (`int`, internal set)
- Cancel by setting `CancelEventArgs.Cancel = true`

#### `TabItemTappedEventArgs`

- `TabItem` (`SfTabItem?`, internal set)
- `Cancel` (`bool`, public get/set)
