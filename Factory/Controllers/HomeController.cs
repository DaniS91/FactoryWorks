using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db; 
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Engineer[] engineerArray = _db.Engineers.ToArray();
      Machine[] machineArray = _db.Machines.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("engineers",engineerArray);
      model.Add("machines", machineArray);
      return View(model);
    }
  }
}