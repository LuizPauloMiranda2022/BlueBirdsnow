using BlueBirdSnowboardingApp.models;
using BlueBirdSnowboardingApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace BlueBirdSnowboardingApp.Pages;

public class IndexModel : PageModel

{
    private ISnowboardService _service;

    public IndexModel(ISnowboardService service)
    {
        _service = service;
    }
    public IList<Snowboard> ListaSnowboards { get; private set; }
    

    public void OnGet()
    {




       // var service = new SnowboardService();

        ListaSnowboards = _service.ObterTodos();

    }
    
    
}

