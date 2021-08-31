using System;
using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp.Services
{
  public class JobsService
  {
    internal IEnumerable<Job> Get()
    {
      return FakeDB.jobs;
    }

    internal Job Get(string id)
    {
      Job found = FakeDB.jobs.Find(j => j.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Job Create(Job newJob)
    {
      FakeDB.jobs.Add(newJob);
      return newJob;
    }

    internal void Delete(string id)
    {
      int deleted = FakeDB.jobs.RemoveAll(j => j.Id == id);
      if (deleted == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}