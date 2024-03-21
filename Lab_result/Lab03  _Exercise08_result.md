# Lab 3 Exercise 8

## Null strings and empty strings

Empty strings คือ object ของ string ที่ว่างเปล่า (ความยาวของข้อความที่เก็บใน string เป็นศูนย์) เราสามารถใช้งาน method ต่างๆ ของ string ได้ตามปกติ

Null strings คือ reference ที่ไม่ได้ชี้ไปยัง string ใดๆ เลย ถ้าเราพยายามใช้งาน จะเกิดการผิดพลาดที่ชื่อว่า  [NullReferenceException](https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception?view=net-8.0)  

อย่างไรก็ตาม เราสามารถใช้ null strings ในการเปรียบเทียบหรือเชื่อมต่อกับ string อื่นๆ

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise08
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/0eff9fdb-a024-49da-a32d-5f791fbf240c)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/8303baf9-b692-4365-ac04-ecee2f498adf)

2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
// 1. สร้าง object ของ string ตามปกติ  
string str = "hello";

// 2. สร้าง string  ที่ไม่ชี้ไปที่ object ใดๆ   
string? nullStr = null;

// 3. สร้าง string ที่ว่าง   
string emptyStr = String.Empty;

// 4. null string สามารถใช้เชื่อมต่อกับ string อื่น ๆ ได้ 
string tempStr = str + nullStr;
System.Console.WriteLine($"tempStr = {tempStr}");  

// 5. เปรียบเทียบว่า  emptyStr กับ nullStr  เป็นอย่างเดียวกันหรือไม่
bool b = (emptyStr == nullStr);
System.Console.WriteLine($"Check (emptyStr == nullStr) result is  {b}");

// 6. สร้าง string ใหม่จาก   emptyStr และ nullStr  
string newStr = emptyStr + nullStr;
System.Console.WriteLine($"emptyStr.Length = {emptyStr.Length}");
System.Console.WriteLine($"newStr.Length = {newStr.Length}");
System.Console.WriteLine($"newStr = {newStr}");

// 7. ถ้าบรรทัดนี้ error ให้ comment ออกแล้ว run ใหม่ 
// Capture  หน้าจอไว้ด้วยว่าโปรแกรมแสดง error อย่างไร
System.Console.WriteLine($"nullStr.Length = {nullStr.Length}");

// 8. อักขระ null จะสามารถส่งไปแแสดงผลและถูกนับเป็นหนึ่งอักขระเช่นเดียวกับอักขระอื่น ๆ เพียงแต่มันไม่แสดงรูปร่างบนหน้าจอภาพ  
// 8.1 เชื่อมอักขระปกติต่อท้ายอักขระ null
string s1 = "\x0" + "abc";
System.Console.WriteLine(@"s1 = ""\x0"" + ""abc""");
System.Console.WriteLine($"s1 = *{s1}*, s1.Length = {s1.Length}");

// 8.2 เชื่อมอักขระ null ต่อท้ายอักขระปกติ
string s2 = "abc" + "\x0";
System.Console.WriteLine(@"s2 = ""abc"" + ""\x0""");
System.Console.WriteLine($"s2 = *{s2}*, s2.Length = {s2.Length}");
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/b72a925e-c1e8-4e7c-9a3a-1f3e0c3a4841)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/8843c32f-84a1-4c7a-9f39-c8d85cf1b3c9)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/2e71f867-b932-4c5a-a61d-1ce512eeb0a7)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/8343c438-dd3c-42b0-bb55-53d2802f1556)

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise08
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/6324e717-3a37-4da2-81a1-f76891a2d985)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/79f61d37-9446-434e-892e-2b7e6ae23f76)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/a4506955-b5c7-4a80-8107-382e07788f1b)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/8c3e0790-853a-4915-aa4f-aa3c86294587)


### 65030289 นางสาว อัญชิสา เพชรน้อย
