# 🧩 Bilgisayarlı Görü - Ödev 3 (Birinci Görev)

## 📘 Proje Hakkında
Bu proje, seçilen bir görselin gri tonlamaya dönüştürülmesini ve bu gri değerlerin 200x200 piksel boyutunda bir matris olarak **Excel dosyasına aktarılmasını** sağlar.  
Windows Forms uygulaması olarak geliştirilmiştir.

---

## ⚙️ Kullanılan Teknolojiler
- **C# (.NET Framework / Windows Forms)**
- **EPPlus** (Excel işlemleri için)
- **System.Drawing** kütüphanesi

---

## 🧠 Uygulamanın Çalışma Mantığı
1. **Resim Yükleme:**  
   Kullanıcı bir görsel seçer (`.jpg`, `.png`, `.bmp` formatında).  
   Görsel otomatik olarak **200x200 boyutuna** küçültülür.

2. **Griye Dönüştürme:**  
   Görsel, `(R + G + B) / 3` formülüyle gri tonlamaya çevrilir.  
   Dönüştürülmüş görüntü ikinci `PictureBox` içinde gösterilir.

3. **Excel’e Aktarma:**  
   Her pikselin gri değeri, bir Excel sayfasına (200x200 matris olarak) yazılır.  
   Dosya ismi otomatik olarak `GriPikselDegerleri.xlsx` şeklinde oluşturulur.

---

## 🪄 Kullanım Adımları
1. Uygulamayı başlat.  
2. “**Resim Yükle**” butonuna tıklayarak bir görsel seç.  
3. Görsel gri tonlamaya çevrilip ekranda gösterilecektir.  
4. “**Excel’e Aktar**” butonuna tıklayarak piksel gri değerlerini `.xlsx` dosyası olarak kaydet.

---

## 🧩 Örnek Görsel Akışı
| Adım | Açıklama | Görsel |
|------|-----------|--------|
| 1 | Renkli görsel yüklendi | 🖼️ |
| 2 | Gri tonlama uygulandı | ⚫⚪ |
| 3 | Excel’e aktarıldı | 📊 |

---

## ✍️ Geliştirici
**Bengüsu Duman**  
📚 Bilgisayarlı Görü - Ödev 3 (Birinci Görev)  
📧 bengusuduman.60@gmail.com

# 🎨 Bilgisayarlı Görü - Ödev 3 (İkinci Görev)

## 📘 Proje Hakkında
Bu proje, yüklenen bir görüntü üzerinde temel **parlaklık, kontrast ve ters çevirme (invert)** işlemlerinin uygulanabildiği bir **Windows Forms uygulamasıdır.**  
Kullanıcı arayüzü üzerinden farklı butonlarla işlemler kolayca denenebilir.

---

## ⚙️ Kullanılan Teknolojiler
- **C# (.NET Framework / Windows Forms)**
- **System.Drawing** kütüphanesi

---

## 🧠 Uygulamanın Özellikleri
| Buton | İşlev | Matematiksel Açıklama |
|--------|--------|------------------------|
| **Darken** | Görüntüyü karartır | `x - 128` |
| **Lighten** | Görüntüyü aydınlatır | `x + 128` |
| **Invert** | Renkleri ters çevirir | `255 - x` |
| **Lower Contrast** | Kontrastı düşürür | `x / 2` |
| **Raise Contrast** | Kontrastı artırır | `x * 2` |
| **Nonlinear Contrast** | Doğrusal olmayan kontrast değişimi | `(x / 255.0)^2 * 255` |

---

## 🪄 Kullanım Adımları
1. “**Resim Yükle**” butonuna tıklayarak bir görsel seç.  
2. İstediğin görüntü işleme butonuna tıkla (örneğin “Darken” veya “Invert”).  
3. İşlenen yeni görsel, ikinci `PictureBox` üzerinde görüntülenecektir.

---

## 📸 Örnek Kullanım Senaryosu
1. Görüntü yüklendi.  
2. “Lighten” butonuna basıldı.  
3. Görüntü aydınlatıldı ve ikinci kutuda gösterildi.

---

## ✍️ Geliştirici
**Bengüsu Duman**  
📚 Bilgisayarlı Görü - Ödev 3 (İkinci Görev)  
📧 bengusuduman.60@gmail.com
