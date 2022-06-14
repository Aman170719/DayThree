Random random = new Random();

 int num =  random.Next(1, 3);

Console.WriteLine(num);

switch (num)
{
    case 1:
        Console.WriteLine("Employee Is Present");
        int fullTime = 8;
        int wages = (fullTime * 20);
        Console.WriteLine(wages);
        break;
        
    case 2:
        Console.WriteLine("Employee Is PartTime");
        int partTime = 4;
        int wages2 = (partTime * 20);
        Console.WriteLine(wages2);
        break;

   default:
        Console.WriteLine("Employee Is Absent");
        break;
}
