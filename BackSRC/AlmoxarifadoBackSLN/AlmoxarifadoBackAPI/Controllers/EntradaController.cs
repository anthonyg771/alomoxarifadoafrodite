using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaRepositorio _db;
        public EntradaController(IEntradaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaEntrada")]
        public IActionResult listaEntrada()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Entrada")]
        public IActionResult listaEntrada(EntradaDTO entrada)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == entrada.Codigo));
        }

        [HttpPost("/criarEntrada")]
    
        public IActionResult criarEntradaa(EntradaCadastroDTO entrada)
        {

            var novaEntrada = new Entrada()
            {               
                Descricao = entrada.Descricao,
                DATAENTRADA = entrada.DATAENTRADA,
                QUANTIDADEATUAL = entrada.QUANTIDADEATUAL


            };
            //_categorias.Add(novaCategoria);
            _db.Add(novaEntrada);
            return Ok("Cadastro com Sucesso");
        }



    }
}
