using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _model;
    public int year;
    public int miles;
    // public bool WorthBuying(int maxPrice, int maxMiles)
    // {
    //   return (Price < (maxPrice + 100) && Miles < maxMiles);
    // }
    private static List<Car> _listOfCars = new List<Car> {};

    public Car(string makeModel, int Year, int Miles)
    {
      _model = makeModel;
      year = Year;
      miles = Miles;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public int GetYear()
    {
      return year;
    }
    public void SetYear(int newYear)
    {
      year = newYear;
    }
    public int GetMiles()
    {
      return miles;
    }
    public void SetMiles(int newMiles)
    {
        miles = newMiles;
    }
    public void AddToList()
    {
      _listOfCars.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _listOfCars;
    }
    // foreach (Car automobile in Cars)
    // {
    //   if (automobile.WorthBuying(maxPrice, maxMiles))
    //   {
    //     CarsMatchingSearch.Add(automobile);
    //   }
    // }
    //
    // foreach (Car automobilein CarsMatchingSearch)
    // {
    //   // Console.WriteLine(automobile.MakeModel);
    // }

            // Console.WriteLine("Enter maximum price: ");
            // string stringMaxPrice = Console.ReadLine();
            // int maxPrice = int.Parse(stringMaxPrice);
  }
}
