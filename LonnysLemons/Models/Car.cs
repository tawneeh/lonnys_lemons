using System.Collections.Generic;

namespace LonnysLemons.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    // public int MaxPrice { get; set; }
    public static List<Car> CarsMatchingSearch = new List<Car>(0);

    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static List<Car> WorthBuying(int maxPrice)
    {
      // MaxPrice = maxPrice;
      foreach (Car car in Cars)
      {
        if (Price <= maxPrice)
        {
          CarsMatchingSearch.Add(this);
        }
        return CarsMatchingSearch;
      }
    }

  }
}