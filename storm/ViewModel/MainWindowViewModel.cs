using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using System.Reactive.Linq;
using storm.Model.DataBase;

namespace storm.ViewModel
{
    class MainWindowViewModel 
    {

        public MainWindowViewModel()
        {
            InputDataViewModel = new InputDataViewModel();
            OutputDataViewModel = new OutputDataViewModel();
        }

        public InputDataViewModel InputDataViewModel { get; }
        public OutputDataViewModel OutputDataViewModel { get; }



    }
}
