//Задача 1
Console.WriteLine("Введите пятизначное число для проверки являестя ли число палиндромом");
int x = Convert.ToInt32(Console.ReadLine());
int one = x%10;
int two = x/10%10;
int four = x/1000%10;
int five = x/10000;
if (one==five && two == four)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }

//Задача 2
Console.WriteLine("Введите координаты Х");
int Xx = Convert.ToInt32(Console.ReadLine());
int Xy = Convert.ToInt32(Console.ReadLine());
int Xz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y");
int Yx = Convert.ToInt32(Console.ReadLine());
int Yy = Convert.ToInt32(Console.ReadLine());
int Yz = Convert.ToInt32(Console.ReadLine());
double lenght = 0;
zadacha21(Xx, Xy, Xz, Yx, Yy, Yz);
    
    void zadacha21(int Xx, int Xy, int Xz, int Yx, int Yy, int Yz)
    {
        lenght = Math.Sqrt((Math.Pow(Yx - Xx, 2) + Math.Pow(Yy - Xy, 2) + Math.Pow(Yz - Xz, 2)));
        Console.Write(lenght);
    }

// Задача 3
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
zadacha22(number);

   void zadacha22(int curentnumber)
        {
            int count = 1;
            int quarter = 0;
            while (count<=number)
            {
               quarter = count*count*count;
                Console.Write(quarter + "  ");
                count++;
            }
        }






   