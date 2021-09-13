using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadText
{
    class Program
    {
       public static int allWords = 0;
       public static int upperCase = 0;
       public static int lowerCase = 0;
        static void Main(string[] args)
        {
            countWorld();
            Console.ReadKey();

        }
        public static async Task countWorld()
        {
            await Task.Run(() =>
            {
                using (FileStream filen = new FileStream("C:/Users/betie/source/repos/ReadText/ReadText/TextFile1.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(filen))
                    {
                        string line = String.Empty;

                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] lineword = line.Split(new char[] {' '});
                            allWords += lineword.Length;
                            for (int i = 0; i < lineword.Length; i++)
                            {
                                char[] wordSplitter = lineword[i].ToCharArray();
                                if (char.IsUpper(wordSplitter[0]) == true)
                                {
                                    upperCase++;
                                }
                                else
                                {
                                    lowerCase++;
                                }
                            }
                        }
                    }
                }

            });
            Console.WriteLine("   ");
            Console.WriteLine("All text: " + allWords);
            Console.WriteLine("All upperword: " + upperCase);
            Console.WriteLine("All lowerCase: " + lowerCase);
            Console.ReadLine();
           
        }
    }
}
