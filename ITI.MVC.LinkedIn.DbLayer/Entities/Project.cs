using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.MVC.LinkedIn.DbLayer.Entities
{
    [Table("Project")]
   public class Project
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int UserId { get; set; }
        [ForeignKey("")]
        public int? WorkExperienceId { get; set; }
        public DataType StartDate { get; set; }
        public DataType EndDate { get; set; }
        public string Creator { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
