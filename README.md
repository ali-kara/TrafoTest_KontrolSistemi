## Developed in 2017 ## 

<b>Projede;</b>
 * C# Windows Form dili ile geliştirilmiştir.
 * Veritabanı olarak MSSQL Server tercih edilmiştir.
 * ORM olarak Entity Framework kullanılmıştır.
 * Herhangi bir üçüncü parti kontrol kullanılmamıştır.


Trafo Sistemlerinin Test işlemlerini yapan makinelerin çalışma sürecinde sürecinde kullanılmak üzere geliştirilmiş bir kontrol - raporlama yazılımıdır.

Bu yazılım aracılığıyla test makinelerinin başlatılması, bitirilmesi, durdurulması ve diğer özelliklerinin kullanılması amacıyla gerekli komutlar TCP-IP üzerinden PLC'ye gönderilmektedir.

Sistem 4 adet makineyi aynı anda desteklemektedir.

İşlem başlatıldığı zaman raporlama maksatlı makinelerin anlık sensör verileri kaydedilir ve makinenin hata durumuna geçmesi durumunda alarm altyapısı sayesinde ilgli kişilere mail atılır.

İşlemler gerçek zamanlı olarak kaydedilebilmektedir. Anlık olarak her bir makieneye ait veriler grafiksel gösterim sağlamaktadır. Geçmiş işlemlere ait verileri raporlama modülü sayesinde çıktı olarak alınabilmektedir.

Test süreç proses adımlarını tanımlama imkanı bulunmaktadır.

Manuel kontroller sayesinde direk makinelere komut gönderme yeteneği bulunmaktadır.

Veritabanı yedekleme ve yükleme özelliği ile istenilen zamanki verilere erişelebilmektedir.


 
![Genel Ekran](https://user-images.githubusercontent.com/99508918/186651876-ca20508a-8213-46e0-b600-0daa59651cee.png)
![Trafo-IslemBasladi](https://user-images.githubusercontent.com/99508918/186651883-5b1d02d9-05dd-466d-aa1e-9664a89c2329.png)
![Islem Devam Ediyor](https://user-images.githubusercontent.com/99508918/186651894-d322e8ab-d815-4519-ac4f-f71868bb67f6.png)
![Araclar Penceresi](https://user-images.githubusercontent.com/99508918/186651903-c3dc819d-c12b-4d56-b1cd-5e32d2d1b2c0.png)
![Raporlar Penceresi](https://user-images.githubusercontent.com/99508918/186651915-515e306f-5673-4c0d-8cf0-4fc27a9e4f27.png)
