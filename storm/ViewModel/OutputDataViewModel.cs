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
    class OutputDataViewModel :BindableBase
    {

        public OutputDataViewModel()
        {
            Card = "taka";

        }

        private string card;

        public string Card
        {
            get => card;
            set => SetProperty(ref card, value);
        }

        public DelegateCommand ClickButton { get; }


    }
}
