# _Kelime_ _Oyunu_

Ali İhsan Varol'un sunduğu Teve2 de yayınlanan Kelime Oyunu Yarışmasının .NET FRAMEWORK Masaüstü Uygulaması
C# Programlama dili ile Visual Studio da hazırlanmıştır.
Veritabanı Olarak MySQL Kullanılmıştır.

## _Kurulum_

    KelimeOyunuDb.sql dosyası MySQL Workbenchde çalıştırılır
    Proje içinde bulunan baglanti() metodu içinde user ve pwd kendi Mysql kullanıcınız ve şifreniz olarak değiştirilir
    Proje çalıştırılır
    
## _Tasarım_

 Oyunun anasayfasında kullanıcı adının girileceği bir textbox ve sol tarafta anasayfa, kurallar, en iyi oyuncular ve veritabanına soru ekleme bölümlerinden oluşan bir menü vardır 
 
 ![image](https://user-images.githubusercontent.com/71495532/113904935-43705780-97db-11eb-9273-61dcbf0fe825.png)
 ![image](https://user-images.githubusercontent.com/71495532/113904939-45d2b180-97db-11eb-93e2-18f5d5b8a75e.png)
 ![image](https://user-images.githubusercontent.com/71495532/113904950-49663880-97db-11eb-8941-dfb50a74cb1b.png)
 ![image](https://user-images.githubusercontent.com/71495532/113904962-4d925600-97db-11eb-82d1-4f4537cb2880.png) 

## _Oyunu_ _Oynama_

Başla butonuna basılarak 4 dakikalık süre başlar. Sırasıyla sorular gelir. Cevapla butonu ile soru cevaplanır.Kelimeyi tahmin edemiyorak harf al butonundan harf alınabilir.Soruyu cevaplaya bastıktan sonra 20 saniyelik bir süre başlar ve harf alma pasif hale gelir.

![image](https://user-images.githubusercontent.com/71495532/113905123-7ca8c780-97db-11eb-84bc-1e50ce3983d5.png)
![image](https://user-images.githubusercontent.com/71495532/113905229-98ac6900-97db-11eb-8746-3977dd39679a.png)


