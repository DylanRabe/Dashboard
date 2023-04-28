using Dashboard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dashboard.Models;

namespace Dashboard.Pages.Candidats
{
    public class NewModel : PageModel
    {

        private readonly CandidatDbContext _context;
        public NewModel(CandidatDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> OnPost()
        {
            //validation pour savoir si le model est valid(coté server)
            if (!ModelState.IsValid) return Page();

            Candidat.Vide = DateTime.Now;
            await _context.Candidats.AddAsync(Candidat);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }

        //processus qui prend les valeurs de Http et les maps à nos methodes
        [BindProperty]

        //enregistrera les nouveau candidat
        public Candidat Candidat { get; set; }
    }
}
