using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LonnysLemons.Models;

namespace LonnysLemons.Controllers
{
    public class CarsController : Controller
    {
      [HttpGet("/cars")]
      public ActionResult Index()
      {
        List<Car> allCars = Car.GetAll();
        return View(allCars);
      }

      [HttpGet("/cars/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/cars")]
      public ActionResult Create(string makeModel, int price, int miles)
      {
        Car myCar = new Car(makeModel, price, miles);
        return RedirectToAction("Index");
      }

      [HttpGet("/buy")] // default full list
      public ActionResult Buyer()
      {
        List<Car> allCars = Car.GetAll();
        return View(allCars);
      }

      [HttpPost("/buy")] // CarsMatchingSearh list based on maxPrice
      public ActionResult Create(int maxPrice)
      {
        Car.WorthBuying(maxPrice);
        return RedirectToAction("Index");
      }
    }
}