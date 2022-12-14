using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.EF;
using ShopSolution.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolution.Application.Utilities.Slides
{
    public class SlideService:ISlideService
    {
        private readonly EShopDbContext _context;

        public SlideService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();
            return slides;
        }
    }
}
