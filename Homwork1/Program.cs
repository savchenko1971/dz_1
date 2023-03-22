
// //Задача 2
// //Напишите программу, которая на вход принимает два числа и выдает,
// //какое число большее, а какое меньшее.


// // Console.WriteLine("Введите первое число: ");
// // int num_A = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите второе число: ");
// // int num_B = Convert.ToInt32(Console.ReadLine());

// // if (num_A > num_B)
// // {
// //   Console.WriteLine("Первое числло " + num_A + " больше чем второе " + num_B);
// // }
// // else
// // {
// //   Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
// // }


// //Задача 4
// //Напишите программу, которая принимает на вход три числа и выдает
// //максимальное из этих чисел.

// Console.WriteLine("Введите три числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max)
// {
//   max = num2;
// }
// if (num3 > max)
// {
//   max = num3;
// }
// Console.WriteLine("Наибольшее из введенных чисел -> " + max);


//Задача 6
//Напишите программу, которая на вход принимает число и выдает,является
//четным (делится ли оно на 2 без остатка). 


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.Read());

// if (num % 2 == 1)
// {
//   Console.WriteLine("Число является НЕЧЁТНЫМ"); 
// }
// else
// {
//   Console.WriteLine("Число является ЧЁТНЫМ");
// }


//Задача 8
//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.


// int i = 1;
// bool not = true;

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Чётные числа от 1 до " + num);
// while (i <= num)
// {
//   if (i % 2 ! ==0)
//   {
//     Console.Write(i + ",");
//     not = false;
//   }
//   i++;
// }
// if (not)
// {
//   Console.WriteLine("Нет чётных чисел!");
// }
