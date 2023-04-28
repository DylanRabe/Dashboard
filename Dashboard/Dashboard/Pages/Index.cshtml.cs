using Dashboard.Data;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Dashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CandidatDbContext _context;

        public IndexModel(CandidatDbContext context)
        {
             _context = context;
        }

        //methode handler
        public async void OnGet()
        {
            Candidats = await _context.Candidats.Where(i => i.Name == null)
                .OrderByDescending(i => i.Id)
                .ToListAsync();
        }

        public IEnumerable<Candidat> Candidats { get; set; } = Enumerable.Empty<Candidat>();


    }
}