
Console.WriteLine("Please enter your First Name: ");
string firstName = Console.ReadLine();


Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

int finalAge;
finalAge = age + 5;

Console.WriteLine("Hello {0}. You will be {1} in 5 years!", firstName, finalAge);

