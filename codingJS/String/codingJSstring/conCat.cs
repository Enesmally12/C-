namespace cSharp_withMrMike.String;

// Given two strings, append them together (known as "concatenation") and return the result. 
// However, if the concatenation creates a double-char, then omit one 
// of the chars, so "abc" and "cat" yields "abcat".

// Examples

// conCat('abc', 'cat') → abcat
// conCat('dog', 'cat') → dogcat
// conCat('abc', '') → abc
public class Concat
{
    public static void concatIT(string word1, string word2)
    {
        if(word1.Length > 0 && word2.Length >0)
        {
            Console.WriteLine(word1+word2);
        }
        else if(word1.Length != 0)
        {
            Console.WriteLine(word1);
        }
        else if(word2.Length != 0)
        {
            Console.WriteLine(word2);
        }

    }
}