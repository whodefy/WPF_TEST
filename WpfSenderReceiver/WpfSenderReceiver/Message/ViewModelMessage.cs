using GalaSoft.MvvmLight.Messaging;

namespace WpfSenderReceiver.Message
{
    public class ViewModelMessage : MessageBase
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Age { get; set; }
        public string BirthDay { get; set; }
    }
}
