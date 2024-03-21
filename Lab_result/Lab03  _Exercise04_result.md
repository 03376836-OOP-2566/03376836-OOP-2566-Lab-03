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
เป็นโปรแกรม C# ที่ใช้ในการสร้างข้อความออกทางหน้าจอ โดยมีการใช้ escape sequences ในการจัดรูปแบบข้อความ และการใช้ Unicode character ในข้อความ โดยมีรายละเอียดดังนี้
 columns เป็น string ที่เก็บข้อความ "Column 1\tColumn 2\tColumn 3" โดยที่ \t คือ escape sequence ที่ใช้เพื่อแทนการขึ้น tab ในข้อความ เมื่อพิมพ์ออกมา tab จะถูกเพิ่มระหว่างคอลัมน์ต่างๆ rows เป็น string ที่เก็บข้อความ "Row 1\r\nRow 2\r\nRow 3" โดยที่ \r\n คือ escape sequence ส่วนบรรนทัด string title จะสร้างข้อความ ที่เป็น "\"I \u0003 C\u0023"; โดยจะโปลแกรมจะ Run ข้อความ ออกมาเป็น I u00038คือสัญลักษร์ หัวใจ และC\u0023" และu0023 คือสัญลักษณ์ # 
 
พอรวมข้อความออกมาจะเป็น  "I  ♥ C#
 
ในส่วนของโค้ด   System.Console.WriteLine(columns);จะส่งผลให้โปรแกรม Run ออกมาเป็น columns1  columns2 columns3 Run ตามโค้ดของ string columns = "Column 1\tColumn 2\tColumn 3";

ในส่วนของโค้ด System.Console.WriteLine(rows); จะส่งผลให้โปรแกรม Run Row1 Row2 Row3 อยู่ตรง Column 1 เชื่อมกับโค้ด string rows = "Row 1\r\nRow 2\r\nRow 3";

ในส่วนของโค้ด System.Console.WriteLine(title);  จะส่งผลให้โปรแกรม Run ออกมาเป็นข้อความที่เชื่อมกับโค้ด string title = "\"I \u0003 C\u0023"; จะ Run ออกมาเป็น  "I  ♥ C# ตามภาพ



## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/9ceb3593-ef13-46f1-b72b-d25e7c7d780e)


## ศึกษาเพิ่มเติม

[String escape sequences](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences)


### 65030289 นางสาว อัญชิสา เพชรน้อย
