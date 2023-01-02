namespace ProblemSolving;

public class GroupAnagramsProblem
{
    private const int TotalLowercaseCharacters = 26;
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if(!strs.Any()){
            return new List<IList<string>>();     
        }

        var groups = new Dictionary<string, IList<string>>();
        
        foreach (var str in strs)
        {
            var countArray = CountCharacters(str);
            var key = new string(countArray);
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(str);
        }
        
        return groups.Values.ToList();
    }

    private char[] CountCharacters(string str)
    {
        var countArray = new char[26];
        foreach (var character in str)
        {
            int asciiValue = character - 'a';
            if (asciiValue >= 0 && asciiValue < TotalLowercaseCharacters)
            {
                countArray[asciiValue]++;
            }
        }
        return countArray;
    }
}