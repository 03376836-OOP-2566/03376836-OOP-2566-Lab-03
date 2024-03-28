// See https://aka.ms/new-console-template for more information
string s1 = "I \u0003 Visual C# ";
System.Console.WriteLine($"s1 = {s1}");

// 1. เมธอด IndexOf() ใช้ค้นหาลำดับที่ของอักขระที่ปรากฏใน string และส่งค่าตำแหน่งที่พบมาให้ (Zero index)
var indexOfC = s1.IndexOf("C");
System.Console.WriteLine($"Index of C in s1 = {indexOfC}");

// 2. เมธอด Substring(  ) คัดลอกบางส่วนของ string ต้นฉบับออกมา โดยการระบุพารามิเตอร์ ตำแหน่งเริ่มต้นและความยาวที่ต้องการ 
var substring = s1.Substring(indexOfC, 2);
System.Console.WriteLine($"s1.Substring({indexOfC}, 2) = {substring}");

// 3. เมธอด Replace(  ) ใช้แทนที่บางส่วนของ string  ด้วย string ที่กำหนด 
System.Console.WriteLine($"Replace C# with Basic and write to s2");
System.Console.WriteLine($"Before replace s1.hashcode = {s1.GetHashCode():X}");
s1 = s1.Replace("C#", "Basic");
System.Console.WriteLine($"s1 = {s1}");
System.Console.WriteLine($"After replace s1.hashcode = {s1.GetHashCode():X}");