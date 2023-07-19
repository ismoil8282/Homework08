namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the gaps : ");
            string s = (Console.ReadLine());

           RepeatWord(s);
            
Main(args);
        }
        
         public static void RepeatWord(string s) 
        {
            int countChar = 1;
            int counter = 0;
            char c=' ';
            for(int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    countChar ++;
                    c = s[i];
                }else
                {
                    countChar=1; 
                }
            } 
            Console.WriteLine(c + " was repeated " + countChar + " times");
        
        }
    }
}