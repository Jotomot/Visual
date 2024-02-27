using System.Text;

namespace StringEx;

class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CamelToKebabCase("camelCaseTypingToKebabCase"));

        Console.WriteLine(KebabToCamelCase("kebab-to-camel-case"));
    }

    public static string CamelToKebabCase(string s)
    {

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                sb.Append('-');
                sb.Append(s[i]);
                
            }
            else
            {
                sb.Append(s[i]);
            }        
        }
        return sb.ToString().ToLower();
    }

    public static string KebabToCamelCase(string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '-')
            {
                sb.Append(char.ToUpper(s[i + 1]));
                i++;

            }
            else
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
    

}