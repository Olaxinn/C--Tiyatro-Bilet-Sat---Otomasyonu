Mysql kodları
*****************************
** Create database tiyatro **
*****************************
CREATE TABLE Biletler (
    id INT AUTO_INCREMENT PRIMARY KEY,
	oyun varchar (15) not null,
    bilet_sayi VARCHAR(15) NOT NULL,
    fiyat varchar(25) NOT NULL
   
);
