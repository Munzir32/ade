
Console.WriteLine("Enter firstName:");
string firstName = Console.ReadLine();
Console.WriteLine("firstName is: " + firstName);

Console.WriteLine("Enter lastName:");
string lastName = Console.ReadLine();
Console.WriteLine("lastName is: " + lastName);

Console.WriteLine("Enter Your age:");
string age = Console.ReadLine();
Console.WriteLine("age is: " + age);

Console.WriteLine("Enter favourite color:");
string favouriteColor = Console.ReadLine();
Console.WriteLine("favourite color is: " + favouriteColor);

Console.WriteLine("Enter favourite Food:");
string favouriteFood = Console.ReadLine();
Console.WriteLine(" Enter favourite food : " + favouriteFood);

Console.WriteLine("Enter state of Origin:");
string stateOforigin = Console.ReadLine();
Console.WriteLine("Enter state of origin : " + stateOforigin);

Console.WriteLine("My name is " + firstName + (" ") + lastName + " from " + stateOforigin +  ". I am "+ age + "years old." + " My favourite food is " + favouriteFood + " and my favourite color is " + favouriteColor + " . ");
//interpolation
Console.WriteLine($"My name is {firstName} {lastName} from {stateOforigin}. I am {age} years old. My favourite food is {favouriteFood} and my favourite color is {favouriteColor}");

