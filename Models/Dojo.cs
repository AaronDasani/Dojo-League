using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoLeague.Models
{
    public class Dojo
    {
        [Key]
        public int dojo_id{get;set;}

        [Required]
        [MinLength(5,ErrorMessage="Name should be atleast 5 characters")]
        [MaxLength(50,ErrorMessage="Name should be less than 50 characters")]
        [Display(Name="Dojo Name")]
        public string name{get;set;}


        [Required]
        [MaxLength(30,ErrorMessage="location name exceeded the character limit:30")]
        [Display(Name="Dojo Location")]
        public string location{get;set;}

        [MinLength(10,ErrorMessage="description should be atleast 10 chracters")]
        [MaxLength(300,ErrorMessage="description should be less than 300 characters")]
        [Display(Name="Additional Dojo Information")]
        public string description{get;set;}

        public List<Ninja> ninjas{get;set;}

        public Dojo(){
            ninjas=new List<Ninja>();
        }

    }
}