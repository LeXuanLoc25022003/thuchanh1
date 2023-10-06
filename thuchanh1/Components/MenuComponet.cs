using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thuchanh1.Models;

namespace thuchanh1.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponet : ViewComponent
    {
        private DataContext _context;
        public MenuViewComponet(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from m in _context.Menus
                              where (m.IsActive == true) && (m.Position == 1)
                              select m).ToList();
        return await Task.FromResult((IViewComponentResult)View("Default",listofMenu));
        }
} }
