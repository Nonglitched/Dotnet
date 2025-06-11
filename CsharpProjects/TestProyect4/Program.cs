int[] inv = {420, 450, 550, 680, 700};
int sum = 0;
int bin = 0;
foreach (int items in inv)
{
    bin++;
    sum+=items;
    Console.WriteLine(sum);
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"we have {sum} in our inventory");