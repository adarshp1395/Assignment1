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

            int n4 = 5;
            Stones(n4);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                Console.WriteLine("------- Question 1 -------");
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


        /*  This method prints the following series till n terms: 1, 3, 6, 10, 15, 21…. */
        private static void PrintSeries(int n2)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("------- Question 2 -------");
                int i, num = 0;
                List<int> result = new List<int>();

                //Loop for reading series up to n2 = 6 and result keeps on adding to num = 0;
                for (i = 1; i <= n2; i++)
                {
                    num = i + num;
                    result.Add(num);
                }
                // Converting list to array and joining each element in the array with ',' for display
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
                Console.WriteLine();
                Console.WriteLine("------- Question 3 -------");

                int hour, min, sec, total;
                int Uhour, Smin, Fsec;
                string meridian, final;


                // Reading the time from string by dividing into Hours, minutes, seconds and meridian
                string temp = s.Substring(0, 2);
                hour = Int32.Parse(temp);
              
                string temp1 = s.Substring(3, 2);
                min = Int32.Parse(temp1);
                
                string temp2 = s.Substring(6, 2);
                sec = Int32.Parse(temp2);
                
                meridian = s.Substring(8, 2);

                /*
                    * Condition to calculate total time (Earth time).
                    * Adds 3600 if time entered is in PM (12hrs * 3600sec)
                */
                if(meridian == "AM")
                {
                    total = ((hour * 3600) + (min * 60) + (sec));
                }
                else
                {
                   
                    total = ((hour * 3600) + (min * 60) + (sec) + (12 * 3600));
                    
                }

                //Divide the Earth time to get "USF" time
                Uhour = total / 2700;
                Smin = (total % 2700)/45;
                Fsec = (total % 2700) % 45;

                final = "";

                // Ternary condition to print 0 before the single digits. Joining hour, min and sec in a single string.
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
                Console.WriteLine();
                Console.WriteLine("------- Question 4 -------");
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

                    /* Check if the number is divisible by 3, 5 or 7, or two numbers or all of them */
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
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }


        /* This function will determine the pair of distinct indices (i,j) from a given
         * list of unique words such that the concatenation of two words
         * i.e. words[i]+words[j] is a palindrome. 
        */
        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("------- Question 5 -------");
                string first, second;
                int i, j;
                List<string> pairsList = new List<string>();

                /* Every word in the list will be compared with every other word in the list */
                for (i = 0; i < words.Length; i++)
                {
                    first = words[i];
                    for (j = 0; j <words.Length; j++)
                    {
                        second = words[j];

                        /* If the words are distinct(not the same index in array) and
                           when combined is a palindrome - add it to the final result list */
                        if (i != j && Program.isPalindrome(first, second))
                        {
                            pairsList.Add('[' + i.ToString() + ',' + j.ToString() + ']');
                        }
                    }
                }

                // converting list to array and the joining every element in the array with ',' for display.
                string resultfinal = '[' + string.Join(",", pairsList.ToArray()) + ']'; 
                Console.WriteLine(resultfinal);
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        /* This function will check if the given two strings when combined are palindrome or not */
        public static bool isPalindrome(string s1, string s2)
        {
            // Merge two string inputs into one
            string combinedString = s1 + s2;

            // Convert string to character array. 'abc' will become ['a','b','c']
            char[] ch = combinedString.ToCharArray();

            // Reverse the character array. ['a', 'b', 'c'] will become ['c', 'a', 'b']
            Array.Reverse(ch);

            // Creating new string variable from the reversed character array. ['c', 'a', 'b'] will become 'cab'
            string reverse = new String(ch);

            // Check if input and reversed string are same. If same, then its a palindrom.
            bool result = combinedString.Equals(reverse);
            return result;
        }


        /*
             * In order to win the game:
             * - Player 1 should begin
             * - It should be player 2's chance when the last 4 stones remain in the bag
             * - If we set aside the 4 stones from the beginning with fixed player assignment (2,1,1,1)
             * - We are left with (n-4) stones to distribute amongst the two players such that
             *          player 1 is the first and last one to pick the stone.
             *    
             * For example if we have player 1 and 2 and :
             * 1) if no of stones = 10, we will assign the stones in the following manner: [1,2,1,1,2,1 || 2,1,1,1]
             * Output : [1,1,2,1,1,1,3]
             *
             * 2) if no of stones = 5, we will assign the stones in the following manner: [1 || 2,1,1,1]
             * Output: [1,1,3]
        */
        public static void Stones(int n4)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("------- Question 6 -------");
                int temp, i;

                if (n4 == 4)
                {
                    // As there are 4 stones in the bag, game can never be won
                    Console.WriteLine("False");
                }
                else
                { 
                    // No of stones left after removing 4 stones
                    temp = n4 - 4;

                    // Player 1 will start the game
                    Boolean isPlayer1 = true;

                    // Assigning player to each stone in the bag
                    int[] stones = new int[temp];
                    int[] last4stones = new int[4] { 2, 1, 1, 1 };

                    int count = 0;
                    for (i = 0; i < temp; i++)
                    {
                        if (count == temp)
                        {
                            // all stones have been assigned a player
                            break;
                        }
                        // assigning stone from the start of array
                        stones[i] = isPlayer1 == true ? 1 : 2;
                        count++;
                        if (count != temp - 1)
                        {
                            // assigning stone from the end of array
                            stones[temp - i - 1] = isPlayer1 == true ? 1 : 2;
                            count++;
                        }
                        // changing player
                        isPlayer1 = !isPlayer1;
                    }

                    // Merging two arrays 
                    List<int> coinList = new List<int>();
                    coinList.AddRange(stones);
                    coinList.AddRange(last4stones);
                    int[] arr3 = coinList.ToArray();

                    // Final result list for the moves by each player
                    List<int> playerMoves = new List<int>();
                    count = 0;
                    for (i = 0; i < arr3.Length; i++)
                    {
                        count++;
                        if(i == arr3.Length - 1 || arr3[i] != arr3[i+1])
                        {
                            playerMoves.Add(count);
                            count = 0;
                        }
                    }

                    // Displaying final player moves. Player 1 starts.
                    Console.WriteLine("[" + string.Join(",", playerMoves.ToArray()) + "]");

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
