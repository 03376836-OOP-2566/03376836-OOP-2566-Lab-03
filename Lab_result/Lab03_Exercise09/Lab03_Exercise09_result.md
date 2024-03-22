# Exercise 9.1
![Ex9 1](https://github.com/65030179179Pattarapon/03376836-OOP-2566-Lab-03/assets/144198506/ff3ae7ac-e7e1-482f-ad0f-8ef1a84580ee)
#
โค้ดนี้ใช้ StringBuilder เพื่อสร้าง string "Rat is my favorite animal." และแสดงค่า hashcode ของ StringBuilder ก่อนและหลังการเปลี่ยนแปลงตัวอักษรแรกจาก 'R' เป็น 'C' ดังนี้ :

1. สร้าง StringBuilder ด้วยข้อความ "Rat is my favorite animal."
2. แสดงข้อความและ hashcode ก่อนการเปลี่ยนแปลง
3. เปลี่ยนตัวอักษรแรกของ StringBuilder จาก 'R' เป็น 'C'
4. แสดงข้อความและ hashcode หลังการเปลี่ยนแปลง

#### ก่อนการเปลี่ยนแปลง :

• sb = Rat is my favorite animal.,

• sb.GetHashCode = [hashcode]

#### หลังการเปลี่ยนแปลง:

• sb = Cat is my favorite animal.,
• sb.GetHashCode = [hashcode ใหม่]
#

# Exercise 9.2
![Ex9 2](https://github.com/65030179179Pattarapon/03376836-OOP-2566-Lab-03/assets/144198506/2c1168f4-2968-4d29-a02f-1a539860e090)
#

โค้ดนี้สร้าง StringBuilder และเพิ่มตัวเลข 0-9 เข้าไปใน StringBuilder ในแต่ละรอบของลูป แสดง string ที่เพิ่มเข้าไปในแต่ละรอบพร้อมกับ hashcode ของ StringBuilder ด้วย และในที่สุดแสดง string ทั้งหมดที่อยู่ใน StringBuilder ด้วย ดังนี้ :

1. สร้าง StringBuilder ว่าง
2. ในแต่ละรอบของลูป:

   • เพิ่มตัวเลข i เข้าไปใน StringBuilder

   • แสดง string ที่เพิ่มเข้าไปพร้อมกับ hashcode ของ StringBuilder ในขณะนั้น

3. แสดง string ทั้งหมดที่อยู่ใน StringBuilder หลังจากการวนลูปเสร็จสิ้น

#### ผลลัพธ์ :

• ในแต่ละรอบของลูปจะมีการเพิ่มตัวเลข i เข้าไปใน StringBuilder และแสดง string ที่เพิ่มเข้าไปพร้อมกับ hashcode ของ StringBuilder ในขณะนั้น

• หลังจากการวนลูปเสร็จสิ้น จะแสดง string ทั้งหมดที่อยู่ใน StringBuilder
