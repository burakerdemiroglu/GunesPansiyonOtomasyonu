# Güneş Pansiyon Uygulaması

Bu proje, C# programlama dili ve .NET Framework 4.6.1 kullanılarak geliştirilen bir pansiyon kayıt uygulamasını içermektedir. Güneş Pansiyon Uygulaması, pansiyon yöneticilerine müşteri kaydı, rezervasyon yönetimi, oda durumu takibi, gelir-gider hesaplamaları ve diğer pansiyon işlemlerini kolaylıkla yapabilme imkanı sunar.

## Özellikler

- Admin girişi ve yetkilendirme sistemi
- Yeni müşteri kaydı oluşturma ve mevcut müşteri bilgilerini güncelleme
- Müşteri rezervasyonlarını yönetme ve oda durumu takibi
- Ünlü gazetelerin web tarayıcısı üzerinden okunabilmesi
- Mesaj bırakma ve resepsiyon mesajlarını görüntüleme
- Gelir ve gider hesaplamaları, personel maaşları, kasa takibi
- Radyo kanallarını dinleme imkanı
- Mutfak stokları, faturalar ve diğer giderlerin kaydedilmesi

## Gereksinimler

- .NET Framework 4.6.1
- Visual Studio (2019 veya daha yeni bir sürümü)

## Kurulum

1. Bu projeyi GitHub'dan veya Git aracılığıyla klonlayın.
2. Visual Studio'yu açın.
3. Proje dosyasını Visual Studio'da açın.
4. Projeyi derleyin ve çalıştırın.

## Kullanım

1. Uygulama başlatıldığında, admin giriş ekranı karşınıza gelecektir.
2. Doğru kullanıcı adı ve şifre ile giriş yaparak ana forma erişim sağlayın.
3. Ana form üzerinden istediğiniz özellikleri seçerek uygulamayı kullanmaya başlayın.
4. Yeni müşteri kaydı oluşturabilir, müşteri bilgilerini güncelleyebilirsiniz.
5. Rezervasyonları yönetebilir, oda durumlarını takip edebilirsiniz.
6. Gazeteleri okuyabilir, mesaj bırakabilirsiniz.
7. Gelir ve gider hesaplamalarını yapabilir, radyo kanallarını dinleyebilirsiniz.
8. Mutfak stoklarını, faturaları ve diğer giderleri kaydedebilirsiniz.

## Form Açıklamaları

- FrmAdminGiris:
Bu form, admin kullanıcılarının giriş yapabileceği bir ekranı temsil eder. Kullanıcı adı ve şifre alanlarına admin kimlik bilgileri girilerek giriş yapılabilir.

- FrmAnaForm:
   Bu form, diğer formlara erişebileceğiniz ana bir formdur. Yeni Müşteri, Odalar ve Şifre Güncelleme gibi farklı formlara bu formdan erişebilirsiniz.

- FrmGazeteler:
   Bu form, ünlü gazetelerin web tarayıcısı üzerinden görüntülenebileceği bir formdur. WebBrowser kontrolü kullanılarak gazete yayınlarına erişim sağlanır.

- FrmGelirGider:
   Bu form, personel maaşları, kasadaki toplam tutar, alınan ürünlerin tutarı, faturalar gibi gelir ve gider hesaplamalarının yapıldığı bir formdur. Faturalar ve Stoklar tabloları üzerinden işlemler gerçekleştirilir.

- FrmMesajlar:
   Bu form, resepsiyona bırakılan öneri, istek gibi mesajların görüntülendiği bir formdur. Mesajlar tablosu ile ilişkilidir.

- FrmMusteriler:
   Bu form, müşteri bilgilerinin güncellendiği ve silindiği bir formdur. İsme göre arama yapılabilen bir liste görünümü içerir. MüsteriEkle tablosu ile ilişkilidir.

- FrmOdalar:
   Bu form, pansiyondaki oda sayısı ve doluluk durumlarının görüntülendiği bir formdur. 9 oda bulunur ve her biri ayrı tabloda tutulur.

- FrmRadyoDinle:
   Bu form, ünlü radyo kanallarının dinlenebileceği bir formdur. AxWindowsMediaPlayer nesnesi kullanılarak radyo yayınlarına erişim sağlanır.

- FrmSifreGuncelle:
Bu form, müşterilerin şifre güncellemelerinin yapıldığı bir formdur. MüsteriEkle tablosu ile ilişkilidir.

- FrmStoklar:
Bu form, mutfak stokları, faturalar ve diğer giderlerin kaydedildiği bir formdur. Listview kontrolü kullanılarak giderler eklenir. Stoklar tablosu ile ilişkilidir.

### FrmYeniMusteri:
Bu form, yeni müşteri kayıtlarının oluşturulduğu ve oda bilgilerinin kaydedildiği bir formdur. MüsteriEkle ve İlgili odalar tabloları ile ilişkilidir.


## SQL Tabloları

### MusteriEkle Tablosu

MusteriEkle tablosu, müşterilerin bilgilerini tutmak için kullanılan bir tablodur. Aşağıda tablonun tasarımı ve alanlarının açıklamaları yer almaktadır:

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| MusteriId   | int          | 𝤿 |
| Adi         | varchar(20)  | ☑ |
| Soyadi      | varchar(50)  | ☑ |
| Cinsiyet    | varchar(5)   | ☑ |
| Telefon     | varchar(15)  | ☑ |
| Mail        | varchar(50)  | ☑ |
| TC          | varchar(12)  | ☑ |
| OdaNo       | varchar(5)   | ☑ |
| Ucret       | int          | ☑ |
| GirisTarihi | date         | ☑ |
| CikisTarihi | date         | ☑ |

Bu tablo, müşteri kayıtlarının tutulduğu bir tablodur. Her bir alanın anlamı ve veri türü açıklamaları yukarıda belirtilmiştir. Tablo, MusteriId alanıyla benzersiz bir kimlik sağlamaktadır. Müşteriye ait bilgilerin güncellenmesi, arama yapılması ve raporlama gibi işlemler bu tablo üzerinden gerçekleştirilebilir.

### Faturalar Tablosu

Faturalar tablosu, elektrik, su ve internet gibi hizmetlere ait fatura bilgilerini tutmak için kullanılan bir tablodur. Aşağıda tablonun tasarımı ve alanlarının açıklamaları yer almaktadır:

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| Elektrik    | int          | ☑ |
| Su          | int          | ☑ |
| Internet    | int          | ☑ |

Bu tablo, elektrik, su ve internet hizmetlerine ait fatura bilgilerini içermektedir. Elektrik, su ve internet alanları, ilgili hizmetlere ait fatura miktarlarını tutmaktadır. Tabloda, Elektrik ve Su alanlarına izin verilen null değerleri kullanılabilirken, Internet alanı null değerlere izin vermemektedir. Bu tablo üzerinden fatura bilgilerine erişim sağlanabilir ve ilgili hizmetlerin mali durumu takip edilebilir.

### Mesajlar Tablosu

Mesajlar tablosu, resepsiyona bırakılan öneri, istek veya mesaj gibi iletilerin tutulduğu bir tablodur. Aşağıda tablonun tasarımı ve alanlarının açıklamaları yer almaktadır:

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| MesajId     | int          | 𝤿 |
| AdiSoyad    | varchar(50)  | ☑ |
| Mesaj       | varchar(1500)  | ☑ |

Bu tablo, resepsiyona iletilen öneri, istek veya mesaj gibi iletilerin kaydedildiği bir tablodur. Her bir alanın anlamı ve veri türü açıklamaları yukarıda belirtilmiştir. Tabloda, MesajId alanı benzersiz bir kimlik sağlamaktadır. İletilerin kaydı ve takibi bu tablo üzerinden gerçekleştirilebilir. Mesajlar, ilgili müşteri veya personel tarafından bırakılan iletilerin bilgilerini içermektedir.

### AdminGiris Tablosu

AdminGiris tablosu, admin kullanıcılarının giriş bilgilerini tutmak için kullanılan bir tablodur. Aşağıda tablonun tasarımı ve alanlarının açıklamaları yer almaktadır:

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| Kullanici   | varchar(20)  | ☑ |
| Sifre       | varchar(20)  | ☑ |

Bu tablo, admin kullanıcılarının giriş bilgilerini içermektedir. Kullanici alanı, admin kullanıcısının kullanıcı adını tutar. Sifre alanı ise admin kullanıcısının şifresini tutar. Tablo üzerinden admin kullanıcılarının giriş işlemleri doğrulanabilir ve yetkilendirme kontrolleri gerçekleştirilebilir. Tabloda, her bir kullanıcının benzersiz bir kimliği sağlanmalıdır.

### Stoklar Tablosu

Stoklar tablosu, mutfakta bulunan gıda, içecek ve atıştırmalık gibi ürünlerin stok bilgilerini tutmak için kullanılan bir tablodur. Aşağıda tablonun tasarımı ve alanlarının açıklamaları yer almaktadır:

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| Gida        | int          | ☑ |
| Icecek      | int          | ☑ |
| Cerezler    | int          | ☑ |

Bu tablo, mutfaktaki gıda, içecek ve atıştırmalık gibi ürünlere ait stok bilgilerini içermektedir. Gida, Icecek ve Cerezler alanları, ilgili ürünlerin stok miktarlarını tutmaktadır. Tablo üzerinden stok durumu takip edilebilir, ürün siparişleri ve stok güncellemeleri gerçekleştirilebilir. Tabloda, her bir ürünün stok miktarı ayrı ayrı kaydedilir.

### Oda Tabloları

Oda tabloları, pansiyonda bulunan her bir oda için ayrı ayrı oluşturulmuş tablolardır. Her oda için ayrı bir tablo tasarımı bulunmaktadır. Aşağıda her bir oda tablosunun tasarımı ve alanlarının açıklamaları yer almaktadır:

#### Oda1

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| Adi         | varchar(50)  | ☑ |
| Soyadi      | varchar(50)  | ☑ |

#### Oda2

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| Adi         | varchar(50)  | ☑ |
| Soyadi      | varchar(50)  | ☑ |

...

#### Oda9

| Column Name | Data Type    | Allow Nulls       |
| ----------- | ------------ | --------- |
| Adi         | varchar(50)  | ☑ |
| Soyadi      | varchar(50)  | ☑ |

Her bir oda tablosu, ilgili odadaki müşterilerin adı ve soyadını tutmaktadır. Adi ve Soyadi alanları, oda sahibi müşterinin bilgilerini içermektedir. Her oda tablosu ayrı ayrı müşteri kayıtlarını tutar. Müşteri bilgileri güncellenmesi, oda boşaltılması veya müşteri değişikliği gibi işlemler oda tabloları üzerinden gerçekleştirilebilir.

