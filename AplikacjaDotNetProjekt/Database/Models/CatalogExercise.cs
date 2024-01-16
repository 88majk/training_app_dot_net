using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class CatalogExercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string MuscleParts { get; set; }

        public override string ToString()
        {
            return $"{Name} : {MuscleParts}";
        }
    }
}
