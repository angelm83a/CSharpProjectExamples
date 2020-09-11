//Taken from https://www.geeksforgeeks.org/reduce-the-string-by-removing-k-consecutive-identical-characters/
//By 29AjayKumar 

using System;
using System.Collections.Generic;

namespace ReduceStringRemovingConsecutiveCharacters
{
    public class GFG
    {
        /// <summary>
        /// Function that returns the reduced string after performing given operation
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static string remove_k_characters(string st1, int n, int k)
        {

            // Stack to store the character 
            Stack<Entity> st = new Stack<Entity>();

            int i = 0;
            for (i = 0; i < n; i++)
            {

                // the current character 
                char x = st1[i];

                // if the stack is not empty 
                // and the frequency of the element 
                // at the top of the stack is = k 
                // then pop k elements 
                if (st.Count > 0 && st.Peek().frequency == k)
                {

                    // stores the character at 
                    // the top of the stack 
                    char curr = st.Peek().character;

                    // while the character 
                    // at the top of the stack is curr 
                    // pop the character from the stack 
                    while (st.Count > 0 && st.Peek().character == curr)
                    {
                        st.Pop();
                    }
                }

                // if the stack is not empty 
                // and the top element of the 
                // stack is = x, 
                if (st.Count > 0 && st.Peek().character == x)
                {

                    // increase it's frequency and 
                    // push it to the stack 
                    Entity new_top = new Entity(x, st.Peek().frequency + 1);
                    st.Push(new_top);
                }

                // if the current element is 
                // not equal to the character 
                // at the top of the stack 
                else
                {
                    Entity new_top = new Entity(x, 1);
                    st.Push(new_top);
                }
            }

            // if the last pushed character 
            // has k frequency, then pop the 
            // top k characters. 
            if (st.Count > 0 && st.Peek().frequency == k)
            {

                // get the character 
                // at the top of the stack 
                char curr = st.Peek().character;

                // while the character 
                // at the top of the stack is 
                // curr, pop it from the stack 
                while (st.Count > 0 && st.Peek().character == curr)
                {
                    st.Pop();
                }
            }

            // Stores the string in 
            // reversed fashion from stack 
            string stack_string = "";
            while (st.Count > 0)
            {
                stack_string += st.Pop().character;
            }

            string reduced_string = "";

            // reverse the stack string 
            for (i = stack_string.Length - 1; i >= 0; i--)
            {
                reduced_string += stack_string[i];
            }

            return reduced_string;
        }

        /// <summary>
        /// Driver code  
        /// </summary>
        public static void Main(string[] args)
        {
            int k = 2;

            //string sample; notice the sequence: the result should be 'tv'
            //modify to received params through the console
            string st = "xqqxtv";
            Console.WriteLine("ORIGINAL: " + st);

            //result
            string ans = remove_k_characters(st, st.Length, k);
            Console.WriteLine("RESULT: " + ans);
        }
    }
}
