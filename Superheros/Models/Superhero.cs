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
        public string SuperheroName { get; set; }
        public string AlterEgoName { get; set; }
        public string PrimarySuperAbility { get; set; }
        public string SecondarySuperAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}
