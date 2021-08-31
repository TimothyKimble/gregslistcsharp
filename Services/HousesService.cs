using System;
using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp.Services
{
  public class HousesService
  {
    internal IEnumerable<House> Get()
    {
      return FakeDB.houses;
    }
    internal House Get(string id)
    {
      House found = FakeDB.houses.Find(h => h.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal House Create(House newHouse)
    {
      FakeDB.houses.Add(newHouse);
      return newHouse;
    }
    internal void Delete(string id)
    {
      int deleted = FakeDB.houses.RemoveAll(h => h.Id == id);
      if (deleted == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}