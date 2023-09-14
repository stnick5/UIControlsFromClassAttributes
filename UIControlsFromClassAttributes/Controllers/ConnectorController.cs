using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIControlsFromClassAttributes.Models;
using UIControlsFromClassAttributes.Models.ConnectorConfigurationObjects;
using UIControlsFromClassAttributes.Models.Enums;

namespace UIControlsFromClassAttributes.Controllers;

public class ConnectorController : Controller
{
    private readonly ILogger<ConnectorController> _logger;

    public ConnectorController(ILogger<ConnectorController> logger)
    {
        _logger = logger;
    }
    
    // GET
    public IActionResult Connector(ConnectorTypes connectorType)
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
    
        return PartialView("_ConnectorConfig", model);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}