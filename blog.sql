create table ChiTiet(
ID int IDENTITY(1,1) ,
tieuDe nvarchar (200),
noiDung nvarchar(max),
lanXem int,
ngayDang datetime,
IDBanTin int,
primary key (ID),
FOREIGN KEY (IDBanTin)
   REFERENCES BanTin (IDBanTin)
)

drop table BanTin
select * from BanTin
select * from ChiTiet
create table Bantin(
IDBanTin int IDENTITY(1,1),
noiDung nvarchar(50),
primary key (IDBanTin)
)
create table DangNhap(
IDName int IDENTITY(1,1),
userName nvarchar (50),
passWord nvarchar (50)
primary key (IDName)
)
create table comment(
name nvarchar(100),
com nvarchar(max),
time datetime,

)

create proc BanTin_Seclectall
as
begin
 select * from Bantin
end

create proc BanTin_SeclectID
(@IDBanTin int)
as
begin
 select * from Bantin where IDBanTin=@IDBanTin
end

create proc DangNhap_Seclectall
as
begin
 select * from DangNhap
end
create proc DangNhap_Search(
@userName nvarchar(50),
	@passWord nvarchar(50))
as
begin
 select * from DangNhap where userName=@userName and passWord =@passWord
end



create proc ChiTiet_SeclectID
(
	@IDBanTin int
)
as
begin
 select * from ChiTiet where IDBanTin= @IDBanTin
end
create proc ChiTiet_SELECT
(
	@ID int
)
as
begin
 select * from ChiTiet where ID= @ID
end

create proc ChiTiet_SelectHome
as
begin
 select top 30 * from ChiTiet order by ID Desc
end
 
create proc ChiTiet_LanXem(
@ID int,
@lanXem int output
)
as
begin
 
 select @lanXem= lanXem from ChiTiet where ID= @ID
end

create proc ChiTiet_SelectRanDom(
@IDBanTin int
)
as
begin
 select top 5 * from ChiTiet Tablesample (5 rows)
end

create proc ChiTiet_SelectAll

as
begin
 select * from ChiTiet 
end
create proc Comment_SelectAll

as
begin
 select * from comment 
end

create proc BanTin_Insert(
	@noiDung nvarchar(50)
)
as
begin
 insert into Bantin (noiDung) values (@noiDung)
end
create proc DangNhap_Insert(
	@userName nvarchar(50),
	@passWord nvarchar(50)
)
as
begin
 insert into DangNhap(userName,passWord) 
 values (@userName,@passWord)
end

create proc ChiTiet_Insert(
@tieuDe nvarchar (200),
@noiDung nvarchar(max),
@ngayDang datetime,
@IDBanTin int
)
as
begin
 insert into ChiTiet (tieuDe,noiDung,ngayDang,IDBanTin)
  values (@tieuDe,@noiDung,@ngayDang,@IDBanTin)
end

create proc BanTin_Update(
	@noiDung nvarchar(50),
	@IDBanTin int
)
as
begin
UPdate BanTin set noiDung=@noiDung where IDBanTin=@IDBanTin
end

create proc DangNhap_Update(
	@useName nvarchar(50),
	@passWord nvarchar(50),
	@IDName int
)
as
begin
UPdate DangNhap set userName=@useName, passWord=@passWord  
where IDName=@IDName 
end

create proc ChiTiet_Update(
@ID int,
@IDBanTin int,
@tieuDe nvarchar (200),
@noiDung nvarchar(max)

)
as
begin
UPdate ChiTiet set tieuDe=@tieuDe,noiDung=@noiDung
where ID=@ID 
end
drop proc ChiTiet_Update
create proc ChiTiet_SLX(
@lanXem int,
@ID int
)
as
begin
UPdate ChiTiet set lanXem=@lanXem
where ID=@ID
end

create proc BanTin_Delete(
	
	@IDBanTin int
)
as
begin
delete from BanTin  where IDBanTin=@IDBanTin
end
create proc DangNhap_Delete(
	
	@IDName int
)
as
begin
delete from DangNhap  where IDName=@IDName
end

create proc ChiTiet_Delete(
@ID int
)
as
begin
delete ChiTiet
where ID=@ID
end


select * from DangNhap
delete from ChiTiet
