using Microsoft.AspNetCore.Mvc;
using UIControlsFromClassAttributes.Models.ConnectorConfigurationObjects;
using UIControlsFromClassAttributes.Models.Enums;

namespace UIControlsFromClassAttributes.Views.Components;

public class ConnectorConfigComponent : ViewComponent
{
    public IViewComponentResult Invoke(ConnectorTypes connectorType)
    {
        ConnectorConfigModel model = new Cascade();
        switch (connectorType)
        {
            case ConnectorTypes.Net2:
                model = new Net2();
                break;
            case ConnectorTypes.Cascade:
                model = new Cascade();
                break;
            case ConnectorTypes.TR515:
                model = new TR515();
                break;
            default:
                model = new Net2();
                break;
        }

        return View(model);
    }
}