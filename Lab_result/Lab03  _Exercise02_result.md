# Lab 3 Exercise 2

## การใช้งาน String  

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/a297ad19-6440-491f-9e53-76c27db5c47e)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/874cb79c-0fb9-4af8-b145-d8b3f9d4198d)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/bc5ffaa8-f588-40d3-9be2-b66bdecb0003)

2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
using System;
string s1 = new string("Hello, World!");
string s2 = "Hello, World!";
var s3 = "Hello, World!";
string s4 = new("Hello, World!");
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
```

### อธิบายโปรแกรม

- `string s1 = new string("Hello, World!");` เป็นการสร้าง object ของ string โดย operator `new` แล้วนำมาเก็บไว้ใน reference `s1`
- `string s2 = "Hello, World!";` เป็น quoted string literal
- `var s3 = "Hello, World!";`  เป็น local variable string literal
- `string s4 = new("Hello, World!");` เป็นรูปแบบย่อของ `string s1 = new string("Hello, World!");`




![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/26db43e8-5c04-4c46-a6e3-e8d21ba6c727)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/accc5bfb-cbb3-484b-a2d0-0a199b9f3e9b)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/008960a3-4524-4284-a920-3244bc7d6b83)




3. ทดสอบโปรแกรม cutpture หน้าจอ และอธิบายผลที่ได้

```cmd
dotnet run --project Lab03_Exercise02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/d7b97538-d009-4486-8645-0c1907c02013)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/0430a0bd-3179-4c8a-a079-db814846dfa6)

## อธิบายผลที่ได้
จากคำสั่งในการเขียนโค้ดใหม่ลงไปบน C# 
โค้ดด้านบนเป็นโปรแกรม C# ที่ใช้ในการสร้างและพิมพ์ข้อความ "Hello, World!" ออกทางหน้าจอ โดยมีการใช้ตัวแปรชนิดต่างๆ ในการเก็บข้อความเดียวกันและพิมพ์ออกมา โดยตัวแปรที่ใช้มีดังนี้:

   s1 คือ string object ที่สร้างโดยใช้ constructor new string() และใส่ค่า "Hello, World!" ลงไป ซึ่งไม่มีความจำเป็นในกรณีนี้ เนื่องจากสามารถกำหนดค่า string โดยตรงได้ ดังนั้นมันจะทำงานได้เหมือนกับการใช้ string literal ตรงๆ
    s2 เป็น string literal ที่กำหนดค่า "Hello, World!" โดยตรง
    s3 เป็น implicit variable (var) ที่กำหนดค่า "Hello, World!" โดยตรง โดย C# จะให้ประเภทของตัวแปรถูกต้องโดยอัตโนมัติจากค่าที่กำหนดให้
    s4 เป็น string object ที่สร้างโดยใช้ constructor new() และใส่ค่า "Hello, World!" ลงไป ซึ่งใช้ได้เหมือนกับ s1 แต่วิธีการสร้างออบเจ็กต์ต่างกัน

ผลลัพธ์ที่ได้จากการพิมพ์ออกมาทางหน้าจอคือ "Hello, World!" ทั้ง 4 รอบ เนื่องจากทุกตัวแปรมีค่าเท่ากัน

โดยเมื่อใช้คำสั่ง dotnet run --project Lab03_Exercise02 จะแสดงผลบน git bash ว่า "Hello, World!"



## ศึกษาเพิ่มเติม

<https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/>

### 65030289 นางสาว อัญชิสา เพชรน้อย



