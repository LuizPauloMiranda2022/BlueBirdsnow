using BlueBirdSnowboardingApp.models;
using BlueBirdSnowboardingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlueBirdSnowboardingApp.Pages
{
	public class CreateModel : PageModel
    {
        private ISnowboardService _service;

        public CreateModel(ISnowboardService service)
        {
            _service = service;
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
