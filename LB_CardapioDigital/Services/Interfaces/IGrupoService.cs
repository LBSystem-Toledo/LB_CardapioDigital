using LB_CardapioDigital.Models;

namespace LB_CardapioDigital.Services.Interfaces
{
    public interface IGrupoService
    {
        Task<IEnumerable<Grupo>?> GetGruposAsync(string token);
    }
}
