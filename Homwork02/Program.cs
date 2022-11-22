// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
Console.WriteLine("a = ");

int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString ( a );

if (b.Length == 3 ){   
    if(a > 0)
           Console.WriteLine( b[2]);
    else
           Console.WriteLine("Третьей цифры нет");       
}
else{ 
    if (b.Length > 3 ){
                if(a < 0)
                    Console.WriteLine( b[3]); 
                else
                    Console.WriteLine( b[2]);
    }
    else
        Console.WriteLine("Третьей цифры нет");  
}