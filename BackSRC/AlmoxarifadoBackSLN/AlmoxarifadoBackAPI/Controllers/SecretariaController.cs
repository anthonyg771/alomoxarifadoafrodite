using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SecretariaController : ControllerBase
    {
        private readonly ISecretariaRepositorio _db;
        public SecretariaController(ISecretariaRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listaprodutos")]
        public IActionResult listaProdutos()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Secretaria")]
        public IActionResult listaSecretaria(SecretariaDTO categoria)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==categoria.Codigo));
        }

        [HttpPost("/criarproduto")]
        public IActionResult criarSecretaria(SecretariaCadastroDTO Secretaria)
        {

            var novaSecretaria = new Secretaria()
            {               
                

            };
            //_categorias.Add(novaProduto);
            _db.Add(novaSecretaria);
            return Ok("Cadastro com Sucesso");
        }



    }
}
