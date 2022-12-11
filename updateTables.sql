select AltKategoriadi from AltKategori 
inner join kategori on altkategori.kategoriid = kategori.kategoriid 

select * from AltKategori


insert into AltKategori(AltKategoriAdi,KategoriId) values('Oyun & Oyun Konsolları',1)

update AltKategori
set AltKategoriAdi = 'Klima ve Isıtıcılar'
where AltKategoriId = 7


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