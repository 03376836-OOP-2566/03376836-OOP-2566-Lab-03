# การสร้าง project ด้วย dotnet CLI

## 3. ตัวอย่างการสร้างโปรแกรม

### 3.1 การสร้าง project แรก "Hello_World"

1. ใน terminal ของ visual studio code ให้พิมพ์คำสั่งต่อไปนี้

``` cmd
dotnet new console -n Hello_World
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/42688d62-ab0c-4ed6-adb9-2bfd89bebfe0)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/e80005bc-f4c0-4992-a51b-6705ddc12140)



- dotnet จะสร้างโฟลเดอร์  hello world  พร้อมทั้งรายงานผลการทำงานที่หน้าจอ console

- ในขั้นนี้อาจจะมีคำเตือนบางอย่าง ถ้าไม่ร้ายแรง (ไม่กระทบต่อการสร้าง code)  ก็สามารถละเลยได้

2. คลิกเข้าไปดูในไฟล์ Program.cs จะเห็น source code ดังต่อไปนี้

```cs
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

ซึ่งเป็นการเขียนในสไตล์ top-level statement เริ่มใช้ครั้งแรกใน .NET 6.0 ดังนั้น ถ้าใครใช้ .NET < 6.0 ก็จะได้ code แบบสมบูรณ์ ดังต่อไปนี้

3. ใน terminal ของ visual studio code ให้พิมพ์คำสั่งต่อไปนี้

``` cmd
dotnet build Hello_World
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/4ed8bbc8-9caa-4784-b01b-4a9261b7482f)


dotnet จะ build project และสร้าง folder ใหม่ขึ้นมาดังภาพ

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/795273cc-5802-420a-ad06-1f9d43f9f542)

4. ใน terminal ของ visual studio code ให้พิมพ์คำสั่งต่อไปนี้

``` cmd
dotnet run --project Hello_World
```
 จะได้ผลลัพธ์

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/ac5da64f-9fb5-41c1-9537-362936f7a7d5)

หมายเหตุ

ใน vscode มี extension หลายตัวที่ช่วยเขียนโปรแกรม เบื้องต้นให้ติดตั้ง extension C# Dev Kit จาก Microsoft


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-03/assets/144197034/1144074f-a6d8-4404-9141-a20cda53424a)



## 65030289 นางสาว อัญชิสา เพชรน้อย

