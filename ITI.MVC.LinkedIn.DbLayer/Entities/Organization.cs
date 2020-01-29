using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.MVC.LinkedIn.DbLayer.Entities
{
    public enum OrganizationType
    {
        organization,school
    }
    [Table("Organization")]
    public class Organization
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Logo { get; set; }
        [Required]
        public OrganizationType Type { get; set; }

    }
}
