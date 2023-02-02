 // System.Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int fu(int num){
//     return (num/10)%10;
// }

// if (number > 99 && number <= 999){
//     System.Console.WriteLine(fu(number));
// }
// else{
//     System.Console.WriteLine("Вы ввели не трехзначное число");
// }

// // ---------------------------------------------------------------------------
// // ---------------------------------------------------------------------------
// // ---------------------------------------------------------------------------

// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] digits = new int[1 + (int)Math.Log10(x)];
// for (int i = digits.Length - 1; i >= 0; i--)
// {
//     int digit;
//     x = Math.DivRem(x, 10, out digit);
//     digits[i] = digit;
// }
//P.S. Я разобрался с каждым из испольхуемым методов класса Math
// if(digits.Length<3){
//     System.Console.WriteLine("В числе нет 3й цифры");
// }
// else{
//     System.Console.WriteLine(digits[2]);
// }

// // ---------------------------------------------------------------------------
// // ---------------------------------------------------------------------------
// // ---------------------------------------------------------------------------

System.Console.WriteLine("Введите день недели (число) ");
int x = Convert.ToInt32(Console.ReadLine());



if(x<6){
     System.Console.WriteLine("Будний день");
}
else if(x>5 && x<8){
    System.Console.WriteLine("Выходной день");
}
else{
    System.Console.WriteLine("такого дня недели нет");
}