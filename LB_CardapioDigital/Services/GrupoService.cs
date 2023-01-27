using LB_CardapioDigital.Models;
using LB_CardapioDigital.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;

namespace LB_CardapioDigital.Services
{
    public class GrupoService: IGrupoService
    {
        private readonly HttpClient _httpClient;
        public GrupoService(HttpClient httpClient) { _httpClient = httpClient; }

        public async Task<IEnumerable<Grupo>?> GetGruposAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("token", Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
            return await _httpClient.GetFromJsonAsync<IEnumerable<Grupo>>("/v1/Grupo");
        }
    }
}
