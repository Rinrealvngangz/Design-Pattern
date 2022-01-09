
namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ICountryInfoProvider countryInfoProvider = new CountryInfoProvider(new GermanyDataService());
            Console.WriteLine(countryInfoProvider.GetCountry());
            Console.WriteLine(countryInfoProvider.GetLocalTime());

            countryInfoProvider = new CountryInfoProvider(new UnitedKingdomDataService());
            Console.WriteLine(countryInfoProvider.GetCountry());
            Console.WriteLine(countryInfoProvider.GetLocalTime());

            Console.ReadLine();
        }
    }
}