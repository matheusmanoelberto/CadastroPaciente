using Microsoft.AspNetCore.Mvc;

namespace CadastroPaciente.Controllers;

[Route("Provider")]
public class ProviderController : DefaultController
{
    [HttpPost]
    public IActionResult Create()
    {
        return Ok();

    }
}