using ListaCarrosAPI.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaCarrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {
        [HttpGet]
        [Route("listarcarros")]
        public IActionResult ListarPratos()
        {
            var dao = new CarroDAO();
            var carros= dao.ListarCarros();

            return Ok(carros);
        }
    }
}
