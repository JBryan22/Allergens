using Microsoft.AspNetCore.Mvc;
using Allergens.Models;
using System.Collections.Generic;
using System;

namespace Allergens.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/allergen/results")]
    public ActionResult Results()
    {
      Allergy newAllergy = new Allergy (int.Parse(Request.Form["allergen-score"]));
      List<string> allergies = new List<string>();
      allergies = newAllergy.GetAllergies();
      return View(allergies);
    }
  }
}
