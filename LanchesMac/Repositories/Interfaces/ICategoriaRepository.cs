using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //definindo contrato
        IEnumerable<Categoria> Categorias { get; }
    }
}
