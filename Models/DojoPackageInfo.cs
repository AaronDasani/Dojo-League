using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoLeague.Models
{
    public class DojoInfo
    {
       public List<Dojo> dojos{get;set;}
       public Dojo dojo{get;set;}

       public List<Ninja> RogueNinjas{get;set;}

    }
}