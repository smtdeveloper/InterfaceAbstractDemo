# InterfaceAbstractDemo

Nero ve Starbucks için müşteri kaydetme ve Starbucks için mernis ile doğrulama projesi 
<br>
C# - Angular kampı


# Linkler

https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL

https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?op=TCKimlikNoDogrula

# T.C. Kimlik Numarası Doğrulama - XML Web Servisi

servis referansını projemize eklemeye…

T.C. İçişleri Bakanlığı Nüfus ve Vatandaşlık İşleri Genel Müdürlüğü tarafından kullanıma sunulan web servisinin adresini aşağıda bulabilirsiniz.

https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx

DİKKAT: KPS Servisi yalnızca SSL (https adresi) üzerinden hizmet veriyor.

Bu servisi proje içerisinde kullanabilmek için öncelikle Solution Explorer içerisinde yer alan References alanına sağ tıklayalım ve Add Service Reference… seçeneğini seçelim.

![image_thumb 6](https://user-images.githubusercontent.com/74311713/129731311-0f79d6f4-bed7-4ab2-9a51-5dcea45e674f.png)

Açılan ekranda Address bölümüne servisin WSDL dosyasının adresini(https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL) verelim, Namespace bilgisi olarak “Kimlik” kullanalım ve GO butonuna tıklayıp, servisin Services bölümünde listelenmesini sağlayalım.
 
![image_thumb 8](https://user-images.githubusercontent.com/74311713/129731387-e578c42e-33ca-4313-ae42-46e601edbd12.png)

Bu işlemlerin ardından OK butonuna tıklayarak servis referansının projeye eklenme sürecini tamamlayalım.

## ÖNEMLİ NOT:  
<br>
Servise doğrulama için gönderilecek ad ve soyad bilgileri tamamen büyük harflerle yazılmış olarak gönderilmelidir.

