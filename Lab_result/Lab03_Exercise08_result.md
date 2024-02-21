![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/270a7417-28dc-4307-9ffe-ceab1296f496)

![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/f2b1c4df-9c56-48b6-9600-b681fd0f5d99)

### อธิบายโปรแกรม
- ตัวแปร nullStr ถูกใช้ในการเชื่อมต่อ (concatenate) กับ string str ในตัวแปร tempStr(nullStr มีค่า null)
- เปรียบเทียบ emptyStr และ nullStr จะได้ผลลัพธ์เป็น false เพราะ emptyStr ไม่เท่ากับ nullStr
- สร้าง string ใหม่จาก emptyStr และ nullStr จะได้ string ที่มีความยาวเท่ากับ emptyStr (ซึ่งเป็น string ว่าง)
- ในกรณีที่มีการเรียก nullStr.Length ทำให้เกิด System.NullReferenceException เนื่องจาก nullStr มีค่าเป็น null และไม่สามารถเรียก property Length ได้
- อักขระ null (\x0) จะถูกเชื่อมต่อไปกับ string ปกติได้ แต่ไม่แสดงผลบนหน้าจอภาพ แต่ความยาวของ string จะถูกนับรวมกับอักขระ null
- ในกรณีของ s1 จะได้ "abc" ตามตัวอักษรปกติที่ถูกเชื่อมต่อกับ \x0 ซึ่งมีความยาวเท่ากับ 4 (3 ตัวอักษร + 1 อักขระ null)
- ในกรณีของ s2 จะได้ "abc" ตามตัวอักษรปกติที่ถูกเชื่อมต่อกับ \x0 ซึ่งมีความยาวเท่ากับ 4 เหมือนกัน

### อธิบายผลลัพธ์โปรแกรม
- โปรแกรมนี้ทำการสร้างและทดสอบตัวแปร string และการทำงานกับตัวแปรที่มีค่า null ต่าง ๆ
