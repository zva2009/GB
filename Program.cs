﻿
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
    if(num1 > num2)
        {
            Console.WriteLine("Наибольшее число =  " +num1);
            Console.WriteLine("Наименьшее число =  " +num2);

        }
    else if (num1 < num2)
        {
            Console.WriteLine("Наибольшее число =  " +num2);
            Console.WriteLine("Наименьшее число =  " +num1);
        }
            