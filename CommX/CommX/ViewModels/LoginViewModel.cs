using CommX.Views;
using Prism.Dialogs;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommX.ViewModels
{
    public class LoginViewModel :IDialogAware
    {
        public string Title { get; set; } = "测试";

        public DialogCloseListener RequestClose { get; set; }

        public bool CanCloseDialog()
        {
           return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }
        public LoginViewModel(IContainerProvider provider)
        {
           
        }
    }
}
