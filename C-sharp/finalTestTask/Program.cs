using static System.Console;

namespace FinalTest
{
    class Program
    {
        static void Main()
        {
            Clear();
            string[] array = { "hello", "2", "world", ":-)", "qw" };
            int k = 0;
            GetLengthNewArray(array);
            string[] result = new string[k];
            k = 0;
            GetNewArray(array);

            int GetLengthNewArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        k++;
                    }
                }
                return k;
            }

            string[] GetNewArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        result[k] = array[i];
                        k++;
                    }
                }
                return result;
            }
        }
    }
}
