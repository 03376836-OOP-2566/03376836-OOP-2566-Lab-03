<img width="960" alt="image" src="https://github.com/Phetteepop/03376836-OOP-2566-Lab-03/assets/144197367/d5babe38-667c-42fa-9a3e-5cb1e5b3c52c">
using System;: บรรทัดนี้โหลด namespace System ซึ่งมีคลาสและยูทิลิตี้พื้นฐาน เช่น string, Console ฯลฯ
string s1 = new string("Hello World!");: บรรทัดนี้สร้างอินสแตนซ์ใหม่ของคลาส string ชื่อ s1 และกำหนดค่าเริ่มต้นเป็น "สวัสดี โลก!"
string s2 = "Hello World";: บรรทัดนี้สร้าง string object ชื่อ s2 ด้วยค่าเดียวกัน แต่ไม่ใช้ new
var s3 = "Hello World";: บรรทัดนี้ประกาศตัวแปร s3 โดยใช้ var ซึ่ง compiler จะตรวจสอบ type จากค่าที่ assign
string s4 = new("Hello World");: บรรทัดนี้ใช้ interpolated strings (C# 9)
Console.WriteLine(s1);: บรรทัดนี้พิมพ์ค่าของ s1
Console.WriteLine(s2);: พิมพ์ค่าของ s2
Console.WriteLine(s3);: พิมพ์ค่าของ s3
Console.WriteLine(s4);: พิมพ์ค่าของ s4
