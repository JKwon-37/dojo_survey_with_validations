#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models;

public class Survey
{
    [Required]
    [MinLength(3)]
    public string Name {get;set;}

    [Required]
    public string Location {get;set;}

    [Required]
    public string Language {get;set;}

    [Required]
    [MinLength(20)]
    public string Comment {get;set;}
}