CREATE TABLE pelanggan (
    id SERIAL PRIMARY KEY,
    nama VARCHAR(100),
    email VARCHAR(100),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE kendaraan (
    id SERIAL PRIMARY KEY,
    nama_kendaraan VARCHAR(100),
    harga_sewa INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE penyewaan (
    id SERIAL PRIMARY KEY,
    pelanggan_id INT,
    kendaraan_id INT,
    tanggal_sewa DATE,
    tanggal_kembali DATE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (pelanggan_id) REFERENCES pelanggan(id),
    FOREIGN KEY (kendaraan_id) REFERENCES kendaraan(id)
);

CREATE INDEX idx_pelanggan_email ON pelanggan(email);


INSERT INTO pelanggan (nama, email) VALUES
('Nadia', 'nadia@gmail.com'),
('Budi', 'budi@gmail.com'),
('Sari', 'sari@gmail.com'),
('Andi', 'andi@gmail.com'),
('Rina', 'rina@gmail.com');


INSERT INTO pelanggan (nama, email) VALUES
('Nadia', 'nadia@gmail.com'),
('Budi', 'budi@gmail.com'),
('Sari', 'sari@gmail.com'),
('Andi', 'andi@gmail.com'),
('Rina', 'rina@gmail.com');


INSERT INTO pelanggan (nama, email) VALUES
('Nadia', 'nadia@gmail.com'),
('Budi', 'budi@gmail.com'),
('Sari', 'sari@gmail.com'),
('Andi', 'andi@gmail.com'),
('Rina', 'rina@gmail.com');