using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface ISecretariaRepositorio
    {
        void Add(Secretaria Secretaria);

        List<Secretaria> GetAll();

        
    }
}
