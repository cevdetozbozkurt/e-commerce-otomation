select AltKategoriadi from AltKategori 
inner join kategori on altkategori.kategoriid = kategori.kategoriid 

select * from AltKategori

select * from kategori


insert into AltKategori(AltKategoriAdi,KategoriId) values('',4)

update AltKategori
set AltKategoriAdi = 'Takı & Mücevher'
where AltKategoriId = 18


CREATE TABLE Orders (
    OrderID int NOT NULL,
    OrderNumber int NOT NULL,
    PersonID int,
    PRIMARY KEY (OrderID),
    FOREIGN KEY (PersonID) REFERENCES Persons(PersonID)
);

ALTER TABLE siparis
drop COLUMN uyeid,adresid;

alter table siparis
add UyeId int foreign key(Uyeid) references Uye(UyeId), 
AdresId int foreign key (AdresId) references UyeAdres(AdresId)