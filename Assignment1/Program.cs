using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                int i, j;
                //Outer loop for number of lines in the pattern.
                for (i = n; i >= 1; i--)
                {
                    // Inner loop for printing series 54321..
                    for (j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                //Write your code here .!!
                /*
                 * This method prints the following series till n terms: 1, 3, 6, 10, 15, 21……
                     * For example, if n2 = 6, output will be
                     * 1,3,6,10,15,21
                     * Returns : N/A
                     * Return type: void
                     * Hint: Series is 1,1+2=3,1+2+3=6,1+2+3+4=10,1+2+3+4+5=15, 1+2+3+4+5+6=21……
                 */
                int i, num = 0;
                List<int> result = new List<int>();


                for (i = 1; i <= n2; i++)
                {
                    num = i + num;
                    result.Add(num);
                }
                string resultfinal = string.Join(",", result.ToArray());
                Console.WriteLine(resultfinal);

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                int hour, min, sec, total;
                int Uhour, Smin, Fsec;
                string meridian, final;

                string temp = s.Substring(0, 2);
                hour = Int32.Parse(temp);
              
                string temp1 = s.Substring(3, 2);
                min = Int32.Parse(temp1);
                
                string temp2 = s.Substring(6, 2);
                sec = Int32.Parse(temp2);
                
                meridian = s.Substring(8, 2);
                
                if(meridian == "AM")
                {
                    total = ((hour * 3600) + (min * 60) + (sec));
                }
                else
                {
                   
                    total = ((hour * 3600) + (min * 60) + (sec) + (12 * 3600));
                    
                }

                Uhour = total / 2700;
                Smin = (total % 2700)/45;
                Fsec = (total % 2700) % 45;

                final = "";

                final = (Uhour < 10) ? (final+ "0"+ Uhour + ":") : (final + Uhour + ":");
                final = (Smin < 10) ? (final + "0" + Smin + ":") : (final + Smin + ":");
                final = (Fsec < 10) ? (final + "0" + Fsec) : (final + Fsec);


                return final;
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int count = 1;
                int i;

                for (i = 1; i <= n3; i++)
                {
                    //count = count + 1;
                    if(count > k)
                    {
                        Console.WriteLine();
                        count = 1;
                    }
                    count = count + 1;
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write(" USF");
                    }
                    else if(i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write(" SF");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write(" US");
                    }
                    else if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.Write(" UF");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write(" F");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write(" S");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write(" U");
                    }
                    else
                    {
                        Console.Write(" "+i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
