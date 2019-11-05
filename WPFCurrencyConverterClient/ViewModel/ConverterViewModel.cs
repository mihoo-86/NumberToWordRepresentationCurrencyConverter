using CurrencyConverterCommon;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPFCurrencyConverterClient.CurrencyConverterServiceReference;
using WPFCurrencyConverterClient.Model;

namespace WPFCurrencyConverterClient.ViewModel
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        public ICommand ConvertCommand { get; private set; }

        private readonly ConverterModel converterModel;

        public decimal USDCurrency
        {
            get { return converterModel.USDCurrency; }
            set
            {
                if (converterModel.USDCurrency != value)
                {
                    converterModel.USDCurrency = value;
                    OnPropertyChange();
                    SetIsValid();
                }
            }
        }

        public string WordRepresentation
        {
            get { return converterModel.WordRepresentation; }
            set
            {
                if (converterModel.WordRepresentation != value)
                {
                    converterModel.WordRepresentation = value;
                    OnPropertyChange();
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return converterModel.IsValid;
            }
            set
            {
                if (converterModel.IsValid != value)
                {
                    converterModel.IsValid = value;
                    OnPropertyChange();
                }
            }
        }

        public ConverterViewModel()
        {
            converterModel = new ConverterModel
            {
                USDCurrency = 0,
                IsValid = true
            };

            ConvertCommand = new RelayCommand(() => ExecuteConvertCommand());
        }

        /// <summary>
        /// Sets the value of the IsValid property.
        /// </summary>
        private void SetIsValid()
        {
            IsValid = CurrencyValidator.IsValid(USDCurrency);
        }


        private void ExecuteConvertCommand()
        {
            if (!IsValid)
            {
                WordRepresentation = "Currency is out of range!";

                return;
            }

            using (CurrencyConverterServiceClient client = new CurrencyConverterServiceClient())
            {
                WordRepresentation = client.ConvertToWord(USDCurrency);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
