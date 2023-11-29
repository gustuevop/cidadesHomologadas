using System;
using System.Net.Http;
using System.Threading.Tasks;
using verificadorDeCidadesHomologadas.Uteis;

namespace verificadorDeCidadesHomologadas.APIConsumer
{
    public static class PlugNotasConsumer
    {
        public static string BuscaCidadesHomologadas()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://api.plugnotas.com.br/nfse/cidades")
            };
            client.DefaultRequestHeaders.Add("x-api-key", ConfigManager.BuscarToken());

            Task<HttpResponseMessage> response = client.GetAsync(client.BaseAddress);
            
            return response.Result.Content.ReadAsStringAsync().Result;
        }
    }
}
