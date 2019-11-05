using System.Windows;
using WPFCurrencyConverterClient.ViewModel;

namespace WPFCurrencyConverterClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ConverterViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            
            _viewModel = new ConverterViewModel();

            DataContext = _viewModel;
        }
    }
}
