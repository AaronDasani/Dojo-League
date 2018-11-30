using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoLeague.Models
{
    public class NinjaInfo
    {
       public List<Ninja> ninjas{get;set;}
       public List<Dojo> dojos{get;set;}

       public Ninja ninja{get;set;}

    }
}