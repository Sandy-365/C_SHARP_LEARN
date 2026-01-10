namespace DialingCodesApp
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "United States of America";
            dict[55] = "Brazil";
            dict[91] = "India";
            return dict;
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[countryCode] = countryName;
            return dict;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode,
            string countryName)
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode)
                ? existingDictionary[countryCode]
                : "";
        }

        public static bool CheckCodeExists(
            Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode,
            string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary.Remove(countryCode);
            }
            return existingDictionary;
        }

        public static string FindLongestCountryName(
            Dictionary<int, string> existingDictionary)
        {
            string longest = "";
            foreach (string name in existingDictionary.Values)
            {
                if (name.Length > longest.Length)
                {
                    longest = name;
                }
            }
            return longest;
        }

        public static void PrintDictionary(Dictionary<int, string> dictionary)
        {
            foreach (var kv in dictionary)
            {
                Console.WriteLine($"Code: {kv.Key}, Country: {kv.Value}");
            }
        }
    }
}
