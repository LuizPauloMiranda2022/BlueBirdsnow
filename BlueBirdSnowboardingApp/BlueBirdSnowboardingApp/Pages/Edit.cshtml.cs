
using BlueBirdSnowboardingApp.models;
using BlueBirdSnowboardingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace BlueBirdSnowboardingApp.Pages
{
	public class EditModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private ISnowboardService _service;
        private IToastNotification _toastNotification;
        private readonly IToastNotification toastNotification;

        public EditModel(ISnowboardService service, IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
        }

       
       


        [BindProperty]
        public Snowboard Snowboard { get; set; }
       

        public IActionResult OnGet(int id)
        {
            //var service = new SnowboardService();
            Snowboard = _service.Obter(id);
            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                             nameof(Marca.MarcaId),
                                             nameof(Marca.Descricao));

            if (Snowboard == null)
            {
                return NotFound();
            }

            return Page();     

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var snowboardExistente = _service.Obter(Snowboard.Snowboardid);
            if (snowboardExistente == null)
            {
                // Tratar caso em que o snowboard não é encontrado
                // Pode redirecionar para uma página de erro ou mostrar uma mensagem
                _toastNotification.AddErrorToastMessage("Snowboard não encontrado.");
                return Page();
            }

            _service.Alterar(Snowboard);

            _toastNotification.AddSuccessToastMessage("Snowboard alterado com sucesso!");
            return RedirectToPage("/Index");
        }

        public IActionResult OnPosExclusao()

        {
            //Exclusao
            _service.Excluir(Snowboard.Snowboardid);
            _toastNotification.AddSuccessToastMessage("Snowboard Excluido com Suceso");
            return RedirectToPage("/Index");
        }
    }
}
