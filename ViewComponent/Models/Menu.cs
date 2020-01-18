using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Menu
    {
        public Menu()
        {
            SubMenus = new HashSet<SubMenu>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public ICollection<SubMenu> SubMenus{ get; set; }
        
    }
}
