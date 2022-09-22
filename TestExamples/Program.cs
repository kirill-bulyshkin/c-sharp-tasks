/*Написать метод, который принимает список чисел и преобразует список в строку чисел, разделенных запятой.
Перед каждым четным числом должна добавляться буква "e", перед нечетным - "o".
Например, результатом выполнения для (1, 2, 3, 4, 5, 10, 101) должно быть "o1,e2,o3,e4,o5,e10,o101".*/

class JaeTask
{
    static void Main(string[] args)
    {
        numberToStringConverter();
   
    }

    public static void numberToStringConverter() {

        Console.WriteLine("Please enter the numbers separated by spaces:");
        string[] listOfNumbers = Console.ReadLine().Split();
        string[] nums = new string[listOfNumbers.Length];

        const char e = 'e';
        const char o = 'o';

        try
        {

            for (int i = 0; i < listOfNumbers.Length; i++)

                //Check that number is even

                if (((Convert.ToInt32(listOfNumbers[i])) % 2) == 0)
                {
                    nums[i] = e + listOfNumbers[i];
                }
                else
                {
                    nums[i] = o + listOfNumbers[i];
                }

            string res = string.Join(", ", nums);
            Console.WriteLine(res);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}\nPlease try again with the correct data format.");
        }

      
    }
}

