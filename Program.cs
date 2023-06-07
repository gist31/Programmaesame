System.Console.WriteLine("Geben Sie eine Nummer ein:");
            
long num = Convert.ToInt32(Console.ReadLine());

List<long> CalcoliInArray = new List<long>();

while (num != 0)
{
    CalcoliInArray.Add(num);
    num--;
} 

long factorial = 1;

foreach (var CalcoloInArray in CalcoliInArray)
{
    factorial *= CalcoloInArray;
}
            
System.Console.WriteLine(factorial);