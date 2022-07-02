void Week (int num)
{ if (num>0 & num<8)
    {
        if (num < 6)
        {
            Console.WriteLine(num+ "-> Рабочий день");
        }
        else
        {
            Console.WriteLine(num+ "-> Выходной день");
        }
    }
    else 
    {
        Console.WriteLine("->Такого дня нет");
    }
    

};
Console.Write ("Введите цифру дня недели");
int number = Convert.ToInt32(Console.ReadLine());

Week(number);