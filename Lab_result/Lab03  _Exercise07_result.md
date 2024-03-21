# Lab 3 Exercise 7

## Substrings

Substrings ใช้สร้าง string ใหม่จากส่วนหนึ่งของ string  ต้นฉบับ 
การกระทำของ method ต่างๆ จะไม่มีการแก้ไขสตริงดั้งเดิม 

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/4c5f655f-114a-4ba5-a2a9-a93966dc3cf3)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/0fbd0044-fcce-4060-a51e-4a7e533630bd)


2. แก้ไข code ใน Program.cs เป็นดังนี้

### Program #1

```cs
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
var s2 = s1.Replace("C#", "Basic");
System.Console.WriteLine($"s1 = {s1}");
System.Console.WriteLine($"s2 = {s2}");
System.Console.WriteLine($"After replace s1.hashcode = {s1.GetHashCode():X}"); 
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/b1fda751-04b0-4f45-a555-59d4a59f2ad8)



## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/4716d1bc-c37c-4d71-8405-721d3c91498f)


3. แก้ไข code ใน Program.cs เป็นดังนี้

### Program #2

```cs
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
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/56f5182f-d48f-4f65-84d3-3cb81171a266)

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/7f2c9467-baf2-4af1-9bce-f4045988a518)

## คำถาม
โปรแกรม #1 ในข้อ 2 และโปรแกรม #2 ในข้อ 3 มีผลลัพธ์ที่ต่างกันอย่างไร
อธิบายว่าทำไมจึงเป็นเช่นนั้น

### 65030289 นางสาว อัญชิสา เพชรน้อย
