using System.Globalization;
using Newtonsoft.Json;

namespace Module3HM2;

public abstract class JsonConfig : JsonReader
{
    public void EnglishFile()
    {
        const string engfilepath = @"/Users/moonlyri/Documents/GitHub/Module3HM2/Module3HM2/EnglishLanguage.json";
        var json = File.ReadAllText(engfilepath);
        var engalphabet = JsonConvert.DeserializeObject<EngFileModel<string>>(json);

    }
    public void UkrainianFile()
    {
        const string ukrfilepath = @"/Users/moonlyri/Documents/GitHub/Module3HM2/Module3HM2/UkrainianLanguage.json";
        var json = File.ReadAllText(ukrfilepath);
        var ukralphabet = JsonConvert.DeserializeObject<UkrFileModel<string>>(json);

    }
    
}
public class EngFileModel<T>
{
    [JsonProperty("EnglishAlphabet")] public T[] englishalphabet;
}

public class UkrFileModel<T>
{
    [JsonProperty("UkrainianAlphabet")] public T[] ukrainianalphabet;
}