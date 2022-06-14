Console.WriteLine("welcone to the Salary Calculator Simulation");
Random random = new Random();

const int Perhour = 20;
const int Fullday = 8;
const int PartTime = 4;
const int workingday = 20;

int num = random.Next(1, 3);
Console.WriteLine(num);

if (num == 1)
{
    Console.WriteLine("Present");
    int salary = (Perhour * Fullday);
    Console.WriteLine(salary);

}
else
{
    Console.WriteLine("Absent");
    Console.WriteLine("Noo wages");
}

int PartSal = (PartTime * Perhour);
Console.WriteLine("The Part Time Salary is : " + PartSal);

{
    int MonthlySalary = ( (Perhour * Fullday) * workingday );
    
    int sal = ( PartSal * Fullday);
    
    Console.WriteLine("Salary Per Month : " + MonthlySalary);
    
    Console.WriteLine("Salary Per Month as a Part Time Emp : " + sal);
    
}
