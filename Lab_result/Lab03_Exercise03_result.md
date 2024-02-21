![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/d950d76d-97ef-485f-aff0-3d815aa98352)

![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/5649589f-00c7-4ca7-b0a2-11ddc1fe90df)

### อธิบายโปรแกรม
- `string s1 = "A string is more "; และ string s2 = "than the sum of its chars.";` สร้างและกำหนดค่าให้กับตัวแปร s1 และ s2 ตามลำดับ.

- `System.Console.WriteLine("Before Concatenate of s1 and s2"); แสดงข้อความ "Before Concatenate of s1 and s2"` บน Console

- `System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");` แสดงค่าของ s1 พร้อมกับ hash code ของ s1 ในรูปแบบที่ถูกแปลงเป็นตัวอักษรฐาน 16 

- `System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");` แสดงค่าของ s2 พร้อมกับ hash code ของ s2 ในรูปแบบที่ถูกแปลงเป็นตัวอักษรฐาน 16 

- `s1 += s2; นำ string s2 มา concatenate กับ s1 และเก็บผลลัพธ์ใน s1. `คำสั่งนี้จะสร้าง string object ใหม่ และเก็บ reference ของ object ใหม่นี้ใน s1, โดยทำให้ reference ของ object เดิมที่เกี่ยวข้องกับ s1 ก่อนหน้านี้ถูกปล่อย

- `System.Console.WriteLine("After Concatenate of s1 and s2");` แสดงข้อความ "After Concatenate of s1 and s2" บน Console เพื่อแสดงถึงขั้นตอนที่ทำการ concatenate เสร็จสิ้น

- `System.Console.WriteLine($"s1 = \"{s1}\", Hash code = {s1.GetHashCode():X}");` แสดงค่าของ s1 หลังจากทำการ concatenate พร้อมกับ hash code ของ s1 ในรูปแบบที่ถูกแปลงเป็นตัวอักษรฐาน 16 

- `System.Console.WriteLine($"s2 = \"{s2}\", Hash code = {s2.GetHashCode():X}");` แสดงค่าของ s2 หลังจากทำการ concatenate พร้อมกับ hash code ของ s2 ในรูปแบบที่ถูกแปลงเป็นตัวอักษรฐาน 16 

### อธิบายผลโปรแกรม

- แสดงผลลัพธ์ทั้งก่อนรวมและหลังรวม hash code
