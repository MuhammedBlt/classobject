// See https://aka.ms/new-console-template for more information
using BenthanysPieShopHRM;

Console.WriteLine("Creating an employee!");
Console.WriteLine("--------/n");


Employee bethany = new Employee("Bethany", "Smith", "bmail", new DateTime(1979, 1, 16), 25);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(5);
Employee testEmployee = bethany;
testEmployee.firstName = "Gill";

bethany.DisplayEmployeeDetails();
testEmployee.DisplayEmployeeDetails();

//int a=33 int b=32 AddTwoNumbers(a,ref b);

// yaptigimizda a'nin kopyasi uzerinde calisir b'nin kendisi uzerinde calisir

// out da ayni gorevi goruyor out baslangic degeri girmeden de calisabiliyor

/*
Stringbuilder kuillanmamizimn sebebi performans nesnenin bi kopyasi uzerinde

calismiyor direkt kendi uzerinde calisiyor 

StringBuilder sb = new StringBuilder(); nesnesini olusturmamiz lazim 

Append: Metin ekler. Örneğin, sb.Append("Merhaba").
AppendLine: Metin ekler ve bir satır sonu karakteri ekler.
Insert: Belirli bir konuma metin ekler.
Remove: Belirli bir konumdan itibaren belirli bir uzunluktaki metni kaldırır.
Replace: Belirli bir metni başka bir metinle değiştirir.
ToString: StringBuilder içindeki metni string türünde döndürür.
Clear: StringBuilder içindeki tüm metni temizler.


Value type= Enumerations and structs
Reference Types = classes Interfaces Delegates */



/* Enumeration = numaralandirma employee kisminda ornek var
 * 
 CREATING A STRUCT

--ozel veri yapilarini gosterir
-- value tipindedir
== method veya diger yapilari icerebilir
