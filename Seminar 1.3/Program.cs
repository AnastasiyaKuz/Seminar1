// Задача №3. Напишите программу, которая будет выдавать название дня недели
// по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Vvedite chislo day");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());
    if (numberDayOfWeek == 1)

    {
        Console.WriteLine("понедельник");
    }
        else if (numberDayOfWeek == 2)
        {
           Console.WriteLine("вторник"); 
        }
       
        else if (numberDayOfWeek == 3)
        {
            Console.WriteLine("среда");
        }
        else if (numberDayOfWeek == 4)
        {
            Console.WriteLine("четверг");
        }
        else if (numberDayOfWeek == 5)
        {
            Console.WriteLine("пятница");
        }
        else if (numberDayOfWeek == 6)
        {
            Console.WriteLine("суббота");
        }
        else if (numberDayOfWeek == 7)
        {
            Console.WriteLine("воскресенье");
        }
    else
    {
        Console.WriteLine("такого дня не существует");
    }   
        
        
        
        
        
       
        