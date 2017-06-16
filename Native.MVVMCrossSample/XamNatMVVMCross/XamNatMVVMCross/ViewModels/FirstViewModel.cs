using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamNatMVVMCross.ViewModels
{
    public class FirstViewModel :MvxViewModel
    {
       

        private string _buttonText = "Kliknij mnie!";
        public string ButtonText
        {
            get { return _buttonText; }
            set { SetProperty(ref _buttonText, value); }
        }

        private int _count = 1;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                SetProperty(ref _count, value);
            }
        }

        private MvxCommand _incCommand;
        public ICommand IncCommand
        {
            get
            {
                _incCommand = _incCommand ?? new MvxCommand(() => {
                    ButtonText = string.Format("{0} clicks!", Count++);
                });

                return _incCommand;
            }
        }

    }
}
