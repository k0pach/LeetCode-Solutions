namespace _14._Longest_Common_Prefix;

class Program
{
    static public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }
        
        if (strs.Length == 1)
        {
            return strs[0];
        }
        
        string prefix = "";
        char tmp;
        for (int i = 0; i < strs[0].Length; i++)
        {
            tmp = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
            {
                if (i > strs[j].Length-1  || tmp != strs[j][i])
                {
                    return prefix;
                }
            }
            prefix += tmp;
        }
        
        return prefix;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(LongestCommonPrefix(["ab", "a"]));
    }
}