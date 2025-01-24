# Hastane Yönetim Sistemi / Hospital Management System

## -------Türkçe-------

### Özellikler
- Doktor bilgilerini ekleme, güncelleme ve silme
- Randevu oluşturma ve düzenleme
- Hasta ve randevu yönetimi

### Kurulum
1. **Projeyi Klonlayın:**
   ```bash
   git clone <repository-url>
   ```
2. **SQL Server Bağlantısını Ayarlayın:**
   - `sqlbaglantisi` sınıfında bağlantı dizesini düzenleyin:
     ```csharp
     "Server=SERVER_ADI;Database=DATABASE_ADI;Trusted_Connection=True;"
     ```
3. **Veritabanını Kurun:**
   - `Database/hospital_database.sql` dosyasını SQL Server'da çalıştırın.
4. **Uygulamayı Çalıştırın:**
   - Visual Studio ile projeyi başlatın.

---

## -------English-------

### Features
- Add, update, and delete doctor information
- Create and manage appointments
- Manage patients and appointments

### Setup
1. **Clone the Project:**
   ```bash
   git clone <repository-url>
   ```
2. **Configure SQL Server Connection:**
   - Update the connection string in the `sqlbaglantisi` class:
     ```csharp
     "Server=SERVER_NAME;Database=DATABASE_NAME;Trusted_Connection=True;"
     ```
3. **Setup Database:**
   - Run the `Database/hospital_database.sql` file in SQL Server.
4. **Run the Application:**
   - Open the project in Visual Studio and start it.

## Lisans / License
Bu proje açık kaynaklıdır ve herkese açıktır. / This project is open-source and available to everyone.

