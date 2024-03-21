# Lab 3 Exercise 5

## Verbatim string literals

Verbatim string literals เป็น string ที่ขึ้นต้นด้วย @ ช่วยให้เราไม่ต้องเขียน escape sequence ทำให้ประหยัดเวลาในการเขียน code   และอ่าน code ได้ง่ายขึ้น

  

1. สร้าง project ใหม่

```
dotnet new console -n Lab03_Exercise05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/2d4553c8-a584-4d51-98a4-3e235ddc48c4)


2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
string filepath  = "C:\\OOP\\Lab03\\Exercise05";
string Verbatim_filepath  = @"C:\OOP\Lab03\Exercise05";

System.Console.WriteLine(@"Example #1. directory name separation '\'");
System.Console.WriteLine($"filepath = {filepath}");
System.Console.WriteLine($"Verbatim_filepath = {Verbatim_filepath}");

// 
var multi_line_text = "this\nis\nmulti\nline\ntext.";

var verbatim_multi_line_text = @"this
is
multi
line
text.";

System.Console.WriteLine("--------------------------------------");
System.Console.WriteLine(@"Example #2. multi line text without \n escape sequence");
System.Console.WriteLine($"multi_line_text = {multi_line_text}");
System.Console.WriteLine($"verbatim_multi_line_text = {verbatim_multi_line_text}");

var quote_in_text = "My name is \"Sara\".";
var quote_in_verbatim_text = @"My name is ""Sara"".";

System.Console.WriteLine("--------------------------------------");
System.Console.WriteLine(@"Example #3. double quote in text");
System.Console.WriteLine($"quote_in_verbatim_text = {quote_in_verbatim_text}");
System.Console.WriteLine($"quote_in_text = {quote_in_text}");

```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/424876bc-367c-4c03-ae8e-f6f41f1c36c5)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/4e62a41c-5c40-46a1-a8e7-a6fac099478c)


## รันโปรแกรม

``` cmd
dotnet run --project Lab03_Exercise05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/8bf06e70-f9a6-4339-96ee-e7eb4dcc9904)



### 65030289 นางสาว อัญชิสา เพชรน้อย
