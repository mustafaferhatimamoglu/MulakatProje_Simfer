# MulakatProje_Simfer

SQL
-Birey Bilgileri için TBL_PERSON tablosu oluþturuldu
>Her aile bireyinin baðlý olduðu bir üst kiþi olacaktýr (ast üst parent child)
>>FID_PX (Foreign ID _ Parent X(Male-Female) 
>>Tüm aile bireyleri için mümkün olmadýðý için NULL kabul edilebilir þekilde býrakýldý

-Eðitim bilgileri için TBL_EDUCATION tablosu oluþturuldu
>Her aile bireyinin eðitim durumlarýný farklý bir tablo üzerinden yönetiyor olacaksýnýz.
>> Cümle her aile bireyi için farklý tablo talep ediliyor. Bu yapýlmadý ve tek tablo üzerinden iþlem yapýldý
>> FID ile Person tablosuna baðlandý ve Foreign Key eklendi

-Son mezun olunan okulu kayýt altýna almak için TBL_EDUCATION_PH 
>Her aile bireyinin en son mezun olduðu okul farklý bir tablo üzerinden yönetiyor olacaksýnýz.
>>TBL_EDUCATION tablosuna trigger oluþturularak bireye yeni okul girilmesi durumunda otomatik güncellenecek
>Yukarýdaki okul durumuna baðlý çalýþma yerleri þeklinde zaman damgalý (buradaki zaman damgasý gün bazýnda) olacak þekilde kaydedilmesini istemekteyim.
>> Tabloya ElapsedDay kolonu eklenerek son mezun olunan okuldan günümüze geçen gün sayýsýnýn kaydedilmesi saðlandý.
>> trigger gðncellenerek gün sayýsýný otomatik oluþturmasý saðlandý
>> Günlük çalýþan Job eklenerek tablodaki ElapsedDay kolonu 1 arttýrýldý

Genel
>Mezun olunan okullarýn farklý þehirde olmasý gerekmektedir.
>> okul isimleri (a1-a25) ve þehirleri (b1-b25) olarak atandý

Arayüz
2 adet Form tasarlandý 
-Form_Person Bireyler arasýnda geçiþ ve genel aile yapýsýný görmek amacýyla, okullarýn sadece isimlerinin olduðu bir Listbox ile
--Arayüzün responsive olmasý tasarlandý
-Form_Education
--Eðitim bilgisi ekleyebilecek þekilde tasarlandý

