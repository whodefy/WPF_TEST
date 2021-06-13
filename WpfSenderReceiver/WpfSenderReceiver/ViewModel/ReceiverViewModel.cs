using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using WpfSenderReceiver.Message;

namespace WpfSenderReceiver.ViewModel
{
    public class ReceiverViewModel : ViewModelBase
    {
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

        public ReceiverViewModel()
        {
            Messenger.Default.Register<ViewModelMessage>(this, OnReceiveCommand);
        }

        private void OnReceiveCommand(ViewModelMessage obj)
        {
            StrName = obj.Name;
            StrRegNo = obj.RegNo;
            StrAge = obj.Age;
            StrBirthDay = obj.BirthDay;
        }
    }
}
