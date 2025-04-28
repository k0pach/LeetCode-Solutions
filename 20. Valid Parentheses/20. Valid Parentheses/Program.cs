namespace _20._Valid_Parentheses;

class Program
{
    static bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }
        
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
            }
            else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                else if ((s[i] == ')' && stack.Peek() != '(') || (s[i] == ']' && stack.Peek() != '[') || (s[i] == '}' && stack.Peek() != '{'))
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }

        return false;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(IsValid("([)]"));
    }
}