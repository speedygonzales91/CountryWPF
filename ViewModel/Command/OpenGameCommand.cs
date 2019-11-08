using CountryWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CountryWPF.ViewModel.Command
{
    public class OpenGameCommand : ICommand
    {
        public GameWindow Game { get; set; }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Game = new GameWindow();
            Game.ShowDialog();
        }
    }
}
