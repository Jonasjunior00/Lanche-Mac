using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class HomeViewModel
    {
        //exibir os lanches preferidos
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }

    }
}
