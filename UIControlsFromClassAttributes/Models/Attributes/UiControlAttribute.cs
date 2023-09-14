using UIControlsFromClassAttributes.Models.Enums;

namespace UIControlsFromClassAttributes.Models.Attributes;

public class UiControlAttribute : Attribute
{
    public UiControl UiControl { get; set; }

    public UiControlAttribute(UiControl control)
    {
        UiControl = control;
    }
}