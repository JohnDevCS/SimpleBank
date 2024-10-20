using SimpleBank;

namespace SortingArrays
{
    internal class Program
    {
        static void Main(string[] args) {
           
            IntArrayHelper SortArray = new IntArrayHelper();
            
            int[] i = { 44,12,5,4,2 };

            Console.WriteLine(string.Join(", ", SortArray.SortAscending(i)));

            int[] h = { 44, 12, 5, 4, 2 };

            Console.WriteLine(string.Join(", ", SortArray.SortAscendingAndReverse(i)));

        }
    }
}
