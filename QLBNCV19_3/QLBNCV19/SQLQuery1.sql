use QLBNCV19
go

create proc PSD_KiemTraDangNhap
@TenTaiKhoan nvarchar(100),
@MatKhau nvarchar(100)
as
IF EXISTS (Select 1 from Account where TaiKhoan=@TenTaiKhoan and MatKhau=@MatKhau )
	begin
		select 1 as code, TaiKhoan, MatKhau from Account
		where TaiKhoan=@TenTaiKhoan and MatKhau=@MatKhau
	end;
else
	Begin
		select 0 as code,
		N'' As TaiKhoan,
		N'' as MatKhau
	end;
go

create proc PSD_LayDanhSachBenhNhan
as
	select bn.MaBN,bn.HoVaTen,bn.NgaySinh,bn.DiaChi,kb.TinhTrang,bs.HoVaTenBS,bn.MoTa
	from KhamBenh kb join BenhNhan bn on kb.MaBN=bn.MaBN JOIN BacSi bs on bs.MaBS=kb.MaBS
	order by MaBN
go

create proc PSD_TongBenhNhan
@Tong int
as
	set @Tong=(
	select COUNT (MaBN) from BenhNhan )
go

create proc PSD_DuongTinh_Select
as
	select bn.MaBN,bn.HoVaTen,bn.NgaySinh,bn.DiaChi,kb.TinhTrang,bs.HoVaTenBS,bn.MoTa
	from KhamBenh kb join BenhNhan bn on kb.MaBN=bn.MaBN JOIN BacSi bs on bs.MaBS=kb.MaBS where TinhTrang=N'Dương Tính'
	order by MaBN
go

create proc PSD_AmTinh_Select
as
	select bn.MaBN,bn.HoVaTen,bn.NgaySinh,bn.DiaChi,kb.TinhTrang,bs.HoVaTenBS,bn.MoTa
	from KhamBenh kb join BenhNhan bn on kb.MaBN=bn.MaBN JOIN BacSi bs on bs.MaBS=kb.MaBS where TinhTrang=N'Âm Tính'
	order by MaBN
go

create proc PSD_TuVong_Select
as
	select bn.MaBN,bn.HoVaTen,bn.NgaySinh,bn.DiaChi,kb.TinhTrang,bs.HoVaTenBS,bn.MoTa
	from KhamBenh kb join BenhNhan bn on kb.MaBN=bn.MaBN JOIN BacSi bs on bs.MaBS=kb.MaBS where TinhTrang=N'Tử Vong'
	order by MaBN
go

create proc PSD_CapNhat
@MaBN int,
@HoVaTen nvarchar(100),
@NgaySinh date,
@DiaChi nvarchar(100),
@HoVaTenBS nvarchar(100),
@TinhTrang nvarchar(100),
@MoTa nvarchar(1000)
as
if exists (select 1 from BenhNhan where MaBN=@MaBN)
begin
	update BenhNhan
	set HoVaTen = @HoVaTen, NgaySinh = @NgaySinh, DiaChi= @DiaChi, MoTa=@MoTa
	where MaBN = @MaBN
	
	update KhamBenh
	set HoVaTen=@HoVaTen, HoVaTenBS=@HoVaTenBS, TinhTrang=@TinhTrang
	where MaBN=@MaBN
end
else
begin
	insert into BenhNhan(HoVaTen,NgaySinh,DiaChi,MoTa)
	values (@HoVaTen,@NgaySinh,@DiaChi,@MoTa)
	insert into KhamBenh(HoVaTen,HoVaTenBS,TinhTrang)
	values (@HoVaTen,@HoVaTenBS,@TinhTrang)
end
go

