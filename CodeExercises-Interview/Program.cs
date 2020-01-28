using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }


        public void FindUnique(string word)
        {
            //Solution 
            //Ask if ASCII or UNICODE string 
            //Go through aplhabet characters 

        }


        /*
         * Check Permutation: Given two strings, write a method to decide if one is a permutation of the
        other.
        Below are the permutations of string ABC.
        ABC ACB BAC BCA CBA CAB

        ABC CBA 

        */

        public static  void IsPermutation(string word1, string word2)
        {

            //Solution 
            //We should understand if the permutation comparison is case sensitive
            //ASK if whitespace is significant
            // Observe first that strings of different lengths cannot be permutations of each other

        }
    

        /*
         * URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
            has sufficient space at the end to hold the additional characters, and that you are given the "true"
            length of the string. 
         */

        public static String URLify(string word)
        {
            //find whitespace replace with %20
            var words = word.Split(' ').Where(x => !String.IsNullOrEmpty(x));
            words=words.TakeWhile(x => !String.IsNullOrEmpty(x)).ToList();
            return String.Join("%20", words);
        }

    }
}
