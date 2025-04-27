namespace Leetcode;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        long x = long.Parse(input);
        
        long size = 1;
        long tmp = x;
        long count = 0;
        while (tmp > 0)
        {
            tmp /= 10;
            size *= 10;
            count++;
        }
        size /= 10;
        
        long[] arrX = new long[count];
        
        for (int i = 0; i < arrX.Length; i++)
        {
            arrX[i] = x/size;
            x %= size;
            size /= 10;
        }

        bool flag = true;
        long j = count-1;
        for (int i = 0; i < count; i++)
        {
            if (arrX[i] != arrX[j])
            {
                flag = false;
                break;
            }
            j--;
        }

        Console.WriteLine(flag);
    }
}
