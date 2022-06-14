Console.WriteLine("welcone to the Salary Calculator Simulation");
const int Perhour = 20;
const int Fullday = 8;
const int PartTime = 4;
const int NoOfday= 20;

Random random = new Random();

int num = random.Next(1, 3);

Console.WriteLine(num);

if (num == 1)
{
    Console.WriteLine("Present");
    int salary = ( Perhour * Fullday );
    Console.WriteLine("Day Salary" + salary );

}
else
{
    Console.WriteLine("Absent");
    Console.WriteLine( "Noo wages" );
}
//Monthly Salary is provided below with 20 days as a month
//Same with part time work too
{
    int PartTimeSalary = (PartTime * Perhour);
    Console.WriteLine("The Part Time Salary is " + PartTimeSalary);


    int salary = (Perhour * Fullday);
    Console.WriteLine("Monthly Salary");
    Console.WriteLine("Full Time Job : " + (salary * 20));


    Console.WriteLine("Part Time Job : " + (PartTimeSalary * 20));
}
