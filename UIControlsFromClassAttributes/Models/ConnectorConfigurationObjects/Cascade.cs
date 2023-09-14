using UIControlsFromClassAttributes.Models.Attributes;
using UIControlsFromClassAttributes.Models.Enums;

namespace UIControlsFromClassAttributes.Models.ConnectorConfigurationObjects;

public class Cascade : ConnectorConfigModel
{
    [UiControl(UiControl.TextBox)]
    public string Client { get; set; }
    [UiControl(UiControl.TextBox)]
    public string Secret { get; set; }
    [UiControl(UiControl.NumberPicker)]
    public int CustomerId { get; set; }
}