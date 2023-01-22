using System;

namespace Method_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Cumle daxil edin...");
            string sentences1 = Console.ReadLine();
            string result1 = FindFirstWord(sentences1);
            Console.WriteLine("Cumlenin ilk sozu..." + result1);
            #endregion

            #region Task 2
            Console.WriteLine("Cumle daxil edin...");
            string sentences2 = Console.ReadLine();
            int result2 = CountOfWords(sentences2);
            Console.WriteLine("Cumledeki sozlerin sayi..." + result2);
            #endregion

            #region Task 3
            Console.WriteLine("Arrayin uzunlugunu daxil edin...");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result3 = MakeNewArray(numbers);
            Console.WriteLine("Arrayin musbet elementleri...");
            for (int j = 0; j < result3.Length; j++)
            {
                Console.WriteLine(result3[j]);
            }
            #endregion

            #region Task 4
            Console.WriteLine("Arrayin uzunlugunu daxil edin...");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[size];
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Element {i}: ");
                words[i] = Console.ReadLine();
            }
            int result4 = IsDigit(words);
            Console.WriteLine("Netice..." + result4);
            #endregion

            #region Task 5
            Console.WriteLine("Soz daxil edin...");
            string str = Console.ReadLine();
            int result5 = IndexOfChar(str);
            Console.WriteLine("Netice..." + result5);
            #endregion

            #region Task 6
            Console.WriteLine("Soz daxil edin...");
            string sentences3 = Console.ReadLine();
            string result6 = SubstringWord(sentences3);
            Console.WriteLine("Netice..." + result6);
            #endregion
        }

        //Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
        static string FindFirstWord (string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    break;
                }
                else
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }

        //Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)
        static int CountOfWords (string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            if (str[0]==' ')
            {
                return count;
            }
            else
            {
                return count + 1;
            }
            
        }

        //Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.Misalçün verilmiş arraydə {4, -3, 10, -24}
        //dəyərləridirsə methoddan geriyə {4, 10} dəyərli array qayıdır.
        static int[] MakeNewArray (int[] numbers)
        {
            int length = 0;
            
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        length++;
                    }
                }

            int[] newArray = new int[length];
            int j = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        newArray[j] = numbers[i];
                        j++;
                    }
                }

            return newArray;
        }

        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int IsDigit(string[] str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j]>'0' && str[i][j]<'9')
                    {
                        count++;
                        i++;
                    }
                }
            }
            return count;
        }

        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.
        static int IndexOfChar (string str)
        {
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    index++;
                }
            }
            return index+1;

        }

        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string SubstringWord (string str)
        {
            bool foundSymbol = false;
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    foundSymbol= true;
                    newStr += str[i];
                }
                if (foundSymbol ==true && str[i] == ' ')
                {
                    newStr += str[i];
                }
                
            }
            return newStr;
        }

        

	
    }
}
