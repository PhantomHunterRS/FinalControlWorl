using System.Threading.Tasks;

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

internal class FinalControlWork
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the values of the array of strings separated by commas");
        String inputString = Console.ReadLine();
        String[] arrayString = inputString.Split(",");

        for (int i = 0; i < arrayString.Length; i++) 
        { 
            if 
        }

    }
    int quantity(String values)
    {   
        return values.ToCharArray().Length;
    }

}