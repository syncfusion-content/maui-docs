---
layout: post
title: Localization in Flutter Date Range Picker widget | Syncfusion
description: Learn here all about Localization feature of Syncfusion Flutter Date Range Picker (SfDateRangePicker) widget and more. 
platform: flutter
control: SfDateRangePicker
documentation: ug
---

# Localization in Flutter Date Range Picker (SfDateRangePicker)

By default, the calendar widget supports US English localizations. You can change other languages by specifying the `MaterialApp` properties and adding the `flutter_localizations` package to your application.

To use `flutter_localizations`, add the package as a dependency to `pubspec.yaml` file.

{% highlight dart %}

dependencies:
flutter_localizations:
  sdk: flutter

{% endhighlight %}

Next, import the `flutter_localizations` library and specify `localizationsDelegates` and `supportedLocale` for `MaterialApp`.

{% tabs %}
{% highlight dart hl_lines="6 7 8 9 10 11 12 13 14 15" %}

import 'package:flutter_localizations/flutter_localizations.dart';

@override
Widget build(BuildContext context) {
return MaterialApp(
        localizationsDelegates: [
            GlobalMaterialLocalizations.delegate,
            GlobalWidgetsLocalizations.delegate,
      ],
     supportedLocales: [
          const Locale('zh'),
          const Locale('ar'),
          const Locale('ja'),
      ],
      locale: const Locale('zh'),
      title: 'DateRangePicker Localization',
      home: Scaffold(
          appBar: AppBar(
          title: Text('Calendar'),
          ),
          body: SfDateRangePicker(
          view: DateRangePickerView.month,
           ),
       ),
   );
}

{% endhighlight %}
{% endtabs %}

![Localization Date Range Picker](images/localization/localization.png)
