Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage}%!");//1dia
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage}%!");//5dias
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription expires soon. Renew now!");//10dias
}
