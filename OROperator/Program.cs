// Math >=90 OR Chemistry >=90;
//Math >= 90, Biology >= 90, Chemistry >=90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math result: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result: ");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result: ");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >=90) || (math >= 90 && biology >=90) || (chemistry >=90 && biology >=90))
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application could not be approved");
}