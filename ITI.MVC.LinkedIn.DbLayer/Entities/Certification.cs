using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.MVC.LinkedIn.DbLayer.Entities
{
    [Table("Certification")]
   public class Certification
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
