# Lab 3 Exercise 9

## Using StringBuilder
จากการทดลองที่ผ่านมา เราจะเห็นว่า string เป็น object ชนิด immutable คือไม่สามารถแก้ไขได้ การแก้ไขใดๆ ใน string จะส่งผลให้ระบบสร้าง string ใหม่ขึ้นมาแทน string เก่า

ในการใช้งานที่มีปริมาณการกระทำต่อ string ซ้ำ ๆ เป็นจำนวนมาก อาจจะก่อให้เกิดปัญหาด้านประสิทธิภาพการทำงานของระบบคอมพิวเตอร์ได้

คลาส StringBuilder จะมีการสร้าง buffer ของ string ไว้ภายใน ทำให้ไม่ต้องสร้าง string ใหม่เมื่อมีการเปลี่ยนแปลงค่าในข้อความดังเช่นการใช้ string โดยทั่วไป
 
1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise09
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/728dd64d-4555-4ccb-b41d-1e4b9d8fc897)

2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
System.Text.StringBuilder sb = new System.Text.StringBuilder("Rat is my favorite animal.");

System.Console.WriteLine(@$"Before change : sb = {sb.ToString()}, 
sb.GetHashCode = {sb.GetHashCode()}");

System.Console.WriteLine(@"Replace first char in sb  from R to C");
sb[0] = 'C';

System.Console.WriteLine(@$"After change : sb = {sb.ToString()}, 
sb.GetHashCode = {sb.GetHashCode()}");
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/3ad8aea1-78d1-4bb0-92c4-4865eadd6a89)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/c930dff6-5154-43a1-a964-4adc6e4ee202)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/da64492b-86f1-4a98-b018-6ae8d2abd7cf)

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise09
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/a79fc4c0-a44d-48c1-bf81-e976222178f7)

3. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
var sb = new System.Text.StringBuilder();

// Create a string composed of numbers 0 - 9
for (int i = 0; i < 10; i++)
{
    System.Console.Write ($"Loop {i+1, 2} : ");
    sb.Append(i.ToString());
    System.Console.WriteLine($"sb = {sb.ToString(),-11}, sb.GetHashCode() = {sb.GetHashCode()}");
}
Console.WriteLine($"Finally : sb = {sb}");  
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/93ed8ca4-7e05-4520-adec-985dc73b49e5)

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise09
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/8cee164f-4e19-4eea-9738-6cacf95c8c7a)

### 65030289 นางสาว อัญชิสา เพชรน้อย
