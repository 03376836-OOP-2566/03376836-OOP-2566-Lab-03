# Lab 3 Exercise 6

## String interpolation

String interpolation

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise06
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/5a9dc69c-e0f4-4775-a6cc-752af9ae424c)

2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
var student = (firstname: "fname", Lastname:"lname", id: 65031234);
// แก้ไข fname, lname และ id ให้เป็นข้อมูลของนักศึกษาเอง
System.Console.WriteLine(
@$"First name: {student.firstname} 
Last name: {student.Lastname} 
ID:{student.id}");

int x = 3;
int y = 4;
System.Console.WriteLine($$"""Distance from origin to the point ({{x}},{{y}}) is {{Math.Sqrt(x*x+y*y)}}""");  

System.Console.WriteLine("\n\nMethod to show { and } in string");
System.Console.WriteLine($$"""Distance from origin to the point ({x},{y}) is {Math.Sqrt(x*x+y*y)}""");  

```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/e47aeb9d-fc57-46a6-8c37-2cb3e14d9fa7)

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise06
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/ecfc4f0e-8696-43ca-994a-9b40b1b59930)

### 65030289 นางสาว อัญชิสา เพชรน้อย 
