using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Components
{
    public class NavbarViewComponent:ViewComponent
    {
        private readonly DemoDbContext _context;

        public NavbarViewComponent(DemoDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _context.Menus.Include("SubMenus").ToListAsync();

            return View(model);
        }
    }
}
