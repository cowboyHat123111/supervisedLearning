namespace Break_camelCase
{
    internal class Program
    {
        public static string BreakCamelCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    str = str.Insert(i++, " ");
                }
            }
            return str;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("helloWorld"));
        }
    }
}