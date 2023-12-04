using BlueBirdSnowboardingApp.models;
using BlueBirdSnowboardingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlueBirdSnowboardingApp.Pages
{
	public class CreateModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }

        private ISnowboardService _service;

        public CreateModel(ISnowboardService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                              nameof(Marca.MarcaId),
                                              nameof(Marca.Descricao));
        }

        

            [BindProperty]
        public Snowboard Snowboard { get; set; }

        public IActionResult OnPost()


        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            //inclusao

            _service.Inlcuir(Snowboard);

            return RedirectToPage("/Index");

        }
    }
}
