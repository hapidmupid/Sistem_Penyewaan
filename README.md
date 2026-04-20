# 🚗 Sistem Penyewaan Kendaraan REST API

## 📌 a) Deskripsi Project

Project ini merupakan **REST API** yang dirancang untuk mengelola sistem penyewaan kendaraan secara digital. API ini memungkinkan pengguna untuk mengelola data pelanggan, ketersediaan armada kendaraan, hingga pencatatan transaksi penyewaan secara terintegrasi.

**Domain:** Sistem Penyewaan Kendaraan
**Alasan:** Untuk mendigitalisasi proses pencatatan manual pada usaha rental kendaraan agar lebih cepat, akurat, dan aman.

---

## ⚙️ b) Teknologi yang Digunakan

* **Bahasa Pemrograman:** C#
* **Framework:** ASP.NET Core Web API 8.0
* **Database:** PostgreSQL
* **ORM / Library:** Dapper
* **Tools:** Visual Studio 2022, pgAdmin, Swagger

---

## 🚀 c) Langkah Instalasi & Menjalankan Project

1. **Clone Repository**

   ```bash
   git clone https://github.com/hapidmupid/Sistem_Penyewaan.git
   ```

2. **Buka Project**

   * Buka file `.sln` menggunakan **Visual Studio 2022**

3. **Pastikan .NET SDK Terinstal**

4. **Konfigurasi Database**

   * Buka file `appsettings.json`
   * Sesuaikan **Connection String** (username & password PostgreSQL)

5. **Jalankan Project**

   * Tekan `F5` atau klik **Run**

6. **Akses Swagger**

   ```
   https://localhost:xxxx/swagger
   ```

   *(Port menyesuaikan sistem)*

---

## 🗄️ d) Cara Import Database (pgAdmin 4)

1. Buka **pgAdmin 4**
2. Buat database baru:

   ```
   sistem_penyewaan
   ```
3. Klik kanan database → **Query Tool**
4. Buka file:

   ```
   db_penyewaan.sql
   ```
5. Copy seluruh isi script ke Query Tool
6. Tekan **Execute (F5)**

Database dan tabel akan otomatis terbentuk beserta data contoh.

---

## 🔗 e) Daftar Endpoint API

### 📍 Pelanggan

| Method | URL                   | Keterangan                        |
| ------ | --------------------- | --------------------------------- |
| GET    | `/api/Pelanggan`      | Menampilkan semua pelanggan       |
| GET    | `/api/Pelanggan/{id}` | Detail pelanggan berdasarkan ID   |
| POST   | `/api/Pelanggan`      | Menambahkan pelanggan baru        |
| PUT    | `/api/Pelanggan/{id}` | Memperbarui data pelanggan        |
| DELETE | `/api/Pelanggan/{id}` | Menghapus pelanggan (Soft Delete) |

### 🚗 Kendaraan

| Method | URL              | Keterangan                   |
| ------ | ---------------- | ---------------------------- |
| GET    | `/api/Kendaraan` | Menampilkan daftar kendaraan |
| POST   | `/api/Kendaraan` | Menambahkan kendaraan baru   |

### 📄 Penyewaan

| Method | URL              | Keterangan                      |
| ------ | ---------------- | ------------------------------- |
| GET    | `/api/Penyewaan` | Menampilkan riwayat penyewaan   |
| POST   | `/api/Penyewaan` | Menambahkan transaksi penyewaan |

---

## 🔐 f) Fitur Keamanan & Teknis

* ✅ **Parameterized Query** → Mencegah SQL Injection (Dapper)
* 🕒 **Timestamps** → `created_at` & `updated_at` di setiap tabel
* ⚡ **Database Index** → Optimasi performa query

---

## 🎥 g) Link Video Presentasi

Penjelasan lengkap mengenai:

* Alur kode
* Struktur folder
* Demo penggunaan (sukses & error)

🔗 **Link Video:** *[(Tambahkan link YouTube di sini)](https://youtu.be/2aYQ0GVykmY)*

---
