using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

/// <summary>
/// Attached behavior for handling nullable checkbox states in TreeView nodes.
/// </summary>
public static class NullableTreeCheckbox
{
    /// <summary>
    /// Identifies the <see cref="IsEnabled"/> dependency property.
    /// </summary>
    public static readonly DependencyProperty IsEnabledProperty =
        DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(NullableTreeCheckbox), new PropertyMetadata(false, OnIsEnabledChanged));

    /// <summary>
    /// Identifies the <see cref="IsChecked"/> dependency property.
    /// </summary>
    public static readonly DependencyProperty IsCheckedProperty =
        DependencyProperty.RegisterAttached("IsChecked", typeof(object),
        typeof(NullableTreeCheckbox), new PropertyMetadata(default(object), IsCheckedChanged));

    /// <summary>
    /// Identifies the <see cref="IsInternalChecked"/> dependency property.
    /// </summary>
    private static readonly DependencyProperty IsInternalCheckedProperty =
        DependencyProperty.RegisterAttached("IsInternalChecked", typeof(object),
        typeof(NullableTreeCheckbox), new PropertyMetadata(null, OnIsInternalCheckedChanged));

    /// <summary>
    /// Returns a boolean value whether the NullableTreeCheckbox is Enabled or not.
    /// </summary>
    /// <param name="obj">The Source of the event.</param>
    /// <returns>Returns the boolean value.</returns>
    public static bool GetIsEnabled(DependencyObject obj)
    {
        if (obj == null)
            return false;

        return (bool)obj.GetValue(IsEnabledProperty);
    }

    /// <summary>
    /// Sets the NullableTreeCheckbox IsEnabled property based on the new value.
    /// </summary>
    /// <param name="obj">The Source of the event.</param>
    /// <param name="value">Represents the new value.</param>
    public static void SetIsEnabled(DependencyObject obj, bool value)
    {
        if (obj == null)
            return;
        obj.SetValue(IsEnabledProperty, value);
    }

    /// <summary>
    /// Returns a boolean value whether the NullableTreeCheckbox is checked or not.
    /// </summary>
    /// <param name="obj">The Source of the event.</param>
    /// <returns>Returns the boolean value.</returns>
    public static object GetIsChecked(DependencyObject obj)
    {
        if (obj == null)
            return false;

        return (bool?)obj.GetValue(IsCheckedProperty);
    }

    /// <summary>
    /// Sets the NullableTreeCheckbox IsChecked property based on the new value.
    /// </summary>
    /// <param name="obj">The Source of the event.</param>
    /// <param name="value">Represents the new value.</param>
    public static void SetIsChecked(DependencyObject obj, object value)
    {
        if (obj == null)
            return;

        obj.SetValue(IsCheckedProperty, value);
    }

    /// <summary>
    /// Occurs when <see cref="IsInternalChecked"/> property is changed.
    /// </summary>
    /// <param name="d">The Source of the event.</param>
    /// <param name="e">Contains all information about the event.</param>
    private static void OnIsInternalCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        SetIsChecked(d, (bool?)e.NewValue);
    }

    /// <summary>
    /// Occurs when <see cref="IsEnabled"/> property is changed.
    /// </summary>
    /// <param name="d">The Source of the event.</param>
    /// <param name="e">Contains all information about the event.</param>
    private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var checkbox = d as Microsoft.UI.Xaml.Controls.CheckBox;
        if ((bool)e.NewValue)
        {
            var binding = new Binding
            {
                Path = new PropertyPath("IsChecked"),
                Mode = BindingMode.TwoWay,
                Source = checkbox,
            };
            checkbox.SetBinding(NullableTreeCheckbox.IsInternalCheckedProperty, binding);
        }
    }

    /// <summary>
    /// Occurs when <see cref="IsChecked"/> property is changed.
    /// </summary>
    /// <param name="d">The Source of the event.</param>
    /// <param name="e">Contains all information about the event.</param>
    private static void IsCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var checkbox = d as Microsoft.UI.Xaml.Controls.CheckBox;
        bool? newValue = null;
        if (e.NewValue is bool?)
            newValue = (bool?)e.NewValue;
        else if (e.NewValue != null)
            newValue = (bool)e.NewValue;
        if (!checkbox.IsChecked.Equals(newValue))
            checkbox.IsChecked = newValue;
    }
}
