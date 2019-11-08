using CountryWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryWPF.ViewModel
{
    public class GameWindowVM
    {
        public Country Country { get; set; }
        public ObservableCollection<Country> CountryList { get; set; }

        public RestCountryApi RestCountryApi { get; set; }
        public GameWindowVM()
        {
            Country = new Country();
            //Country.Flag = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTU9ccPj2dVpG_7f_TdLEdKvArOszaSRxvUDckxq9JhZg5Qvx1mlg&s";
            Country.Flag = "https://www.countryflags.io/af/flat/64.png";
            CountryList = new ObservableCollection<Country>();

            RestCountryApi = new RestCountryApi();

            GetCountries();
        }

        private async void GetCountries()
        {
            var response = await RestCountryApi.GetCountries();

            CountryList.Clear();

            foreach (var country in response)
            {
                CountryList.Add(country);
            }
        }
    }
 }

