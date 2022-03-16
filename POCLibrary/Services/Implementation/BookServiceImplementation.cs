using POCLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace POCLibrary.Services.Implementation
{
    public class BookServiceImplementation : IBookService
    {
        private string _urlApi = "https://livrariacompasso.herokuapp.com/search?term=";
        private readonly HttpClient _client = new HttpClient();
        public async Task<IEnumerable<Books>> FindBooksByTermAsync(string term)
        {
            List<Books> booklist = new List<Books>();

            var urlChamada = _urlApi + term;
            var response = _client.GetStreamAsync(urlChamada);

            var responseDeserialized = await JsonSerializer.DeserializeAsync<Books>(await response);
            booklist.Add(responseDeserialized);
            return booklist;
        }
    }
}
