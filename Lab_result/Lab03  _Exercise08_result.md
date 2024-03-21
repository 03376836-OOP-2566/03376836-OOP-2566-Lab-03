# Lab 3 Exercise 8

## Null strings and empty strings

Empty strings คือ object ของ string ที่ว่างเปล่า (ความยาวของข้อความที่เก็บใน string เป็นศูนย์) เราสามารถใช้งาน method ต่างๆ ของ string ได้ตามปกติ

Null strings คือ reference ที่ไม่ได้ชี้ไปยัง string ใดๆ เลย ถ้าเราพยายามใช้งาน จะเกิดการผิดพลาดที่ชื่อว่า  [NullReferenceException](https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception?view=net-8.0)  

อย่างไรก็ตาม เราสามารถใช้ null strings ในการเปรียบเทียบหรือเชื่อมต่อกับ string อื่นๆ

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise08
```

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

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise08
```

### 65030289 นางสาว อัญชิสา เพชรน้อย
