 // Hапишите программу, 
// которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int[] array = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
Console.WriteLine("a = ");

int a = Convert.ToInt32(Console.ReadLine());

int n =  array.Length;

int index = 0;

while (index < n)
{
    if(array[index] == a){
        if ( index == 5 ){
            Console.WriteLine("Выходной");
            break;
        }
        if( index == 6 ){
            Console.WriteLine("Выходной");
            break;
        }
        Console.WriteLine("Рабочий");
        break;
    }
    index++;
}  




