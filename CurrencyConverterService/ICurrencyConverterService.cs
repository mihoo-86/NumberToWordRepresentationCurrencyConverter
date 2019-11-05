using System.ServiceModel;

namespace CurrencyConverterService
{
    [ServiceContract]
    public interface ICurrencyConverterService
    {
        [OperationContract]
        string ConvertToWord(decimal usdCurrency);
    }
}
