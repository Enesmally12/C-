namespace cSharp_withMrMike.String;


public class checkIndex
{
    public static List<int>  getIndex(List<int> numbers, int target)
    {

        Dictionary<int , int> targetChecker = new();
        List<int> myresults = new List<int>();

        foreach(int num in numbers)
        {
            int result = target - num;
            if(targetChecker.ContainsKey(result))
            {
                myresults.Add(numbers.IndexOf(result));
                myresults.Add(numbers.IndexOf(num));
            }
            else
            {
                targetChecker[num] = numbers.IndexOf(num);
            }
        }

        return myresults;
    }
}