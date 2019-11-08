using CountryWPF.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CountryWPF.ViewModel
{
    public class RestCountryApi
    {
        public const string BASE_URL = "https://restcountries.eu/rest/v2/all";

        public async static Task<List<Country>> GetCountries()
        {
            List<Country> countries = new List<Country>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(BASE_URL);
                var json = await response.Content.ReadAsStringAsync();
                countries = JsonConvert.DeserializeObject<List<Country>>(json);
            }
            return countries;
        }
    }
}
