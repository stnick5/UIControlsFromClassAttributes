using UIControlsFromClassAttributes.Models.Attributes;
using UIControlsFromClassAttributes.Models.Enums;

namespace UIControlsFromClassAttributes.Models.ConnectorConfigurationObjects;

public class TR515 : ConnectorConfigModel
{
    [UiControl(UiControl.TextBox)]
    public string Name { get; set; }
    [UiControl(UiControl.TextBox)]
    public string IpAddress { get; set; }
    [UiControl(UiControl.NumberPicker)]
    public int Port { get; set; }
}