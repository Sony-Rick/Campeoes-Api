using Microsoft.AspNetCore.Mvc;
using Campeao.Infra.Data;


namespace Campeao.App_Api.Controllers;

public class CampeaoControllers : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}