<img width="796" alt="Screenshot 2024-03-23 225435" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-03/assets/144196049/b2f6f1cc-a792-430b-af07-34fafd1bee7c">

string s1 = new string("Hello, World!");: นี่คือการสร้าง object ของ string โดยใช้คำสั่ง new ซึ่งจะสร้าง object ใหม่และจัดสรรพื้นที่ในหน่วยความจำให้กับ string ที่มีค่าเป็น "Hello, World!" และทำการเก็บ reference ของ object นั้นไว้ในตัวแปร s1.

string s2 = "Hello, World!";: นี่คือการสร้าง string literal โดยใช้คำสั่ง = โดยตรงโดยไม่ต้องใช้ new หรือการจองพื้นที่ในหน่วยความจำ ในกรณีนี้ string literal "Hello, World!" จะถูกจัดเก็บใน memory pool และ reference ของ string นี้จะถูกกำหนดให้กับตัวแปร s2.

var s3 = "Hello, World!";: นี่คือการประกาศตัวแปรโดยไม่ระบุชนิดของตัวแปร (implicit typing) แต่กำหนดค่าให้เป็น string literal "Hello, World!" ในกรณีนี้ตัวแปร s3 จะถูกตั้งค่าเป็น string โดยอัตโนมัติจากค่าที่กำหนดให้ ซึ่งเป็นการใช้ string literal เช่นเดียวกับข้อ 2.

string s4 = new("Hello, World!");: นี่คือรูปแบบย่อของการสร้าง object ของ string ด้วยการใช้ constructor ที่เรียกว่า "C# 9.0 Target-typed new" ซึ่งมีให้ใช้ตั้งแต่ C# เวอร์ชัน 9.0 เป็นต้นมา โดยไม่ต้องระบุชนิดของตัวแปรและไม่ต้องใช้ new อีกต่อไป แต่ค่าที่กำหนดให้จะถูกสร้างเป็น object ใหม่ทุกครั้งที่โค้ดถูกเรียกใช้งาน
