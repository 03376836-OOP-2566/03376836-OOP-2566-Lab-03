# โปรแกรม 1
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/0b875715-10c3-4c52-a435-fd84e94dcba1)

![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/d8ae4811-2080-4d5a-bde2-f69b7e9dd10c)

# โปรแกรม 2
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/9205e6c0-8d95-4801-b6ff-f90fed24ede7)

![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/e849597f-3abd-4209-a874-4ba60acac1dc)

### อธิบายโปรแกรม
### โปรแกรม 1
- เมื่อ StringBuilder ถูกสร้างขึ้น("Rat is my favorite animal.") hash code ของ StringBuilder จะถูกคำนวณ
- หลังจากนั้น, การเปลี่ยนแปลงอักขระที่ index 0 จาก 'R' เป็น 'C' จะไม่สร้าง StringBuilder ใหม่ แต่จะแก้ไขค่าในตำแหน่งที่ระบุใน StringBuilder โดยตรง
- หลังจากการเปลี่ยนแปลง, StringBuilder และ hash code จะแสดงผลลัพธ์ใหม่ที่ตรงกับการเปลี่ยนแปลงที่ได้ทำ

### โปรแกรม 2
- `var sb = new System.Text.StringBuilder();`สร้าง StringBuilder ใหม่
- `for (int i = 0; i < 10; i++)` ทำการวนลูป 10 รอบ (i = 0 ถึง 9)
- `System.Console.Write ($"Loop {i+1, 2} : ");` แสดงผลลัพธ์บน Console โดยแสดงหมายเลขลูป (i+1) เป็นการจัด format ให้เป็นตัวเลข 2 หลัก
- `sb.Append(i.ToString());`เพิ่มตัวเลข i เข้าไปใน StringBuilder
- `System.Console.WriteLine($"sb = {sb.ToString(),-11}, sb.GetHashCode() = {sb.GetHashCode()}");`แสดง string ที่ได้จาก StringBuilder และ hash code ปัจจุบันของ StringBuilder
- `Console.WriteLine($"Finally : sb = {sb}");` จะแสดง string ทั้งหมดที่ได้จาก StringBuilder.

### อธิบายผลโปรแกรม
### โปรแกรม 1
- จะแสดง StringBuilder ก่อนและหลังการเปลี่ยนแปลง พร้อมกับ hash code ปัจจุบันของ StringBuilder

### โปรแกรม 2
- Console จะแสดง string ที่เพิ่มขึ้นทีละตัวเลขจาก 0-9 ในแต่ละรอบของ loop พร้อมกับ hash code ปัจจุบันของ StringBuilder
