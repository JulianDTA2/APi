using APi.Models;
using APi.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicletasController : ControllerBase
    {
        private BicicletasRepo _repo;

        public BicletasController()
        {
            _repo = new BicicletasRepo();
        }

        [HttpGet]
        public IEnumerable<Bicicleta> ObtenerListadoBicicletas()
        {
            var bicicletas = _repo.ObtenerListadoBicicletas();
            return bicicletas;
        }
        [Route("{Id}")]
        [HttpGet]
        public IActionResult ObtenerInformacionBicicletas(int Id)
        {
            try
            {
                var bicicleta = _repo.ObtenerInformacionBicicletas(Id);
                return Ok(bicicleta);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
