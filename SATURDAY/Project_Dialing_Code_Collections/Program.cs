using DialingCodesApp;

class Program
{
    public static void Main()
    {
        Dictionary<int, string> emptyDict = DialingCodes.GetEmptyDictionary();

        Dictionary<int, string> existingDict = DialingCodes.GetExistingDictionary();
        DialingCodes.PrintDictionary(existingDict);

        Dictionary<int, string> singleEntryDict = DialingCodes.AddCountryToEmptyDictionary(81, "Japan");

        DialingCodes.AddCountryToExistingDictionary(existingDict, 44, "United Kingdom");

        string country = DialingCodes.GetCountryNameFromDictionary(existingDict, 91);

        bool exists = DialingCodes.CheckCodeExists(existingDict, 55);

        DialingCodes.UpdateDictionary(existingDict, 55, "Federative Republic of Brazil");

        DialingCodes.RemoveCountryFromDictionary(existingDict, 1);

        string longestName = DialingCodes.FindLongestCountryName(existingDict);
        DialingCodes.PrintDictionary(existingDict);
    }
}