create database tki_zoo;

use tki_zoo;

create table tki_musteriler
(
	musteri_id				varchar(64)		not null,
    musteri_ad				varchar(64)		not null,
	musteri_soyad			varchar(64)		not null,
	musteri_yas				varchar(64)		not null,
	musteri_cinsiyet		varchar(64)		not null,
    musteri_ziyaret			varchar(64)		not null,
    
    primary key(musteri_id)
);


create table tki_hayvan
(
	hayvan_id					varchar(64)		not null,
	hayvan_ad					varchar(64)		not null,
	hayvan_tur					varchar(64)		not null,
	hayvan_yas					varchar(64)		not null,
    hayvan_cinsiyet				varchar(64)		not null,
    
    primary key(hayvan_id)
);



create table tki_bakici
(
	bakici_id					varchar(64)		not null,
    hayvan_id					varchar(64)		not null,
	bakici_ad					varchar(64)		not null,
	bakici_soyad				varchar(64)		not null,
	bakici_yas					varchar(64)		not null,
    bakici_cinsiyet				varchar(64)		not null,
    bakici_telefon				varchar(64)		not null,
    bakici_hayvan				varchar(64)		not null,
    
    primary key(bakici_id),
    
    foreign key(hayvan_id) references tki_hayvan(hayvan_id)
		on delete cascade on update cascade
);


create table tki_odemeler
(
	odeme_id		varchar(64)		not null,
    musteri_id		varchar(64)		not null,
	odeme_tarih		datetime		not null,
	odeme_tutar		float			not null,
	odeme_turu		varchar(64)		not null,
    odeme_aciklama	varchar(64)		not null,
    
    primary key(odeme_id),
    
    foreign key(musteri_id) references tki_musteriler(musteri_id)
		on delete cascade on update cascade
);