using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantFinder.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}