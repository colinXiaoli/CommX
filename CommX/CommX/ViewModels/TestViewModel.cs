using Prism.Dialogs;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommX.ViewModels
{
    public class TestViewModel : IDialogAware
    {
        public string Title { get; set; } = "测试";

        DialogCloseListener IDialogAware.RequestClose { get;}

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
    }
}
