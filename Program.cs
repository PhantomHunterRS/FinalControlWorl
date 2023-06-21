using System;
using System.Globalization;
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
        FinalControlWork fcw = new FinalControlWork();
        int len = fcw.newArrayLength(arrayString);
        Console.WriteLine(len);
        String[] newArray = fcw.fillingArray(arrayString, len);
        fcw.print(newArray);
    }
    
    int newArrayLength(String [] array)
    {
        int len = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (quantity(array[i]) <= 3) len++;
        }
        return len;
    }

    String[] fillingArray(String[] array, int length)
    {
        String[] newArray = new String[length];
        for (int i=0, j = 0; i < array.Length; i++)
        {
            if (quantity(array[i]) <= 3)
            {
                newArray[j] = array[i];
                j++;
            }
        }
        return newArray;
    }

    String[] createNewArray(int length)
    {
        return new String[length];
    }

    int quantity(String values)
    {   
        return values.ToCharArray().Length;
    }

    void print(String [] array)
    {
        for (int i = 0;i < array.Length;i++)
        {
            Console.WriteLine(array[i]);
        }

    }
     

}