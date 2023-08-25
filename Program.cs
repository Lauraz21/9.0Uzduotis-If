Console.WriteLine("Iveskite skaiciu A, B ir C reiksmes: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int positiveNumber = 0;
int sum = 0;

if (numberA >0)
{
    positiveNumber++;
    sum += numberA;
}
if(numberB >0)
{
    positiveNumber++;
    sum += numberB;
}
if (numberC >0)
{
    positiveNumber++;
    sum += numberC;
}

if (positiveNumber >= 2)
{
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Neįmanoma suskaičiuoti sumos");
}


//if ((numberA > 0 && numberB > 0) ||
//    (numberB > 0 && numberC > 0) ||
//    (numberA > 0 && numberC > 0) ||
//    (numberA > 0 && numberB > 0 && numberC > 0))

//    {
//    int sum = numberA + numberB + numberC;
//    Console.WriteLine(sum);
//    }
//else
//{
//    Console.WriteLine("Neįmanoma suskaičiuoti sumos");
//}