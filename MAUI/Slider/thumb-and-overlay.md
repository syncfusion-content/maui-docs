---
layout: post
title: Thumb and Thumb Overlay in Flutter Slider widget | Syncfusion
description: Learn here all about the Thumb and Thumb Overlay features of Syncfusion Flutter Slider (SfSlider) widget and more.
platform: Flutter
control: SfSlider
documentation: ug
---

# Thumb and Thumb Overlay in Flutter Slider (SfSlider)

This section helps to learn about how to customize the thumb and thumb overlay in the slider.

* Thumb - It is one of the elements of slider which can be used to drag and change the selected value of the slider.
* Thumb overlay - It is rendered around the thumb while interacting with them.

## Thumb size

You can change the size of the thumb in the slider using the [`thumbRadius`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderThemeData/thumbRadius.html) property.

N> You must import the `theme.dart` library from the [`Core`](https://pub.dev/packages/syncfusion_flutter_core) package to use [`SfSliderTheme`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderTheme-class.html).

### Horizontal

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  thumbRadius: 13,
                ),
                child: SfSlider(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb size support](images/thumb-and-overlay/slider-thumb-size.png)

### Vertical

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  thumbRadius: 13,
                ),
                child: SfSlider.vertical(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb size support](images/thumb-and-overlay/vertical-slider-thumb-size.png)

## Thumb color

You can change the color of the thumb in the slider using the [`thumbColor`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderThemeData/thumbColor.html) property.

N> You must import the `theme.dart` library from the [`Core`](https://pub.dev/packages/syncfusion_flutter_core) package to use [`SfSliderTheme`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderTheme-class.html).

### Horizontal

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
           body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  thumbColor: Colors.red,
                ),
                child: SfSlider(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb color support](images/thumb-and-overlay/slider-thumb-color.png)

### Vertical

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
           body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  thumbColor: Colors.red,
                ),
                child: SfSlider.vertical(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb color support](images/thumb-and-overlay/vertical-slider-thumb-color.png)

## Thumb stroke width and stroke color

You can change the thumb stroke width using the [`thumbStrokeWidth`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderThemeData/thumbStrokeWidth.html) property and thumb stroke color using the [`thumbStrokeColor`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderThemeData/thumbStrokeColor.html) property.

N> You must import the `theme.dart` library from the [`Core`](https://pub.dev/packages/syncfusion_flutter_core) package to use [`SfSliderTheme`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderTheme-class.html).

### Horizontal

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                    thumbStrokeWidth: 3,
                    thumbStrokeColor: Colors.red
                ),
                child: SfSlider(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb stroke color support](images/thumb-and-overlay/slider-thumb-stroke-color.png)

### Vertical

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                    thumbStrokeWidth: 3,
                    thumbStrokeColor: Colors.red
                ),
                child: SfSlider.vertical(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb stroke color support](images/thumb-and-overlay/vertical-slider-thumb-stroke-color.png)


## Thumb icon

You can show the custom widgets like icon or text inside the thumb using the [`thumbIcon`](https://pub.dev/documentation/syncfusion_flutter_sliders/latest/sliders/SfSlider/thumbIcon.html) property.

### Horizontal

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: SfSliderTheme(
            data: SfSliderThemeData(
              thumbColor: Colors.white,
              thumbRadius: 15,
              thumbStrokeWidth: 2,
              thumbStrokeColor: Colors.blue
            ),
            child: Center(
              child: SfSlider(
                min: 2.0,
                max: 10.0,
                interval: 1,
                thumbIcon: Icon(
                    Icons.arrow_forward_ios,
                    color: Colors.blue,
                    size: 20.0),
                showLabels: true,
                value: _value,
                onChanged: (dynamic newValue) {
                  setState(() {
                    _value = newValue;
                  });
                },
              ),
            ),
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb icon support](images/thumb-and-overlay/slider-thumb-icon.png)

### Vertical

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: SfSliderTheme(
            data: SfSliderThemeData(
              thumbColor: Colors.white,
              thumbRadius: 15,
              thumbStrokeWidth: 2,
              thumbStrokeColor: Colors.blue
            ),
            child: Center(
              child: SfSlider.vertical(
                min: 2.0,
                max: 10.0,
                interval: 1,
                thumbIcon: Icon(
                    Icons.keyboard_arrow_up_outlined,
                    color: Colors.blue,
                    size: 20.0),
                showLabels: true,
                value: _value,
                onChanged: (dynamic newValue) {
                  setState(() {
                    _value = newValue;
                  });
                },
              ),
            ),
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb icon support](images/thumb-and-overlay/vertical-slider-thumb-icon.png)


## Thumb overlay size

You can change the size of the thumb overlay in the slider using the [`overlayRadius`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderThemeData/overlayRadius.html) property.

N> You must import the `theme.dart` library from the [`Core`](https://pub.dev/packages/syncfusion_flutter_core) package to use [`SfSliderTheme`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderTheme-class.html).

### Horizontal

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  overlayRadius: 30,
                ),
                child:  SfSlider(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb overlay size support](images/thumb-and-overlay/slider-overlay-size.png)

### Vertical

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  overlayRadius: 30,
                ),
                child:  SfSlider.vertical(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb overlay size support](images/thumb-and-overlay/vertical-slider-overlay-size.png)


## Thumb overlay color

You can change the color of the thumb overlay in the slider using the [`overlayColor`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderThemeData/overlayColor.html) property.

N> You must import the `theme.dart` library from the [`Core`](https://pub.dev/packages/syncfusion_flutter_core) package to use [`SfSliderTheme`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfSliderTheme-class.html).

### Horizontal

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  overlayColor: Colors.red[50],
                ),
                child:  SfSlider(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb overlay size support](images/thumb-and-overlay/slider-overlay-color.png)

### Vertical

{% tabs %}
{% highlight Dart %}

double _value = 6.0;

@override
Widget build(BuildContext context) {
  return MaterialApp(
      home: Scaffold(
          body: Center(
              child: SfSliderTheme(
                data: SfSliderThemeData(
                  overlayColor: Colors.red[50],
                ),
                child:  SfSlider.vertical(
                  min: 2.0,
                  max: 10.0,
                  interval: 1,
                  showTicks: true,
                  showLabels: true,
                  value: _value,
                  onChanged: (dynamic newValue){
                    setState(() {
                      _value = newValue;
                    });
                  },
                ),
              )
          )
      )
  );
}

{% endhighlight %}
{% endtabs %}

![Thumb overlay size support](images/thumb-and-overlay/vertical-slider-overlay-color.png)
