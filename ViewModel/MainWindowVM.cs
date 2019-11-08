using CountryWPF.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryWPF.ViewModel
{
    public class MainWindowVM
    {
        public OpenGameCommand OpenGameCommand { get; set; }

        public MainWindowVM()
        {
            OpenGameCommand = new OpenGameCommand();
        }
    }
}
