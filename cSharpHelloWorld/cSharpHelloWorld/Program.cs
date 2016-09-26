using System;

namespace cSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string strS = "This is an apple";
            char ninethChar = Convert.ToChar(strS.Substring(8, 1));
            //string s=strS.ToUpper();
            //Console.WriteLine(s);
            string[] wordS = strS.Split(' ');
            Console.WriteLine(getCharNum(strS, ninethChar));
            Console.WriteLine(wordS.Length);
            getReverse(wordS);
        }

        public static int getCharNum(string str,char c)
        {
            int count = 0;
            char[] strSingle = str.ToCharArray();
            for(int i = 0; i < strSingle.Length; i++)
            {
                if (strSingle[i] == c)
                    count++;
            }
            return count;
        }

        public static void getReverse(string[] word)
        {
            Console.WriteLine("hi,changed here~");
            Consolo.WriteLine("this is the second change!");
            /*string reverseString = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reverseString += word[i].ToString().ToUpper();
                reverseString += ' ';
            }
            Console.WriteLine(reverseString);*/
            System.Text.StringBuilder reverseString = new System.Text.StringBuilder();
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reverseString.Append(word[i].ToUpper());
                reverseString.Append(' ');
            }
            Console.WriteLine(reverseString);
        }//add submit test
    }
}