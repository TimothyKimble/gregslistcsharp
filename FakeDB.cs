using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp
{
  static public class FakeDB
  {
    // NOTE Creating a static public list for Cars
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Ford", "F-150", "Big Boi", 2005, 20000, "https://www.motortrend.com/uploads/sites/10/2015/11/2005-ford-f-150-stx-2wd-truck-angular-front.png") };

    // NOTE Creating a static public list for Houses.
    static public List<House> houses { get; set; } = new List<House>() { new House(2015, 3, 3, 250000, "https://images.unsplash.com/photo-1518780664697-55e3ad937233?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=701&q=80", "Small house but plenty of space.") };

    // NOTE Creating a static public list for Jobs
    static public List<Job> jobs { get; set; } = new List<Job>() { new Job("Software Engineer", "Bungie", 40, 80000, "https://images.unsplash.com/photo-1571171637578-41bc2dd41cd2?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80", "Fun times always and making Steam work.") };
  }
}