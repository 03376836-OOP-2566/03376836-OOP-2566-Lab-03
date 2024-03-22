string s1 = "A string is more ";
string s2 = "than the sum of its chars.";

System.Console.WriteLine("Before Concatenate of s1 and s2");
System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");
System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");
// Concatenate s1 and s2. This actually creates a new
// string object and stores it in s1, releasing the
// reference to the original object.

s1 += s2;

System.Console.WriteLine("After Concatenate of s1 and s2");
System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");
System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");