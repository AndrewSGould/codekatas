using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SharpKatas.Data;
using SharpKatas.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SharpKatas.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarContext _context;

        public IndexModel(CarContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        [BindProperty(SupportsGet = true)]
        public string UserSearch { get; set; }

        public SelectList Class { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CarClass { get; set; }

        public async Task OnGetAsync()
        {
            var cars = _context.Car.AsQueryable();
            
            if (!string.IsNullOrEmpty(UserSearch))
            {
                cars = cars.Where(car => car.Class.Contains(UserSearch));
            }

            Car = await cars.ToListAsync();
        }
    }
}
