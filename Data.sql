use VatLieuXayDung
go
insert into LoaiMatHang(MaLoai, TenLoai) values
			('L7300', N'Cát'),
			('L2046', N'Đá'),
			('L1079', N'Xi măng'),
			('L1800', N'Gạch ốp tường'),
			('L3942', N'Gạch ống'),
			('L8959', N'Gạch lát nền')
go
insert into MatHang(MaMatHang, TenMatHang, DonViTinh, DonGia, MaLoai) values
			('MH11900984', N'Đá xây dựng 5x7', N'm3', 280000, 'L2046'),
			('MH40333900', N'Đá xây dựng 1x2( đen)', N'm3', 280000, 'L2046'),
			('MH13992831', N'Đá xây dựng 1x2( xanh)', N'm3', 415000, 'L2046'),
			('MH15895809', N'Đá mi bụi', N'm3', 240000, 'L2046'),
			('MH96055484', N'Đá mi sàng', N'm3', 265000, 'L2046'),
			('MH69784886', N'Xi măng Vissai PCB40( bao)', N'tấn', 1000000, 'L1079'),
			('MH20947936', N'Xi măng Vissai PCB30( bao)', N'tấn', 930000, 'L1079'),
			('MH37412808', N'Xi măng Hoàng Long PCB40( bao)', N'tấn', 950000, 'L1079'),
			('MH15628119', N'Cát xây tô', N'm3', 150000, 'L7300'),
			('MH27171903', N'Cát san lấp', N'm3', 145000, 'L7300'),
			('MH83240305', N'Cát bê tông loại 1', N'm3', 220000, 'L7300'),
			('MH44908071', N'Cát bê tông loại 2', N'm3', 200000, 'L7300'),
			('MH12335893', N'Gạch ống Thành Tâm 8x8x18', N'viên', 1.090, 'L3942'),
			('MH75196905', N'Gạch đinh Thành Tâm 4x8x18', N'viên', 1.090, 'L3942'),
			('MH13124588', N'Gạch ống Phước Thành 8x8x18', N'viên', 1.080, 'L3942'),
			('MH11795803', N'Gạch đinh Phước Thành 4x8x18', N'viên', 1.080, 'L3942'),
			('MH82041485', N'Gạch ống Đồng Tâm 17 8x8x18', N'viên', 950, 'L3942'),
			('MH11726962', N'Gạch đinh Đồng Tâm 8x8x18', N'viên', 950, 'L3942'),
			('MH10083610', N'Đá tự nhiên có nguồn gốc Thanh Hóa 40x40', N'tấm', 300000, 'L8959'),
			('MH18047223', N'Gạch lát nền Đồng Tâm 60x60', N'tấm', 358500, 'L8959'),
			('MH29339456', N'Gạch lát nền Đồng Tâm 80x80', N'tấm', 371000, 'L8959'),
			('MH72357709', N'Đá bóng kính Catalan', N'tấm', 192000, 'L8959'),
			('MH94603183', N'Gạch ốp tường Đồng Tâm 40x80', N'tấm', 295000, 'L1800'),
			('MH11613620', N'Gạch ốp tường Đồng Tâm 30x60', N'tấm', 275000, 'L1800')
go
insert into KhachHang(MaKH, HoTen, DienThoai, DiaChi) values
			('KH46427766', N'Nguyễn Văn A', '0126325426', N'123/2, THD'),
			('KH16618327', N'Trần Hùng', '0185256931', N'178/3, TVD'),
			('KH21484704', N'Lê Lâm', '0456236985', N'154 THS'),
			('KH17257976', N'Lý Tứ', '0451236525', N'153, TFV'),
			('KH45870612', N'Trương Tam', '0123523120', N'461, HKF')
go
sp_AddBill '2021-1-11', '2021-1-11', N'123/2, THD', '1097513695', 'KH46427766'
go
sp_AddBill '2021-3-11', '2021-3-15', N'178/3, TVD', '1097513695', 'KH16618327'
go
sp_AddBill '2021-8-11', '2021-8-20', N'154 THS', '1097513695', 'KH21484704'
go
sp_AddBill '2021-10-11', '2021-10-12', N'153, TFV', '1097513695', 'KH17257976'
go
sp_AddBill '2021-12-11', '2021-12-15', N'461, HKF', '1097513695', 'KH45870612'
go
sp_AddBillDetails 1, 'MH15628119', 5
go
sp_AddBillDetails 1, 'MH11613620', 200
go
sp_AddBillDetails 1, 'MH11726962', 2000
go
sp_AddBillDetails 1, 'MH20947936', 50
go
sp_AddBillDetails 2, 'MH27171903', 10
go
sp_AddBillDetails 2, 'MH15628119', 10
go
sp_AddBillDetails 2, 'MH13992831', 15
go
sp_AddBillDetails 2, 'MH37412808', 8
go
sp_AddBillDetails 3, 'MH15628119', 20
go
sp_AddBillDetails 3, 'MH18047223', 200
go
sp_AddBillDetails 3, 'MH69784886', 10
go
sp_AddBillDetails 4, 'MH15628119', 20
go
sp_AddBillDetails 4, 'MH18047223', 200
go
sp_AddBillDetails 4, 'MH69784886', 10
go
sp_AddBillDetails 5, 'MH15628119', 20
go
sp_AddBillDetails 5, 'MH18047223', 200
go
sp_AddBillDetails 5, 'MH69784886', 10
go


select * from CT_DonDatHang
select * from DonDatHang 
select * from MatHang
select * from NhanVien
select * from KhachHang
select * from DonDatHang
select * from TaiKhoan
select * from LoaiTaiKhoan