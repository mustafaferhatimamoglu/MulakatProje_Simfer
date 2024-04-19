# MulakatProje_Simfer

SQL
-Birey Bilgileri i�in TBL_PERSON tablosu olu�turuldu
>Her aile bireyinin ba�l� oldu�u bir �st ki�i olacakt�r (ast �st parent child)
>>FID_PX (Foreign ID _ Parent X(Male-Female) 
>>T�m aile bireyleri i�in m�mk�n olmad��� i�in NULL kabul edilebilir �ekilde b�rak�ld�

-E�itim bilgileri i�in TBL_EDUCATION tablosu olu�turuldu
>Her aile bireyinin e�itim durumlar�n� farkl� bir tablo �zerinden y�netiyor olacaks�n�z.
>> C�mle her aile bireyi i�in farkl� tablo talep ediliyor. Bu yap�lmad� ve tek tablo �zerinden i�lem yap�ld�
>> FID ile Person tablosuna ba�land� ve Foreign Key eklendi

-Son mezun olunan okulu kay�t alt�na almak i�in TBL_EDUCATION_PH 
>Her aile bireyinin en son mezun oldu�u okul farkl� bir tablo �zerinden y�netiyor olacaks�n�z.
>>TBL_EDUCATION tablosuna trigger olu�turularak bireye yeni okul girilmesi durumunda otomatik g�ncellenecek
>Yukar�daki okul durumuna ba�l� �al��ma yerleri �eklinde zaman damgal� (buradaki zaman damgas� g�n baz�nda) olacak �ekilde kaydedilmesini istemekteyim.
>> Tabloya ElapsedDay kolonu eklenerek son mezun olunan okuldan g�n�m�ze ge�en g�n say�s�n�n kaydedilmesi sa�land�.
>> trigger g�ncellenerek g�n say�s�n� otomatik olu�turmas� sa�land�
>> G�nl�k �al��an Job eklenerek tablodaki ElapsedDay kolonu 1 artt�r�ld�

Genel
>Mezun olunan okullar�n farkl� �ehirde olmas� gerekmektedir.
>> okul isimleri (a1-a25) ve �ehirleri (b1-b25) olarak atand�

Aray�z
2 adet Form tasarland� 
-Form_Person Bireyler aras�nda ge�i� ve genel aile yap�s�n� g�rmek amac�yla, okullar�n sadece isimlerinin oldu�u bir Listbox ile
--Aray�z�n responsive olmas� tasarland�
-Form_Education
--E�itim bilgisi ekleyebilecek �ekilde tasarland�

