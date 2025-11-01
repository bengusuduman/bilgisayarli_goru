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
