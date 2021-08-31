using System;
using System.ComponentModel.DataAnnotations;

namespace gregslistcsharp.Models
{
  public class Car
  {
    //   FIXME Faking IDS for Now
    public string Id { get; set; }

    // NOTE DataAnnotations apply to value below them
    [Required]
    [MinLength(3)]
    [MaxLength(15)]
    public string Make { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(15)]
    public string Model { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(250)]
    public string Description { get; set; }
    [Required]
    [Range(1950, int.MaxValue)]
    public int Year { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Price { get; set; }

    [Required]
    public string ImgUrl { get; set; }

    public Car(string make, string model, string description, int year, int price, string imgurl)
    {
      Make = make;
      Model = model;
      Description = description;
      Year = year;
      Price = price;
      ImgUrl = imgurl;
      // NOTE creates a unique id
      Id = Guid.NewGuid().ToString();
    }


  }
}