using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>View["buy_sell_cars.cshtml"];

      Get["/view_all_cars"] = _ => {
      List<Car> allCars = Car.GetAll();
      return View ["view_all_cars.cshtml", allCars];
      };

      Post["/add_your_car"] = _ => {
      Car newCar = new Car (Request.Form["new-car-model"], Request.Form["new-car-year"], Request.Form["new-car-mileage"]);
      newCar.AddToList();
      return View["car_added.cshtml", newCar];
      };
    }
  }
}
