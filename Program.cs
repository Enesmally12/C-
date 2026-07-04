using cSharp_withMrMike.front11;

int[] no = [1,7];
int[] no2 = [];

int[] results = Front11.front1(no,no2);

foreach(int result in results)
{
    Console.Write(result + " ");
}