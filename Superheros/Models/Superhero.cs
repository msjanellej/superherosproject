using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superheros.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "Superhero Name")]
        public string SuperheroName { get; set; }
        [Display (Name ="Alter Ego Name")]
        public string AlterEgoName { get; set; }
        [Display (Name = "Primary Super Ability" )]
        public string PrimarySuperAbility { get; set; }
        [Display (Name = "Secondary Super Ability")]
        public string SecondarySuperAbility { get; set; }
        [Display (Name = "Catch Phrase")]
        public string Catchphrase { get; set; }
    }
}
