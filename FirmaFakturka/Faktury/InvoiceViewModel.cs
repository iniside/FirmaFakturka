using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirmaFakturka.Faktury
{
    public class ButtonCommand : ICommand
    {
        private InvoiceViewModel _obj;
        public ButtonCommand(InvoiceViewModel obj)
        {
            _obj = obj;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
    public class InvoiceViewModel : INotifyPropertyChanged
    {
        public ButtonCommand btnCommand;
        public InvoiceViewModel()
        {
            btnCommand = new ButtonCommand(this);
        }
        public ICommand btnClick
        {
            get
            {
                return btnCommand;
            }
        }
        private int _NIP;
        public int NIP
        {
            get { return _NIP; }
            set
            {
                _NIP = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_NIP"));
            }
        }
        public string Firma;
        public string Imie;
        public string Nazwisko;
        public string Adres;
        public string KodPocztowy;
        public string Miasto;
        public string Email;
        public int Telefon;
        public int TelefonKom;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
