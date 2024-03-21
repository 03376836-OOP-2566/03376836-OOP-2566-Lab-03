# Lab 3 Exercise 4

## Quoted string literals

Quoted string literals เป็นข้อความที่อยู่ภายใต้กรอบของ `""` ซึ่งอยู่ในบรรทัดเดียวกัน จะมีอักขระขึ้นบรรทัดใหม่แทรกอยู่ไม่ได้ หากต้องการขึ้นบรรทัดใหม่ ให้ใส่ escape sequence ลงไปแทน  

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise04
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/6e54fc2f-1cf4-4f35-974e-815a122fa3ad)


2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
string columns = "Column 1\tColumn 2\tColumn 3";
string rows = "Row 1\r\nRow 2\r\nRow 3";
string title = "\"I \u0003 C\u0023";

System.Console.WriteLine(columns);
System.Console.WriteLine(rows);
System.Console.WriteLine(title);
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/c27a746b-6b76-40cf-afd8-c5daf649e405)

### อธิบายโปรแกรม







## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/9ceb3593-ef13-46f1-b72b-d25e7c7d780e)


## ศึกษาเพิ่มเติม

[String escape sequences](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences)


### 65030289 นางสาว อัญชิสา เพชรน้อย
