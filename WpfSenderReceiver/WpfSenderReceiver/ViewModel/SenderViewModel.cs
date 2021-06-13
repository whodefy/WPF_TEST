using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using WpfSenderReceiver.Message;

namespace WpfSenderReceiver.ViewModel
{
    public class SenderViewModel : ViewModelBase
    {
        public RelayCommand OnClickCommand { get; set; }

        private string _strName;

        public string StrName
        {
            get { return _strName; }
            set { _strName = value; RaisePropertyChanged("StrName"); }
        }

        private string _strRegNo;

        public string StrRegNo
        {
            get => _strRegNo; 
            set 
            { 
                _strRegNo = value; 
                RaisePropertyChanged("StrRegNo"); 
            }
        }

        private string _strAge;
        public string StrAge
        {
            get => _strAge;
            set
            {
                _strAge = value;
                RaisePropertyChanged("StrAge");
            }
        }

        private string _strBirthDay;
        public string StrBirthDay
        {
            get => _strBirthDay;
            set
            {
                _strBirthDay = value;
                RaisePropertyChanged("StrBirthDay");
            }
        }


        public SenderViewModel()
        {
            OnClickCommand = new RelayCommand(OnClickCommandAction, null);
        }       

        private void OnClickCommandAction()
        {
            if (StrName == null || StrRegNo == null || StrAge == null || StrBirthDay == null) return;

            var viewModelMessage = new ViewModelMessage()
            {
                Name = StrName,
                RegNo = StrRegNo,
                Age = StrAge,
                BirthDay = StrBirthDay
            };

            Messenger.Default.Send(viewModelMessage);
        }
    }
}
