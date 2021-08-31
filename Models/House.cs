using System;
using System.ComponentModel.DataAnnotations;


namespace gregslistcsharp.Models
{
  public class House
  {
    // FIXME Faking IDS for Now
    public string Id { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Year { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Bedrooms { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Bathrooms { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Price { get; set; }
    [Required]
    public string ImgUrl { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(250)]
    public string Description { get; set; }

    public House(int year, int bedrooms, int bathrooms, int price, string imgurl, string description)
    {
      Year = year;
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Price = price;
      ImgUrl = imgurl;
      Description = description;

      // NOTE creating a unique Id for houses
      Id = Guid.NewGuid().ToString();
    }
  }
}