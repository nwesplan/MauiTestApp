using CommunityToolkit.Mvvm.Input;
using Maui.Models.Enums;
using System.Windows.Input;

namespace MauiTestApp.Components.Checkboxes;

public partial class CheckboxLabel : Grid
{
    public CheckboxLabel()
    {
        InitializeComponent();
    }

    public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
        typeof(string),
        typeof(CheckboxLabel)
    );

    public string Text
    {
        get => GetValue(TextProperty)?.ToString();
        set => SetValue(TextProperty, value);
    }

    public static BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked),
        typeof(bool),
        typeof(CheckboxLabel),
        defaultValue: false,
        propertyChanged: IsCheckedPropertyChanged
    );

    private static void IsCheckedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is CheckboxLabel control && newValue is bool value)
        {
            if (control.CheckedChanged != null)
            {
                control.CheckedChanged.Execute(value);
            }
        }
    }

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    public static BindableProperty CheckboxSizeProperty = BindableProperty.Create(nameof(CheckboxSize),
        typeof(CheckboxSize),
        typeof(CheckboxLabel)
    );

    public CheckboxSize CheckboxSize
    {
        get => (CheckboxSize)GetValue(CheckboxSizeProperty);
        set => SetValue(CheckboxSizeProperty, value);
    }

    public static BindableProperty CheckedChangedProperty = BindableProperty.Create(nameof(CheckedChanged),
        typeof(ICommand),
        typeof(CheckboxLabel)
    );

    public ICommand CheckedChanged
    {
        get => (ICommand)GetValue(CheckedChangedProperty);
        set => SetValue(CheckedChangedProperty, value);
    }

    [RelayCommand]
    public void TapGesture()
    {

        IsChecked = !IsChecked;
    }
}