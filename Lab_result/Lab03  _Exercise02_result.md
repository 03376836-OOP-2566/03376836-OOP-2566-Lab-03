# Lab 3 Exercise 2

## การใช้งาน String  

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/a297ad19-6440-491f-9e53-76c27db5c47e)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/874cb79c-0fb9-4af8-b145-d8b3f9d4198d)

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


## อธิบายผลที่ได้จากคำสั่ง



## ศึกษาเพิ่มเติม

<https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/>

### 65030289 นางสาว อัญชิสา เพชรน้อย



