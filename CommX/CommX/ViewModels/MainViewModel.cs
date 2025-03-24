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
        public MainViewModel(IDialogService dialogService)
        {
            dialogService.ShowDialog("TestView");
        }
    }
}
