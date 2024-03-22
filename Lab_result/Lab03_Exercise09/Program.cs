var sb = new System.Text.StringBuilder();

// Create a string composed of numbers 0 - 9
for (int i = 0; i < 10; i++)
{
    System.Console.Write ($"Loop {i+1, 2} : ");
    sb.Append(i.ToString());
    System.Console.WriteLine($"sb = {sb.ToString(),-11}, sb.GetHashCode() = {sb.GetHashCode()}");
}
Console.WriteLine($"Finally : sb = {sb}");  