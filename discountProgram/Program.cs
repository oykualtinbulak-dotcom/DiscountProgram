Console.Write("Enter The Price :");
double price = Convert.ToDouble(Console.ReadLine());
double discount = 20;
double result = (price * discount) / 100;
Console.Write("New Price :");
Console.Write(price - result);

