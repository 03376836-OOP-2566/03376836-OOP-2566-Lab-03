# Lab 3 Exercise 6

## String interpolation

String interpolation

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise06
```

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

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise06
```
