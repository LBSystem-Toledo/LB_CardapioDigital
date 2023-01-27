using LB_CardapioDigital.Models;
using LB_CardapioDigital.Services.Interfaces;

namespace LB_CardapioDigital.Services
{
    public class SaborService: ISaborService
    {
        private readonly HttpClient _httpClient;
        public SaborService(HttpClient httpClient) { _httpClient= httpClient; }

        public async Task<IEnumerable<Sabor>?> GetSaboresAsync(string token, string cdProduto)
        {
            return null;
        }
    }
}
