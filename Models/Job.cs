using System;
using System.ComponentModel.DataAnnotations;

namespace gregslistcsharp.Models
{
  public class Job
  {
    // FIXME Faking IDs For Now
    public string Id { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string JobTitle { get; set; }
    [Required]
    [MinLength(3)]
    public string Company { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Hours { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public float Pay { get; set; }

    [Required]
    public string ImgUrl { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(500)]
    public string Description { get; set; }

    public Job(string jobtitle, string company, int hours, float pay, string imgurl, string description)
    {
      JobTitle = jobtitle;
      Company = company;
      Hours = hours;
      Pay = pay;
      ImgUrl = imgurl;
      Description = description;

      // NOTE creating a unique Id for jobs
      Id = Guid.NewGuid().ToString();
    }


  }
}