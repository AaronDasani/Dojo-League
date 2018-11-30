using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoLeague.Models
{
    public class Ninja
    {
        [Key]
        public int ninja_id{get;set;}

        [Required]
        [MinLength(3,ErrorMessage="Name should be atleast 3 characters")]
        [MaxLength(30,ErrorMessage="Name should be less than 30 characters")]
        [Display(Name="Ninja Name")]
        public string name{get;set;}


        [Required]
        [Display(Name="Ninjaing Level")]
        //need regex here
        [RegularExpression(@"^([1-9]|10)$",ErrorMessage="Invalid Level Number")]
        public int level{get;set;}

        [MinLength(5,ErrorMessage="description should be atleast 5 chracters")]
        [MaxLength(200,ErrorMessage="description should be less than 200 characters")]
        [Display(Name="Optional Description")]
        public string description{get;set;}


        [Display(Name="Assigned Dojo?")]
        public int? dojo_id{get;set;}


        public Dojo dojo{get;set;}
    }
}