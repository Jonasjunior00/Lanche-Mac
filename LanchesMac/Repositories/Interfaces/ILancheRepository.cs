using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> IsLanchePreferred { get; }

        Lanche GetLancheById(int lancheId);
    }
}
