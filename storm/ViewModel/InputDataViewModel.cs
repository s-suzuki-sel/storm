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
    class InputDataViewModel :BindableBase
    {
        public InputDataViewModel()
        {
            Name = "田中";




        }


        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }







    }
}
