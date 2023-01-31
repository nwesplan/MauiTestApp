using CommunityToolkit.Mvvm.Input;
using Maui.Models.Enums;

namespace Maui.Content.Components.Checkboxes;

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
        defaultValue: false
    );

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

    [RelayCommand]
	public void TapGesture()
	{
        
        IsChecked = !IsChecked;
    }
}