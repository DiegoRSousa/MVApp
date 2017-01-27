using MVApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVApp.ApiLivros
{
    public static class Api
    {
        public static async Task<List<Livro>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("http://mvalivros.azurewebsites.net/api/livros");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
                return livros;
            }
        }
    }
}
