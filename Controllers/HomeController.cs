using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index() 
    {
        return View();
    }

    [HttpPost("method")]
    public IActionResult Method(Survey survey)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Result", survey);
        } else 
        {
            return View("Index");
        }
    }

    [HttpGet("result")]
    public ViewResult Result (Survey survey)
    {
        
        return View("Result", survey);
    }
}

