# ✈️ TravelTrip — Kişisel Seyahat Blog Platformu

> **ASP.NET MVC5** mimarisiyle geliştirilmiş, dinamik içerik yönetimli Türkçe seyahat blogu.  
> Oteller, restoranlar, müzeler, uçuşlar ve araba kiralama kategorilerinde rehber içerikler sunar.

<br>

![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_MVC5-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![Somee](https://img.shields.io/badge/Hosted-Somee.com-0078D4?style=for-the-badge)

---

## 🌍 Canlı Demo

🔗 **[traveltrip.somee.com](http://traveltrip.somee.com/Default/Index/)**

---

## 📖 Proje Hakkında

**TravelTrip**, teknoloji ve keşif tutkusunun birleştiği kişisel bir seyahat platformudur. Sıradan bir blog olmaktan öte; Türkiye'nin saklı köylerinden dünyanın ikonik şehirlerine uzanan rotaları, seyahat deneyimlerini ve pratik ipuçlarını okuyucuyla buluşturmak için tasarlanmıştır.

Proje, sıfırdan **ASP.NET MVC5 mimarisiyle** kurgulanmış; her controller, her view ve her model bizzat yazılmıştır. Hem teknik bir portföy çalışması hem de canlı ve işlevsel bir içerik platformu olarak hizmet vermektedir.

---

## ✨ Özellikler

| Özellik | Açıklama |
|---|---|
| 📝 **Blog Yönetimi** | Dinamik blog yazısı oluşturma, listeleme ve detay görüntüleme |
| 🗺️ **Rehber Kategorileri** | Oteller, Restoranlar, Müzeler — kategoriye göre filtreleme |
| ✈️ **Uçuş & Araç Kiralama** | Seyahat hizmeti bilgi sayfaları |
| 📊 **Popüler İçerik** | En çok okunan 10 blog otomatik sıralanır |
| 📱 **Responsive Tasarım** | Mobil uyumlu, Bootstrap tabanlı arayüz |
| 🖼️ **Görsel Yönetimi** | Blog başlık görselleri ve galeri desteği |
| 🔍 **SEO Dostu URL** | `/Blog/BlogDetay/{id}` formatında temiz URL yapısı |
| 📞 **İletişim** | WhatsApp entegrasyonu ve iletişim formu |

---

## 🛠️ Teknoloji Yığını

```
Backend      →  ASP.NET MVC 5 (C#)
ORM          →  Entity Framework  
Veritabanı   →  Microsoft SQL Server
Frontend     →  HTML5, CSS3, Bootstrap, jQuery
Template     →  W3Layouts Easy-Trip (özelleştirilmiş)
Hosting      →  Somee.com (Windows Hosting / IIS)
```

---

## 🗂️ Proje Yapısı

```
TravelTrip/
│
├── Controllers/
│   ├── DefaultController.cs      # Ana sayfa
│   ├── AboutController.cs        # Hakkımızda
│   └── BlogController.cs         # Blog listesi & detay
│
├── Models/
│   ├── Blog.cs                   # Blog entity
│   └── TravelDbContext.cs        # EF DbContext
│
├── Views/
│   ├── Default/
│   │   └── Index.cshtml          # Ana sayfa view
│   ├── About/
│   │   └── Index.cshtml
│   └── Blog/
│       ├── Index.cshtml          # Blog listesi
│       └── BlogDetay.cshtml      # Blog detay sayfası
│
├── web/
│   ├── images/                   # Site görselleri
│   └── css/                      # Stil dosyaları
│
├── Web.config
└── README.md
```

---

## 🚀 Kurulum & Çalıştırma

### Gereksinimler

- Visual Studio 2019 veya üzeri
- .NET Framework 4.x
- SQL Server (LocalDB veya Express)
- IIS Express (VS ile birlikte gelir)

### Adımlar

```bash
# 1. Repoyu klonla
git clone https://github.com/KULLANICI_ADI/TravelTrip.git

# 2. Visual Studio'da çözümü aç
TravelTrip.sln

# 3. Web.config dosyasında bağlantı dizesini güncelle
# <connectionStrings> → SQL Server adresinizi girin

# 4. Package Manager Console'da migration uygula
Update-Database

# 5. Projeyi çalıştır
F5 veya IIS Express
```

### Veritabanı Bağlantısı (`Web.config`)

```xml
<connectionStrings>
  <add name="TravelDbContext"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=TravelTripDB;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

> 💡 Yedek veritabanı dosyası: `TravelData.bak` — SQL Server Management Studio ile geri yükleyebilirsiniz.

---

## 📸 Ekran Görüntüleri

> *(Görseller eklenecek — `/docs/screenshots/` klasörüne yükleyip aşağıdaki linkleri güncelleyin)*

| Ana Sayfa | Blog Listesi | Blog Detay |
|---|---|---|
| ![Home](docs/screenshots/home.png) | ![Blog](docs/screenshots/blog-list.png) | ![Detail](docs/screenshots/blog-detail.png) |

---

## 📝 İçerik Kategorileri

**Şu ana kadar yayınlanan rotalar:**

- 🕌 Sultanahmet Meydanı — İstanbul, Türkiye
- ⚓ Çanakkale'de Bir Sabah — Türkiye  
- 🗼 Paris'te Bir Gece — Fransa
- 🌉 Hong Kong Gökdelen Ormanı — Çin
- 🌸 Kyoto'da Bir Mavi Saat — Japonya
- 🌆 Seul'de Siber Yürüyüş — Güney Kore
- 🏙️ Dubai, Çölün Işık Vahası — BAE
- 🏰 Prag'da Ortaçağ Masalı — Çek Cumhuriyeti
- 🌿 Singapur'da Geleceğin Şehri — Singapur
- 🌊 İstanbul'da İki Kıta Arası Yürüyüş — Türkiye

---

## 🔮 Gelecek Planları

- [ ] Kullanıcı kayıt & yorum sistemi
- [ ] Arama ve filtreleme özelliği
- [ ] Harita entegrasyonu (Google Maps API)
- [ ] Çoklu dil desteği (EN/TR)
- [ ] Admin paneli geliştirme
- [ ] SEO meta etiket yönetimi
- [ ] PWA (Progressive Web App) dönüşümü

---

## 👤 Geliştirici

**[Melik Çevik]**  
Yazılım geliştirici & seyahat tutkunu  

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=flat&logo=github&logoColor=white)](https://github.com/KULLANICI_ADINIZ)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/KULLANICI_ADINIZ)

---

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

---

> *"Sınırların ötesine geçmek, sadece yeni koordinatlar keşfetmek değil; dünyaya her seferinde yeni bir gözle, farklı bir perspektifle bakabilmektir."*
