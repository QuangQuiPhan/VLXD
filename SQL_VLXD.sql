use master;
go
if exists(select * from sysdatabases where name = 'VatLieuXayDung')
	drop database VatLieuXayDung;
go
create database VatLieuXayDung
go
use VatLieuXayDung
go
create table LoaiMatHang(
	MaLoai varchar(5) not null,
	TenLoai nvarchar(50) not null,
	constraint pk_LoaiMatHang primary key(MaLoai)
)
go
create table MatHang(
	MaMatHang varchar(10) not null,
	TenMatHang nvarchar(200) not null,
	DonViTinh nvarchar(20) not null,
	DonGia float not null,
	MaLoai varchar(5) not null
	constraint pk_Mathang primary key(mamatHang)
)
go
create table LoaiTaiKhoan(
	MaLoai varchar(3) not null,
	TenLoai nvarchar(30) not null
	constraint pk_LoaiTaiKhoan primary key(MaLoai)
)
go
create table TaiKhoan(
	TenDangNhap varchar(20) not null,
	MatKhau varchar(30) not null,
	LoaiTK varchar(3) not null,
	MaNV varchar(10) not null unique,
	constraint pk_taikhoan primary key(TenDangNhap)
)
go
create table NhanVien(
	MaNV varchar(10) not null,
	HoTen nvarchar(100) not null,
	NgaySinh date not null,
	Phai nvarchar(5) not null,
	DienThoai varchar(20) not null unique,
	DiaChi nvarchar(300) not null
	constraint pk_NhanVien primary key(MaNV)
)
go
create table KhachHang(
	MaKH varchar(20) not null,
	HoTen nvarchar(100) not null,
	DienThoai varchar(20) not null unique,
	DiaChi nvarchar(300) not null
	constraint pk_khachHang primary key(MaKH)
)
go
create table DonDatHang(
	SoDH int identity not null,
	NgayDat date not null,
	NgayGiao date not null,
	DiaChiGiao nvarchar(300) not null,
	TongTien float null,
	MaNV varchar(10) not null,
	MaKH varchar(20) not null
	constraint pk_DonDatHang primary key(SoDH)
)
go
create table CT_DonDatHang(
	SoDH int not null,
	MaMatHang varchar(10) not null,
	SoLuong int check(SoLuong > 0) not null,
	ThanhTien float null
	constraint pk_CT_DonHang primary key(SoDH, MaMatHang)
)
go
alter table MatHang Add constraint fk_mathang_loaimathang foreign key(maloai) references LoaiMatHang(MaLoai)
go
alter table TaiKhoan add constraint fk_taikhoan_LoaiTaiKhoan foreign key(LoaiTK) references LoaiTaiKhoan(MaLoai)
go
alter table TaiKhoan add constraint fk_taikhoan_Nhanvien foreign key(MaNV) references Nhanvien(manv)
go
alter table DonDatHang add constraint fk_DonDatHang_NhanVien foreign key(manv) references NhanVien(Manv)
go
alter table DonDatHang add constraint fk_DonDatHang_Khachhang foreign key(makh) references KhachHang(MaKH)
go
alter table CT_DonDatHang add constraint fk_CTDonDathang_DonDatHang foreign key(SoDH) references DonDatHang(SoDH)
go
alter table CT_DonDatHang add constraint fk_CtDonDathang_MatHang foreign key(maMathang) references MatHang(MaMatHang)
go
select * from LoaiMatHang
go
--------------------------------------------------- STORED PROCEDURE SHOW INFORMATION--------------------------------------------------------------
-- Stored procedure hiển thị danh sách sản phẩm
create or alter procedure sp_products
As
begin
	select MaMatHang as N'Mã mặt hàng', TenMatHang as N'Tên mặt hàng', DonViTinh as N'Đơn vị tính', 
			donGia as N'Đơn giá', MatHang.MaLoai as N'Mã loại'
	from MatHang
end
go
-- Stored procedure hiển thị danh sách loại sản phẩm 
create or alter procedure sp_Category
as
begin
	select MaLoai as N'Mã loại', TenLoai as N'Tên loại hàng' from LoaiMatHang
end
go
-- Stored procedure hiển thị danh sách nhân viên
create or alter procedure sp_Employee
as
begin
	select MaNV as N'Mã nhân viên', HoTen as N'Họ tên nhân viên', NgaySinh as N'Ngày sinh', Phai as N'Giới tính', DienThoai as N'Điện thoại', DiaChi as N'Địa chỉ' 
	from NhanVien
end
go
-- Stored procedure hiển thị danh sách tài khoản
create or alter procedure sp_AccountGroup
as
begin
	select MaLoai as N'Mã loại', TenLoai as N'Tên loại tài khoản' from LoaiTaiKhoan
end
go
-- Stored procedure hiển thị danh sách loại tài khoản
create or alter procedure sp_Account
as
begin
	select TenDangNhap as N'Tên đăng nhập', MatKhau as N'Mật khẩu', LoaiTK as N'Loại tài khoản', MaNV as N'Nhân viên' from TaiKhoan
end
go
-- Stored procedure hiển thị danh sách khách hàng
create or alter procedure sp_Customer
as
begin
	select MaKH as N'Mã khách hàng', HoTen as N'Họ tên', DienThoai as N'Điện thoại', DiaChi as N'Địa chỉ' from KhachHang
end
go
-- Stored procedure hiển thị danh sách hóa đơn
create or alter procedure sp_Bill
as
begin
	select SoDH as N'Số đơn hàng', NgayDat as N'Ngày đặt', NgayGiao as N'Ngày giao', DiaChiGiao as N'Địa chỉ giao', TongTien as N'Tổng tiền', MaKH as N'Mã khách hàng',
			MaNV as 'Mã nhân viên'
	from DonDatHang
end
go
-- Stored procedure hiển thị danh sách loại sản phẩm
create or alter procedure sp_BillDetail(
	@ID varchar(30)
)
as
begin
	select MatHang.MaMatHang as N'Mã mặt hàng', MatHang.TenMatHang as 'Tên mặt hàng', SoLuong as N'Số lượng', ThanhTien as N'Thành tiền' 
	from CT_DonDatHang inner join MatHang on CT_DonDatHang.MaMatHang = MatHang.MaMatHang
	where SoDH = @ID
end
go
--------------------------------------------------- STORED PROCEDURE FIND INFORMATION--------------------------------------------------------------
-- Stored procedure hiển thị thông tin sản phẩm cần tìm 
create or alter procedure sp_findProduct(
	@TuKhoa nvarchar(50)
)as
begin
	select MaMatHang as N'Mã mặt hàng', TenMatHang as N'Tên mặt hàng', DonViTinh as N'Đơn vị tính', 
			donGia as N'Đơn giá', TenLoai as N'Tên loại', MatHang.MaLoai
	from MatHang inner join LoaiMatHang on MatHang.MaLoai = LoaiMatHang.MaLoai
	where	LOWER(MaMatHang) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(TenMatHang) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(TenLoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị thông tin loại sản phẩm cần tìm
create or alter procedure sp_findCategory(
	@TuKhoa nvarchar(50)
)as
begin
	select MaLoai as N'Mã loại hàng', TenLoai as N'Tên loại hàng'
	from LoaiMatHang
	where	LOWER(MaLoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(TenLoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị danh sách nhân viên
create or alter procedure sp_findEmployee(
	@TuKhoa nvarchar(50)
)as
begin
	select MaNV as N'Mã nhân viên', HoTen as N'Họ tên nhân viên', NgaySinh as N'Ngày sinh', Phai as N'Giới tính', DienThoai as N'Điện thoại', DiaChi as N'Địa chỉ' 
	from NhanVien
	where	LOWER(MaNV) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(HoTen) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(DienThoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị danh sách tài khoản
create or alter procedure sp_findAccountGroup(
	@TuKhoa nvarchar(50)
)as
begin
	select MaLoai as N'Mã loại', TenLoai as N'Tên loại tài khoản' 
	from LoaiTaiKhoan
	where	LOWER(MaLoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(TenLoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị danh sách loại tài khoản
create or alter procedure sp_findAccount(
	@TuKhoa nvarchar(50)
)as
begin
	select TenDangNhap as N'Tên đăng nhập', MatKhau as N'Mật khẩu', LoaiTK as N'Loại tài khoản', MaNV as N'Nhân viên' 
	from TaiKhoan
	where	LOWER(TenDangNhap) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(LoaiTK) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(MaNV) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị danh sách khách hàng
create or alter procedure sp_findCustomer(
	@TuKhoa nvarchar(50)
)as
begin
	select MaKH as N'Mã khách hàng', HoTen as N'Họ tên', DienThoai as N'Điện thoại', DiaChi as N'Địa chỉ' 
	from KhachHang
	where	LOWER(MaKH) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(HoTen) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(DienThoai) like '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị danh sách hóa đơn
create or alter procedure sp_findBill(
	@TuKhoa nvarchar(50)
)as
begin
	select SoDH as N'Số đơn hàng', NgayDat as N'Ngày đặt', NgayGiao as N'Ngày giao', DiaChiGiao as N'Địa chỉ giao', TongTien as N'Tổng tiền', MaKH as N'Mã khách hàng',
			MaNV as 'Mã nhân viên'
	from DonDatHang
	where	LOWER(SoDH) like + '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(MaKH) like + '%' + LOWER(TRIM(@TuKhoa)) + '%'
		or	LOWER(MaNV) like + '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
-- Stored procedure hiển thị danh sách loại sản phẩm
create or alter procedure sp_findBillDetail(
	@TuKhoa nvarchar(50)
)as
begin
	select MatHang.MaMatHang as N'Mã mặt hàng', MatHang.TenMatHang as 'Tên mặt hàng', SoLuong as N'Số lượng', ThanhTien as N'Thành tiền' 
	from CT_DonDatHang inner join MatHang on CT_DonDatHang.MaMatHang = MatHang.MaMatHang
	where		LOWER(MatHang.MaMatHang) like + '%' + LOWER(TRIM(@TuKhoa)) + '%'
			or	LOWER(MatHang.TenMatHang) like + '%' + LOWER(TRIM(@TuKhoa)) + '%'
end
go
--------------------------------------------------- STORED PROCEDURE ADD INFORMATION--------------------------------------------------------------
-- Stored procedure thêm loại sản phẩm
create or alter procedure sp_AddCategory(
	@MaLoai varchar(5),
	@TenLoai nvarchar(50)
)AS
begin
	if not exists(select * from LoaiMatHang where MaLoai = @MaLoai)
		insert into LoaiMatHang(MaLoai, TenLoai) values(@MaLoai, @TenLoai)
end
go
-- Stored procedure thêm sản phẩm vào danh sách
go
create or alter procedure sp_AddProduct(
	@MaMH varchar(10),
	@TenMatHang nvarchar(200),
	@DonViTinh nvarchar(20),
	@DonGia float,
	@MaLoai varchar(5)
)AS
begin
	if not exists(select * from MatHang where MaMatHang = @MaMH)
		insert into MatHang(MaMatHang, TenMatHang, DonGia, DonViTinh, MaLoai) 
			values(@MaMH, @TenMatHang, @DonGia, @DonViTinh, @MaLoai)
end
go
-- Stored procedure thêm nhân viên
create or alter procedure sp_AddEmployee(
	@MaNV varchar(10),
	@HoTen nvarchar(100),
	@NgaySinh date,
	@Phai nvarchar(5),
	@DienThoai varchar(20),
	@DiaChi nvarchar(300)
)as
begin
	if not exists(select * from NhanVien where MaNV = @MaNV)
		insert into NhanVien(MaNV, HoTen, NgaySinh, Phai, DienThoai, DiaChi) 
			values(@MaNV, @HoTen, @NgaySinh, @Phai, @DienThoai, @DiaChi)
end
go
-- Stored procedure thêm tài khoản
create or alter procedure sp_AddAccount(
	@TenDangNhap varchar(20),
	@MatKhau varchar(30),
	@LoaiTK varchar(3),
	@MaNV varchar(10)
)as
begin
	if not exists(select * from TaiKhoan where TenDangNhap = @TenDangNhap)
		insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK, MaNV) values(@TenDangNhap, HASHBYTES('MD5', @MatKhau), @LoaiTK, @MaNV)
end
go
-- Stored procedure thêm loại tài khoản
create or alter procedure sp_AddAccountGroup(
	@MaLoai varchar(3),
	@TenLoai nvarchar(30)
)as
begin
	if not exists(select * from LoaiTaiKhoan where MaLoai = @MaLoai)
		insert into LoaiTaiKhoan(MaLoai, TenLoai) values(@MaLoai, @TenLoai)
end
go
-- Stored procedure thêm khách hàng
create or alter procedure sp_AddCustomer(
	@MaKH varchar(10),
	@HoTen nvarchar(100),
	@DienThoai varchar(20),
	@DiaChi nvarchar(300)
)as
begin
	if not exists(select * from KhachHang where MaKH = @MaKH)
		insert into KhachHang(MaKH, HoTen, DienThoai, DiaChi) values(@MaKH, @HoTen, @DienThoai, @DiaChi)
end
go
-- Stored procedure thêm hóa đơn
create or alter procedure sp_AddBill(
	@NgayDat date,
	@NgayGiao date,
	@DiaChiGiao nvarchar(300),
	@MaNV varchar(10),
	@MaKH varchar(20)
)as
begin
	insert into DonDatHang(NgayDat, NgayGiao, DiaChiGiao, TongTien, MaNV, MaKH) values(@NgayDat, @NgayGiao, @DiaChiGiao, 0, @MaNV, @MaKH)
end
go
-- Stored procedure thêm chi tiết hóa đơn
create procedure sp_AddBillDetails(
	@SoDH int,
	@MaMatHang varchar(10),
	@SoLuong int
)as
begin
	-- dùng cursor cập nhật lại thuộc tính thành tiền
	declare cs_ThanhTien cursor for (select DonGia from MatHang where MatHang.MaMatHang = @MaMatHang)
	open cs_ThanhTien
		declare @DonGia float
	fetch next from cs_ThanhTien into @DonGia
	while @@FETCH_STATUS = 0
	begin
		insert into CT_DonDatHang(SoDH, MaMatHang, SoLuong, ThanhTien) values(@SoDH, @MaMatHang, @SoLuong, @DonGia*@SoLuong)
		fetch next from cs_ThanhTien into @DonGia
	end
	close cs_ThanhTien
	deallocate cs_ThanhTien
	---
	declare cs_TongTien cursor for (select SoDH, SUM(ThanhTien) from CT_DonDatHang where SoDH = @SoDH group by SoDH)
	open cs_TongTien
		declare @sum float,
				@DH int
	fetch next from cs_TongTien into @DH, @sum
	while @@FETCH_STATUS = 0
	begin
		update DonDatHang set TongTien = @sum where SoDH = @DH
		fetch next from cs_TongTien into @DH, @sum
	end
	close cs_TongTien
	deallocate cs_TongTien
end
go
--------------------------------------------------- STORED PROCEDURE UPDATE INFORMATION--------------------------------------------------------------
-- Stored procedure thay đổi thông tin loại sản phẩm
create or alter procedure sp_UpdateCategory(
	@MaLoai varchar(10),
	@TenLoai nvarchar(200)
)AS
begin
	update LoaiMatHang set TenLoai = @TenLoai where MaLoai = @MaLoai
end
go
-- Stored procedure thay đổi thông tin sản phẩm
create or alter procedure sp_UpdateProduct(
	@MaMH varchar(10),
	@TenMatHang nvarchar(200),
	@DonViTinh nvarchar(20),
	@DonGia float,
	@MaLoai varchar(5)
)AS
begin
	update MatHang set TenMatHang = @TenMatHang, DonGia = @DonGia, DonViTinh = @DonViTinh, MaLoai = @MaLoai
	where MaMatHang = @MaMH
end
go
-- Stored procedure thay đổi thông tin nhân viên
create or alter procedure sp_UpdateEmployee(
	@MaNV varchar(10),
	@HoTen nvarchar(100),
	@NgaySinh date,
	@Phai nvarchar(5),
	@DienThoai varchar(20),
	@DiaChi nvarchar(300)
)as
begin
	update NhanVien set HoTen = @HoTen, NgaySinh = @NgaySinh, Phai = @Phai, DienThoai = @DienThoai, DiaChi = @DiaChi 
					where MaNV = @MaNV
end
go
-- Stored procedure thay đổi thông tin tài khoản
create or alter procedure sp_UpdateAccount(
	@TenDangNhap varchar(20),
	@MatKhau varchar(30),
	@LoaiTK varchar(3),
	@MaNV varchar(10)
)as
begin
	update TaiKhoan set MatKhau = HASHBYTES('MD5', @MatKhau), LoaiTK = @LoaiTK, MaNV =@MaNV 
	where TenDangNhap = @TenDangNhap
end
go
-- Stored procedure sửa loại tài khoản
create or alter procedure sp_UpdateAccountGroup(
	@MaLoai varchar(3),
	@TenLoai nvarchar(30)
)as
begin
	update LoaiTaiKhoan set TenLoai = @TenLoai 
	where MaLoai = @MaLoai
end
go
-- Stored procedure sửa khách hàng
create or alter procedure sp_UpdateCustomer(
	@MaKH varchar(10),
	@HoTen nvarchar(100),
	@DienThoai varchar(20),
	@DiaChi nvarchar(300)
)as
begin
	update KhachHang set HoTen = @HoTen, DienThoai = @DienThoai, DiaChi = @DiaChi 
	where MaKH = @MaKH
end
go
-- Stored procedure sửa hóa đơn
create or alter procedure sp_UpdateBill(
	@SoHD int,
	@NgayDat date,
	@NgayGiao date,
	@DiaChiGiao nvarchar(300),
	@MaNV varchar(10),
	@MaKH varchar(20)
)as
begin
	update DonDatHang set NgayDat = @NgayDat, NgayGiao = @NgayGiao, DiaChiGiao = @DiaChiGiao, MaNV = @MaNV, MaKH = @MaKH
	where SoDH = @SoHD
end
go
-- Stored procedure sửa chi tiết hóa đơn
create or alter procedure sp_UpdateBillDetails(
	@SoDH int,
	@MaMatHang varchar(10),
	@SoLuong int
)as
begin
	-- dùng cursor cập nhật lại thuộc tính thành tiền
	declare cs_ThanhTien cursor for (select DonGia from MatHang where MatHang.MaMatHang = @MaMatHang)
	open cs_ThanhTien
		declare @DonGia float
	fetch next from cs_ThanhTien into @DonGia
	while @@FETCH_STATUS = 0
	begin
		update CT_DonDatHang set SoLuong = @SoLuong, ThanhTien = @SoLuong*@DonGia where SoDH = @SoDH and MaMatHang = @MaMatHang 
		fetch next from cs_ThanhTien into @DonGia
	end
	close cs_ThanhTien
	deallocate cs_ThanhTien
	---
	declare cs_TongTien cursor for (select SoDH, SUM(ThanhTien) from CT_DonDatHang where SoDH = @SoDH group by SoDH)
	open cs_TongTien
		declare @sum float,
				@DH int
	fetch next from cs_TongTien into @DH, @sum
	while @@FETCH_STATUS = 0
	begin
		update DonDatHang set TongTien = @sum where SoDH = @DH
		fetch next from cs_TongTien into @DH, @sum
	end
	close cs_TongTien
	deallocate cs_TongTien
end
go
-------------------------- Update tổng tiền cho đơn đặt hàng 
create or alter procedure sp_UpdatePrice(
	@ID int
)as
begin
	if((select count(*) from CT_DonDatHang where SoDH = @ID) = 0)
		update DonDatHang set TongTien = 0 where SoDH = @ID
	else
		begin
			declare cs_TongTien cursor for select SoDH, SUM(ThanhTien) from CT_DonDatHang where SoDH = @ID group by SoDH
			open cs_TongTien
				declare @DH int,
						@TT float
				fetch next from cs_TongTien into @DH, @TT
				while @@FETCH_STATUS = 0
					begin
						update DonDatHang set TongTien = @TT where SoDH = @DH
						fetch next from cs_TongTien into @DH, @TT
					end
			close cs_TongTien
			deallocate cs_TongTien
		end
end
go
--------------------------------------------------- STORED PROCEDURE DELETE INFORMATION--------------------------------------------------------------
-- Stored procedure xóa loại sản phẩm
create procedure sp_DeleteCategory(
	@ID varchar(10)
)as
begin
	declare cs_Delete cursor for 
			select MaMatHang from MatHang where MaLoai = @ID
		open cs_Delete
		declare @MaMatHang varchar(30)
		fetch next from cs_Delete into @MaMatHang
		while @@FETCH_STATUS = 0
			begin
				delete CT_DonDatHang where MaMatHang = @MaMatHang
				delete MatHang where MaMatHang = @MaMatHang
				fetch next from cs_Delete into @MaMatHang
			end
		close cs_Delete
		deallocate cs_Delete
	delete LoaiMatHang where MaLoai = @ID
end
go
-- Stored procedure xóa sản phẩm
create or alter procedure sp_DeleteProduct(
	@ID varchar(10)
)as
begin
	if exists(select * from CT_DonDatHang where MaMatHang = @ID)
		delete CT_DonDatHang where MaMatHang = @ID
	delete MatHang where MaMatHang = @ID
end
go
-- Stored procedure xóa thông tin nhân viên
create or alter procedure sp_DeleteEmployee(
	@ID varchar(30)
)as
begin
	if exists(select * from DonDatHang where MaNV = @ID)
	begin
		declare cs_Delete cursor for 
			select SoDH from DonDatHang where MaNV = @ID
		open cs_Delete
		declare @SoDH int
		fetch next from cs_Delete into @SoDH
		while @@FETCH_STATUS = 0
			begin
				delete CT_DonDatHang where SoDH = @SoDH
				delete DonDatHang where SoDH = @SoDH
				fetch next from cs_Delete into @SoDH
			end
		close cs_Delete
		deallocate cs_Delete
	end
	if exists(select * from TaiKhoan where MaNV = @ID)
		delete TaiKhoan where MaNV = @ID
	delete NhanVien where MaNV = @ID
end
go
-- Stored procedure xóa thông tin tài khoản
create or alter procedure sp_DeleteAccount(
	@ID varchar(50)
)as
begin
	delete TaiKhoan where TenDangNhap = @ID
end
go
-- Stored procedure xóa loại tài khoản
create or alter procedure sp_DeleteAccountGR(
	@ID varchar(50)
)as
begin
	if exists(select * from TaiKhoan where LoaiTK = @ID)
		delete TaiKhoan where LoaiTK = @ID
	delete LoaiTaiKhoan where MaLoai = @ID
end
go
-- Stored procedure xóa khách hàng
create or alter procedure sp_DeleteCustomer(
	@ID varchar(50)
)as
begin
	if exists(select * from DonDatHang where MaKH = @ID)
		delete DonDatHang where MaKH = @ID
	delete KhachHang where MaKH = @ID
end
go
-- Stored procedure xóa hóa đơn
create or alter procedure sp_DeleteBill(
	@ID int
)as
begin
	if exists(select * from CT_DonDatHang where SoDH = @ID)
		delete CT_DonDatHang where SoDH = @ID
	delete DonDatHang where SoDH = @ID
end
go
-- Stored procedure xóa chi tiết hóa đơn
create or alter procedure sp_DeleteBillDetail(
	@ID varchar(30)
)as
begin
	if exists(select * from CT_DonDatHang where MaMatHang = @ID)
		delete CT_DonDatHang where MaMatHang = @ID
end
go
--------------------------------------------------- STORED PROCEDURE LOGIN/ FORGOT PASSWORD ---------------------------------------------------------
create or alter procedure sp_login(
	@username varchar(50),
	@password varchar(50)
)as
begin
	if exists(select TenDangNhap, MatKhau, LoaiTK from TaiKhoan where TenDangNhap = @username and MatKhau = HASHBYTES('MD5', @password) and LoaiTK = 'AD')
		select 0 as code
	else if exists(select TenDangNhap, MatKhau, LoaiTK from TaiKhoan where TenDangNhap = @username and MatKhau = HASHBYTES('MD5', @password) and LoaiTK = 'KT')
		select 1 as code
	else if exists(select TenDangNhap, MatKhau, LoaiTK from TaiKhoan where TenDangNhap = @username and MatKhau = HASHBYTES('MD5', @password))
		select 2 as code
	else if not exists(select TenDangNhap, MatKhau, LoaiTK from TaiKhoan where TenDangNhap = @username and MatKhau = HASHBYTES('MD5', @password))
		select -1 as code
end
go
-------------------------------------------------- STORED PROCEDURE Report --------------------------------------
create view ViewReport as
	select khachHang.MaKH as N'Mã KH', KhachHang.HoTen as N'Họ tên', DonDatHang.SoDH as N'Số HD', DonDatHang.NgayDat as N'Ngày đặt', DonDatHang.TongTien as N'Tổng tiền' 
	from KhachHang inner join DonDatHang on KhachHang.MaKH = DonDatHang.MaKH
go
create or alter procedure sp_Report(
	@NgayBD date,
	@NgayKT date
)as
begin
	select vr.[Mã KH], vr.[Họ tên], vr.[Số HD], vr.[Ngày đặt], vr.[Tổng tiền]
	from ViewReport vr
	where vr.[Ngày đặt] >= @NgayBD and vr.[Ngày đặt] <= @NgayKT
end
go
--------------------------------------------------- STORED PROCEDURE invoice ------------------------------
create or alter view ViewInvoice as
	select MatHang.MaMatHang as N'Mã MH', MatHang.TenMatHang as N'Tên mặt hàng', CT_DonDatHang.SoLuong as N'Số lượng', CT_DonDatHang.ThanhTien as N'Thành tiền', CT_DonDatHang.SoDH, HoTen, DienThoai, DiaChi
	from ((MatHang inner join CT_DonDatHang on MatHang.MaMatHang = CT_DonDatHang.MaMatHang) inner join DonDatHang on CT_DonDatHang.SoDH = DonDatHang.SoDH) inner join KhachHang on DonDatHang.MaKH = KhachHang.MaKH
go
create or alter procedure sp_Invoice(
	@ID int
)as
begin
	select  VI.SoDH, VI.[Mã MH], VI.[Tên mặt hàng], VI.[Số lượng], VI.[Thành tiền], VI.HoTen, VI.DienThoai, VI.DiaChi
	from ViewInvoice VI where VI.SoDH = @ID
end
go
sp_AddAccountGroup 'AD' , 'Admin'
go
sp_AddAccountGroup 'KT' , N'Kế toán'
go
sp_AddAccountGroup 'NV' , N'Nhân viên'
go
sp_AddEmployee '1097513695', N'Quang Qui', '6-1-2001', 'Nam', '0126351269', N'Long An'
go
sp_AddAccount 'admin', 'admin', 'AD', '1097513695'
