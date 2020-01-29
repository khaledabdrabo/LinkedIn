using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.MVC.LinkedIn.DbLayer.Entities
{
   public class Publication
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        public int Title { get; set; }
        public string Publisher { get; set; }
        public DataType Date { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        [Required]
        
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
               
    }
}
