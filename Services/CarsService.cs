using System;
using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> Get()
    {
      return FakeDB.Cars;
    }
    internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }
    internal void Delete(string id)
    {
      int deleted = FakeDB.Cars.RemoveAll(c => c.Id == id);
      if (deleted == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}