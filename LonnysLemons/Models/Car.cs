using System.Collections.Generic;

namespace LonnysLemons.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public static int MaxPrice { get; set; }
    public static List<Car> CarsMatchingSearch = new List<Car> {};

    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      MaxPrice = -1;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static List<Car> WorthBuying(int maxPrice)
    {
      // MaxPrice = maxPrice - breaks Buyer click here
      foreach (Car car in _instances)
      {
        if (car.Price <= maxPrice)
        {
          CarsMatchingSearch.Add(car);
        }
      }
      return CarsMatchingSearch; // not being generated because of lines 30 and 20
    }

  }
}