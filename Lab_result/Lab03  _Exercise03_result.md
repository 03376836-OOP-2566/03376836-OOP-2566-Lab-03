# Lab 3 Exercise 3

## Immutability of strings

เมื่อเราสร้าง string object แล้ว เราจะไม่สามารถเปลี่ยนแปลงมันได้อีกเลย การกระทำใดๆ กับ string จะมีผลคือการสร้าง string  ใหม่ที่ให้ผลตามที่เรากำหนด

1. สร้าง project ใหม่

```cmd
dotnet new console -n Lab03_Exercise03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/cb12eb26-6637-4a25-b832-8c5039024ee2)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/36e67562-53ee-433c-9780-7cd1dff868d1)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/0f36cbc9-b063-448c-8756-8aec497ea461)

2. แก้ไข code ใน Program.cs เป็นดังนี้

```cs
string s1 = "A string is more ";
string s2 = "than the sum of its chars.";

System.Console.WriteLine("Before Concatenate of s1 and s2");
System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");
System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");
// Concatenate s1 and s2. This actually creates a new
// string object and stores it in s1, releasing the
// reference to the original object.

s1 += s2;

System.Console.WriteLine("After Concatenate of s1 and s2");
System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");
System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");
```

### อธิบายโปรแกรม

`System.Console.WriteLine($"Hash code of s1 = {s1.GetHashCode():X}");`
เป็นการแสดง hash code (รหัสประจำตัวของ object ของ s1)

object คนละตัวกันจะมี Hash code ไม่ตรงกัน
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/9a21ce24-f654-4e12-8cbc-a30ab51592cb)

## รันโปรแกรม

```cmd
dotnet run --project Lab03_Exercise03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/6e2893ab-a590-42af-a0f5-90992f343b1f)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/35ea3b72-200d-4a84-81bc-cc8998c2062a)

## ศึกษาเพิ่มเติม

GetHashCode() method
<https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-8.0>

### 65030289 นางสาว อัญชิสา เพชรน้อย
