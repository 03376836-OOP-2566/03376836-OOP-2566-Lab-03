# Lab 3 Exercise 1

## Console.ReadLine() และ Console.WriteLine()  

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise01
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/d02717bb-57ff-4b69-b1c8-4b080ffcc6c0)


2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
System.Console.WriteLine("Hello, I'm 6x03xxxx");
System.Console.WriteLine("Please enter your name");
var name = System.Console.ReadLine();  
System.Console.WriteLine($"Your name is {name}");
```
### อธิบายโปรแกรม

- บรรทัดที่ 1 ให้นักศึกษาเปลี่ยน 6x03xxxx เป็นรหัสประจำตัวนักศึกษาของตนเอง
- บรรทัดที่ 2 แสดงข้อความออกทางหน้าจอ
- บรรทัดที่ 3 เป็นการอ่านข้อความ 1 บรรทัด (จบด้วยการกดปุ่ม enter)
- บรรทัดที่ 4 แสดงข้อความ `Your name is`   พร้อมทั้งข้อความที่รับมาจากบรรทัดที่ 3 ออกืทางหน้าจอ

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/6124ceae-891f-4104-b5b4-bcfb942a19c8)

3. ทดสอบโปรแกรมโดยการรันและป้อนชื่อของนักศึกษา แล้ว cutpture หน้าจอ

```cmd
dotnet run --project Lab03_Exercise01
```
ผลการรันโปรแกรม
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/15790c94-6671-4ba8-8cea-fab9228d6c28)


### 65030289 นางสาว อัญชิสา เพชรน้อย



