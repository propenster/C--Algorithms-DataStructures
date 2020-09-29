using System;

namespace Algos
{
    public class AnagramChecker {
        void CheckAnagram(string word1, string word2)
        {
            char[] charArray1 = word1.ToLower().ToCharArray();
            char[] char2Array2 = word2.ToLower().ToCharArray();

            //Sort them...
            Array.Sort(charArray1);
            Array.Sort(char2Array2);

            //Create New String from the sorted chararray
            string NewWord1 = new string(charArray1);
            string NewWord2 = new string(char2Array2);

            //Now are Newword1 and NewWord2 equal....
            //String.Equals(root, root2, StringComparison.OrdinalIgnoreCase); 
            if(String.Equals(NewWord1, NewWord2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(@"{0} and {1} are Anagrams", word1, word2);
            }
            Console.WriteLine(@"{0} and {1} are NOT Anagrams", word1, word2);

        }


    public static void Main(string[] args)
    {

        /**
        Now Test.
        */
        CheckAnagram("Lawal", "lawal");
        Console.ReadKey();
        
    }


}
    
    
}