using Prism.Commands;
using Prism.Dialogs;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommX.ViewModels
{
    public class MainViewModel:BindableBase
    {

        public DelegateCommand StartDialogCommand { get; set; }
        public MainViewModel(IDialogService dialogService)
        {
            StartDialogCommand = new DelegateCommand(StartDialog);
        }

        private void StartDialog()
        {

        }
    }
}
