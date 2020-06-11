using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class SubMenu
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
