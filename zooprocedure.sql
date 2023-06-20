delimiter $$
create procedure tki_MusteriEkle(
	id			varchar(64) ,
    ad			varchar(64) ,
    soyad		varchar(64) ,
    yas			varchar(64) ,
    cinsiyet	varchar(64) ,
    ziyaret		varchar(64)
)
begin
	insert into tki_musteriler
    values (id, ad, soyad, yas, cinsiyet, ziyaret);
end $$
delimiter ;



delimiter $$
create procedure tki_MusteriHepsi ()
BEGIN
	select
			musteri_id				as ID,
            musteri_ad				as Ad,
            musteri_soyad			as Soyad,
            musteri_yas				as Yas,
            musteri_cinsiyet		as Cinsiyet,
            musteri_ziyaret			as Ziyaret
	from tki_musteriler;
end $$
delimiter ;

delimiter $$
create procedure tki_MusteriBul(
	filtre varchar(64)
)
begin
	select
            musteri_ad				as Ad,
            musteri_soyad			as Soyad,
            musteri_yas				as Yas,
            musteri_cinsiyet		as Cinsiyet,
            musteri_ziyaret			as Ziyaret
	from tki_musteriler
    where
			musteri_ad				like concat('%',filtre,'%')or
            musteri_soyad			like concat('%',filtre,'%')or
            musteri_yas				like concat('%',filtre,'%')or
            musteri_cinsiyet		like concat('%',filtre,'%')or
            musteri_ziyaret			like concat('%',filtre,'%');
end $$
delimiter ;



delimiter $$
create procedure tki_MusteriGuncelle(
	id			varchar(64) ,
    ad			varchar(64) ,
    soyad		varchar(64) ,
    yas			varchar(64) ,
    cinsiyet	varchar(64) ,
    ziyaret		varchar(64)
)
begin
	update tki_musteriler
    set
		musteri_ad			= ad,
        musteri_soyad		= soyad,
        musteri_yas			= yas,
        musteri_cinsiyet	= cinsiyet,
        musteri_ziyaret		= ziyaret
	where
		musteri_id			= id;
end $$
delimiter ;


delimiter $$
create procedure tki_MusteriSil(
	id		varchar(64)
)
begin
	delete from tki_musteriler
    where	musteri_id	= id;
end $$
delimiter ;


delimiter $$
create procedure tki_HayvanEkle (
	id				varchar(64) ,
    ad				varchar(64) ,
    tur				varchar(64) ,
    yas				varchar(64) ,
    cinsiyet		varchar(64) 
)
begin
		insert into tki_hayvan
        values		(id, ad, tur, yas, cinsiyet);
end $$
delimiter ;



delimiter $$
create procedure tki_HayvanHepsi ()
begin
	select
		hayvan_id 		as ID ,
		hayvan_ad 		as Ad ,
		hayvan_tur 		as Tur , 
		hayvan_yas 		as Yas ,
		hayvan_cinsiyet as Cinsiyet
    from tki_hayvan;
end $$
delimiter ;


delimiter $$
create procedure tki_HayvanBul(
	filtre		varchar(32)
)
begin
	select
		hayvan_ad 		as Ad ,
		hayvan_tur 		as Tur , 
		hayvan_yas 		as Yas ,
		hayvan_cinsiyet as Cinsiyet
    from tki_hayvan
    where
		hayvan_id			like concat('%',filtre,'%') or
		hayvan_ad			like concat('%',filtre,'%') or
        hayvan_tur			like concat('%',filtre,'%') or
        hayvan_yas			like concat('%',filtre,'%') or
        hayvan_cinsiyet		like concat('%',filtre,'%') ;
end $$
delimiter ;



delimiter $$
create procedure tki_HayvanGuncelle(
		id				varchar(64) ,
        ad				varchar(64) ,
        tur				varchar(64) ,
        yas				varchar(64) ,
        cinsiyet		varchar(64)
)
begin
	update tki_hayvan
    set
		hayvan_ad		= ad,
        hayvan_tur		=tur,
        hayvan_yas		=yas,
        hayvan_cinsiyet =cinsiyet
	where
		hayvan_id		=id;
end $$
delimiter ;


delimiter $$
create procedure tki_HayvanSil (
	id 			varchar(64)
)
begin
	delete from tki_hayvan
    where hayvan_id		= id;
end $$
delimiter ;



delimiter $$
create procedure tki_BakiciEkle(
	bid			varchar(64) ,
    hid			varchar(64) ,
    ad			varchar(64) ,
    soyad		varchar(64) ,
    yas 		varchar(64) ,
    cinsiyet 	varchar(64) ,
    telefon		varchar(64) ,
    hayvan		varchar(64)
)
begin
	insert into tki_bakici
    values (bid, hid, ad, soyad, yas, cinsiyet, telefon, hayvan);
end $$
delimiter ;



delimiter $$
create procedure tki_BakiciDetay (
)
begin
select 
		b.bakici_id,
        h.hayvan_id,
        hayvan_ad as 'Hayvan' ,
        hayvan_tur as 'Tur' ,
        bakici_ad as 'BakiciAd' ,
        bakici_soyad as 'BakiciSoyad' ,
        bakici_yas as 'BakiciYas' ,
        bakici_cinsiyet as 'BakiciCinsiyet' ,
        bakici_telefon as 'BakiciTelefon' ,
        bakici_hayvan as 'BakiciHayvan'

from tki_hayvan h inner join tki_bakici b on h.hayvan_id = b.hayvan_id;
end $$
delimiter ;


delimiter $$
create procedure tki_BakiciGuncelle(
	bid			varchar(64) ,
    hid			varchar(64) ,
    ad			varchar(64) ,
    soyad		varchar(64) ,
    yas 		varchar(64) ,
    cinsiyet 	varchar(64) ,
    telefon		varchar(64) ,
    hayvan		varchar(64)
)
begin
	update tki_bakici
    set
		hayvan_id		= hid,
        bakici_ad		= ad,
        bakici_soyad	= soyad,
        bakici_yas		= yas,
        bakici_cinsiyet	= cinsiyet,
        bakici_telefon	= telefon,
        bakici_hayvan	= hayvan
	where
		bakici_id		= bid;
end $$
delimiter ;





delimiter $$
create procedure tki_BakiciSil(
	id			varchar(64)
)
begin
		delete from tki_bakici
        where bakici_id	= id;
end $$
delimiter ;



delimiter $$
create procedure tki_OdemeEkle (
	oid			varchar(64) ,
    mid			varchar(64) ,
    tarih		datetime	,
    tutar		float		,
    tur			varchar(64) ,
    aciklama	varchar(64)
)
begin
	insert into tki_odemeler
    values (oid, mid, tarih, tutar, tur, aciklama);
end $$
delimiter ;



delimiter $$
create procedure tki_OdemeDetay (
)
begin
select
		o.odeme_id,
        m.musteri_id,
        concat(musteri_ad,' ', musteri_soyad ) as 'MusteriAdSoyad',
        o.odeme_tarih as 'OdemeTarih',
        o.odeme_tutar as 'OdemeTutar',
        o.odeme_turu as 'OdemeTur' ,
        o.odeme_aciklama as 'Aciklama'
from tki_musteriler m inner join tki_odemeler o
	on m.musteri_id = o.musteri_id;
end $$
delimiter ;


delimiter $$
create procedure tki_OdemeGuncelle(
		oid			varchar(64) ,
        mid			varchar(64) ,
        tarih		datetime	,
        tutar		float		,
        tur			varchar(64) ,
        aciklama	varchar(64) 
)
begin
		update tki_odemeler
        set
			musteri_id		= mid,
            odeme_tarih		=tarih,
            odeme_tutar		=tutar,
            odeme_tur		=tur,
            odeme_aciklama	=aciklama
		where
			odeme_id		= oid;
	end $$
    delimiter ;
    
    
    
delimiter $$
create procedure tki_OdemeSil(
	oid			varchar(64)
)
begin
		delete from tki_odemeler
        where odeme_id	= oid;
end $$
delimiter ;