```cs
using System;
string s1 = new string("Hello, World!");
string s2 = "Hello, World!";
var s3 = "Hello, World!";
string s4 = new("Hello, World!");
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
```

![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/a505dd5f-a8cd-4b17-8335-98ac73bcc0a2)

![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-03/assets/144196505/a4844668-9f5a-48c9-ae0a-67f6db5695fb)

### อธิบายโปรแกรม

- `string s1 = new string("Hello, World!");` เป็นการสร้าง object ของ string โดย operator `new` แล้วนำมาเก็บไว้ใน reference `s1`
- `string s2 = "Hello, World!";` เป็น quoted string literal
- `var s3 = "Hello, World!";`  เป็น local variable string literal
- `string s4 = new("Hello, World!");` เป็นรูปแบบย่อของ `string s1 = new string("Hello, World!");`

### อธิบายผลโปรแกรม

โปรแกรมจะแสดงผล Hello, World! 4 คำ
