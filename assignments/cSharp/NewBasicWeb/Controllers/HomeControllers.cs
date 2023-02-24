using Microsoft.AspNetCore.Mvc;
namespace NewBasicWeb.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index() {
        return View();
}
[HttpGet][("/fakeRoute")]
public RedirectToActionResult Method() {
    return RedirectToAction("RealRoute");
}
}