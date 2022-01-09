namespace BridgePattern;

public class CountryInfoProvider : ICountryInfoProvider
{
    private readonly IDataService _dataService;
    public CountryInfoProvider(IDataService dataService)
    {
        _dataService = dataService;
    }
    public string GetCountry()
    {
       return _dataService.GetCountry();
    }

    public DateTime GetLocalTime()
    {
        return _dataService.GetLocalTime();
    }
}