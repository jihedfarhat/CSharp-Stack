#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models;

public class Student
{
  [Required]
  [MinLength(2)]
public string Name {get; set;}

[Required]
  public string Location {get; set;}

  [Required]
  public string FavoriteLanguage{get; set;}

  [Required]
  [MinLength(20)]
  public string Comment{get; set;}

}