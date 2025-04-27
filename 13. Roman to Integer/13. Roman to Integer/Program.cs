namespace _13._Roman_to_Integer;

class Program
{
    static public int RomanToInt(string s)
    {
        int res=0;
        Dictionary<char, int> numDic = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                res += numDic[s[i]];
            }
            else if (numDic[s[i]] > numDic[s[i - 1]])
            {
                res=res+(numDic[s[i]]-numDic[s[i - 1]]);
                i--;
            }
            else
            {
                res+=numDic[s[i]];
            }
        }
        return res;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }
}