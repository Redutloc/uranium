


//Задача 3
public class Example
{
    public static void reverseList<T>(List<T> list)
    {

        if (list == null || list.Count <= 1)
        {
            return;
        }


        T value = list[0];
        list.RemoveAt(0);


        reverseList(list);

        list.Add(value);
    }

    public static void Main()
    {
        List<int> list = new List<int> { 2, 4, 6, 8 };

        reverseList(list);
        Console.WriteLine(String.Join(',', list));
    }
}
