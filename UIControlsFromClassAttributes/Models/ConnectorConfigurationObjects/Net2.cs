using UIControlsFromClassAttributes.Models.Attributes;
using UIControlsFromClassAttributes.Models.Enums;

namespace UIControlsFromClassAttributes.Models.ConnectorConfigurationObjects;

public class Net2 : ConnectorConfigModel
{
    [UiControl(UiControl.TextBox)]
    public string ServerName { get; set; }
    [UiControl(UiControl.TextBox)]
    public string DatabaseName { get; set; }
    [UiControl(UiControl.NumberPicker)]
    public int Port { get; set; }
    [UiControl(UiControl.TextBox)]
    public string Username { get; set; }
    [UiControl(UiControl.TextBox)]
    public string Password { get; set; }
}