using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class fornecedorController : ControllerBase
    {
        private readonly IfornecedorRepositorio _db;
        public fornecedorController(IfornecedorRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listafornecedors")]
        public IActionResult listafornecedors()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/fornecedor")]
        public IActionResult listafornecedors(FornecedorDTO categoria)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==categoria.Codigo));
        }

        [HttpPost("/criarfornecedor")]
        public IActionResult criarfornecedor(FornecedorCadastroDTO fornecedor)
        {

            var novafornecedor = new Fornecedor()
            {               
                nome = fornecedor.nome,
                Telefone = fornecedor.Telefone,
                Estado = fornecedor.Estado,
                Cidade = fornecedor.Cidade,
                CNPJ = fornecedor.CNPJ
            };
            //_categorias.Add(novaProduto);
            _db.Add(novafornecedor);
            return Ok("Cadastro com Sucesso");
        }



    }
}
