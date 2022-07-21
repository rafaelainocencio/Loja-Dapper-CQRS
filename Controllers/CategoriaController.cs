using Loja.Domain;
using Loja.Repositories.CategoriaContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Controllers
{
    [Route("api/categorias")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository repository)
        {
            _categoriaRepository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Incluir([FromBody] Categoria categoria)
        {
            try
            {

                var result = _categoriaRepository.Insert(categoria);

                return Ok();
            }
            catch (Exception e)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                var data = _categoriaRepository.ListAll();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
