<img width="960" alt="image" src="https://github.com/Phetteepop/03376836-OOP-2566-Lab-03/assets/144197367/f61eb6a7-d1d6-4be8-b143-3ce5bcff1982">

### อธิบาย ###

```
string s1 = "A string is more ";: สร้างตัวแปรสตริงชื่อ s1 และเก็บข้อความ "A string is more " ไว้
string s2 = "than the sum of its chars.";: สร้างตัวแปรสตริงชื่อ s2 และเก็บข้อความ "than the sum of its chars." ไว้
System.Console.WriteLine("Before Concatenate of s1 and s2");: พิมพ์ข้อความ "Before Concatenate of s1 and s2" ลงบนหน้าจอ
System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");: พิมพ์ค่าของ s1 และแฮชโค้ดของมัน (ในรูปแบบเลขฐานสิบหก) ลงบนหน้าจอ
System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");: พิมพ์ค่าของ s2 และแฮชโค้ดของมัน ลงบนหน้าจอ
s1 += s2;: ต่อสตริง s2 ต่อท้าย s1 และเก็บผลลัพธ์ไว้ใน s1 เดิม ซึ่งจะสร้างสตริงใหม่
System.Console.WriteLine("After Concatenate of s1 and s2");: พิมพ์ข้อความ "After Concatenate of s1 and s2"
System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");: พิมพ์ค่าของ s1 และแฮชโค้ดใหม่ ลงบนหน้าจอ
System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");: พิมพ์ค่าของ s2 และแฮชโค้ดของมัน (ซึ่งไม่เปลี่ยนแปลง) ลงบนหน้าจอ
```
