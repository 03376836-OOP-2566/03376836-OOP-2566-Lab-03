<img width="960" alt="image" src="https://github.com/Phetteepop/03376836-OOP-2566-Lab-03/assets/144197367/0118ac1a-0af8-4d36-a1ab-a7fda7bc6267">

### อธิบาย ###

```
ตัวอย่างที่ 1: การใช้เครื่องหมายแบ็กสแลชในเส้นทางไฟล์
filepath ใช้แบ็กสแลชคู่ (\\) เพื่อระบุเส้นทางไฟล์ เพราะใน string ทั่วไป แบ็กสแลชเดี่ยว (\) ใช้เป็น escape sequence ที่ต้องหลบหลีก
Verbatim_filepath ใช้ verbatim string (ขึ้นต้นด้วย @) ซึ่งไม่ต้องหลบหลีกแบ็กสแลช จึงสามารถเขียนเส้นทางไฟล์แบบตรงไปตรงมาได้

ตัวอย่างที่ 2: การสร้างข้อความหลายบรรทัด
multi_line_text ใช้ escape sequence \n เพื่อขึ้นบรรทัดใหม่ใน string ปกติ
verbatim_multi_line_text เป็น verbatim string จึงสามารถขึ้นบรรทัดใหม่ได้โดยตรงโดยไม่ต้องใช้ \n

ตัวอย่างที่ 3: การใช้เครื่องหมายคำพูดคู่ในข้อความ
quote_in_text ใช้ escape sequence \" เพื่อใส่เครื่องหมายคำพูดคู่ (") ภายใน string ปกติ
quote_in_verbatim_text เป็น verbatim string จึงสามารถใส่เครื่องหมายคำพูดคู่ได้โดยตรงโดยไม่ต้องหลบหลีก
```
