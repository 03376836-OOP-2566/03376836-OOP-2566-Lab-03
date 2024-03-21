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
จากภาพจะเห็นว่ามีการแสดงผลทางข้อความที่แตกต่างกัน ดังนี้

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/0112ea5a-fff3-4e78-a4a7-0a308b1402e8)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/2cd88cde-e985-4bc4-a180-0ca17cf39f93)

ส่วนที่ต่างกันจะเป็นการแสดงผลทางข้อความของตัว 
Program #1
Before replace s1.hashcode = 7CF99035
Program #2
Before replace s1.hashcode = 5123405D

และก็การแสดงผลทางข้อความของ 
Program #1 จะมีการแสดงออกมาทั้ง s1 และข้อความของ s2
s1 = I ♥  Visual C#
s2 = I ♥  Visual Basic

Program #2
s1 = I ♥  Visual Basic

แต่มีการแสดงผลของการกำหนดค่าเหมือนกันคือ
 After replace s1.hashcode = 7CF99035
มีตัวเลขแสดงผลออกมาเหมือนกัน

จะเห็นว่าตัว Before  ของ Program #1
Program #2 มีความแตกต่างกันของตัวเลขที่แสดงออกมา
โดย Program #1
ในบรรทัดที่กำกับว่า "Before replace s1.hashcode = 7CF99035" จะหมายถึงว่าก่อนที่คำสั่ง "replace" จะถูกใช้กับตัวแปร s1 โดยที่ "replace" นั้นอาจจะหมายถึงการเปลี่ยนแปลงค่าในตัวแปรหรือการแทนที่ค่าในตัวแปร ค่า hash code ของ s1 ถูกแสดงด้วย "7CF99035" ซึ่งเป็นค่า hash code ที่ได้จากการคำนวณของวัตถุ s1 ก่อนที่คำสั่ง "replace"
รวมทั้ง Program #2 ก็ด้วย 
ในบรรทัดที่กำกับว่า "Before replace s1.hashcode = 5123405D" จะหมายถึงว่าก่อนที่คำสั่ง "replace" จะถูกใช้กับตัวแปร s1 โดยที่ "replace" นั้นอาจจะหมายถึงการเปลี่ยนแปลงค่าในตัวแปรหรือการแทนที่ค่าในตัวแปร ค่า hash code ของ s1 ถูกแสดงด้วย "5123405D" ซึ่งเป็นค่า hash code ที่ได้จากการคำนวณของวัตถุ s1 ก่อนที่คำสั่ง "replace" ซึ่งจะแสดงค่าของ Program  ของโค้ดนั้นที่ถูกกับหนดโดยเฉพาะ

ส่วนข้อความข้อง
Program #1 จะมีการแสดงออกมาทั้ง s1 และข้อความของ s2
s1 = I ♥  Visual C#
s2 = I ♥  Visual Basic

Program #2
s1 = I ♥  Visual Basic
มีการตั้งค่าการแสดงผลในโค้ด C# Program #1 ของตัว S1 s2 ที่ไม่เหมือนกับ Program #2 เพราะ Program #1  จะมี S1 s2  และมีข้อความที่แตกต่างกับ Program #2 ส่วน Program #2 จะมีการแสดงผลทางข้อความคือ s1 อย่างเดียว ซึ่งตัวข้อความที่แสดงผลออกมาจะเหมือนกับข้อความของตัว s2 ใน Program #1 ซึ่งมีข้อความ I ♥  Visual Basic เหมือนกัน แต่มีการใส่ใน S ที่ต่างกัน

เหตุผลที่เป็นแบบนี้เพราะเป็นการตั้งค่าในการใส่ข้อความในส่วนของ C# ที่ตั้งค่าให้มีการต่างกัน และแสดงผลออกมาตามการที่ตั้งค่าไว้ในโค้ดของ C#

### 65030289 นางสาว อัญชิสา เพชรน้อย
