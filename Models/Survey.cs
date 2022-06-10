#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models;

public class Survey
{
    [Required(ErrorMessage = " is required!")]
    [MinLength(3, ErrorMessage = " must be at least 3 characters long!")]
    [Display(Name = "Student Name")]
    public string Name {get;set;}

    [Required(ErrorMessage = " is required!")]
    [Display(Name = "Dojo Location")]
    public string Location {get;set;}

    [Required(ErrorMessage = " is required!")]
    [Display(Name = "Favorite Language")]
    public string Language {get;set;}

    [MinLength(20, ErrorMessage = " must be at least 20 characters long!")]
    [Display(Name = "Comments(optional)")]
    public string Comment {get;set;}
}