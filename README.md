# C# WinForms: Temel Görüntü İşleme Filtreleri

[cite_start]Bu proje, Bilgisayarlı Görü dersi "Ödev 3: İkinci Görev" [cite: 143] kapsamında C# ve Windows Forms kullanılarak geliştirilmiştir. Uygulama, yüklenen bir görüntüye temel düzeyde piksel tabanlı görüntü işleme filtreleri uygular ve sonucu arayüzde gösterir.

## 🚀 Uygulanan Filtreler ve Fonksiyonlar

Uygulama, yüklenen orijinal görüntü (solda) üzerinde çeşitli nokta operasyonları gerçekleştirir ve işlenmiş görüntüyü (sağda) gösterir:

* [cite_start]**Resim Yükle:** `.jpg`, `.png`, `.bmp` formatında resim yükler[cite: 226, 230].
* **Darken (Karartma):** Görüntünün parlaklığını azaltır.
    * [cite_start]*Formül:* $Piksel_{yeni} = Piksel_{eski} - 128$ [cite: 236, 249, 250, 251] (0'dan küçükse 0 olarak ayarlanır).
* **Lighten (Aydınlatma):** Görüntünün parlaklığını artırır.
    * [cite_start]*Formül:* $Piksel_{yeni} = Piksel_{eski} + 128$ [cite: 254, 265, 266, 267] (255'ten büyükse 255 olarak ayarlanır).
* **Invert (Ters Çevirme):** Görüntünün renklerini tersine çevirir (negatifini alır).
    * [cite_start]*Formül:* $Piksel_{yeni} = 255 - Piksel_{eski}$[cite: 272, 283, 284, 285].
* **Lower Contrast (Kontrast Azaltma):** Görüntünün kontrastını düşürür.
    * [cite_start]*Formül:* $Piksel_{yeni} = Piksel_{eski} / 2$[cite: 290, 300, 302, 303].
* **Raise Contrast (Kontrast Artırma):** Görüntünün kontrastını artırır.
    * [cite_start]*Formül:* $Piksel_{yeni} = Piksel_{eski} * 2$ [cite: 308, 321, 322, 323] (255'ten büyükse 255 olarak ayarlanır).
* **Nonlinear Raise Contrast (Doğrusal Olmayan Kontrast Artırma):** Kontrastı doğrusal olmayan (karesel) bir fonksiyon kullanarak artırır.
    * [cite_start]*Formül:* $Piksel_{yeni} = (Piksel_{eski} / 255.0)^2 * 255$[cite: 326, 341, 342, 343].

## 🛠️ Kullanılan Teknolojiler

* **C#** ve **.NET Windows Forms**
* [cite_start]**System.Drawing:** Görüntü yükleme ve piksel tabanlı işlemler (GetPixel/SetPixel) için[cite: 215, 248, 252].

## ⚙️ Kurulum ve Kullanım

1.  Projeyi Visual Studio'da açın.
2.  Uygulamayı çalıştırın (`F5`).
3.  [cite_start]"Resim Yükle" [cite: 147] butonuna basarak bir resim seçin.
4.  İstediğiniz filtre butonuna (Darken, Invert, vb.) basarak sonucun sağdaki `PictureBox` üzerinde görünmesini sağlayın.

## 👤 Yazar

* [cite_start]**Bengüsu DUMAN** [cite: 1]
