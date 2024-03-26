# **Tổng quan**
+ Đồ án môn học Công Nghệ Phần Mềm
  - Tên đề tài: CỬA HÀNG THỜI TRANG 3TN
  - Mô tả: Quản lý cho một cửa hàng thời trang
  - GVHD: **ThS. Nguyễn Hữu Trung**.
+ Thành viên:
  - [Phan Anh Thăng](https://github.com/thanqphan)	MSSV: 2011069025
  - [Vũ Lê Anh Thi](https://github.com/Anhthi0210)	  2011061865
  - [Huỳnh Thị Trúc Ngân](https://github.com/tNgan23)	  2011064432
  - Ngô Hoài Phát Tấn	  2011110597
+ Công nghệ:
  - Ngôn ngữ: C#
  - Môi trường: .Net Framework 4.6
  - Database: SQL Server
+ Mã nguồn: [https://github.com/thanqphan/3TN_SHOP](https://github.com/thanqphan/3TN_SHOP)
# Mục lục
- [Tổng quan](#tổng-quan)
- [Mục lục](#mục-lục)
- Khảo sát hiện trạng
- 1. [Khảo sát hiện trạng](#1-khảo-sát-hiện-trạng)
- 2. xác định yêu cầu
# 1. Khảo sát hiện trạng.
## 1.1. Khảo sát hiện trạng.
### 1.1.1. Hiện trạng tổ chức.
- Cơ cấu tổ chức của Cửa hàng: với quy mô cửa hàng nhỏ chuyên cung cấp các mặt hàng thời trang theo xu thế và yêu cầu của khách hàng.
  ![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/Hientrangtochuc.png).
-	Gồm 4 bộ phận với vai trò riêng – không ảnh hưởng đến nhau:
    +	Bộ phận Quản lý: quản lý toàn bộ cửa hàng – mọi nghiệp vụ dưới quyền. Chịu trách nhiệm phân chia công việc đặc thù cho các bộ phận dưới quyền mình.
    +	Bộ phận Thủ kho: quản lý kho tại của hàng. Nhập hàng, trả hàng và cập nhật thông tin sản phẩm. Thống kê tồn Kho của sản phẩm nếu được yêu cầu.
    +	Bộ phận Thu Ngân: quản lý tại quầy thu ngân. Lập hóa đơn, thanh toán cho khách – trả sản phẩm nếu có. Thống kê Doanh thu của cửa hàng theo mốc thời gian được yêu cầu.
    +	Bộ phận Phục vụ: nhận nhiệm vụ tiếp khách, tư vấn và mang hàng đến quầy thu ngân để thanh toán.
### 1.1.2. Hiện trạng nghiệp vụ.
-	Các hoạt động nghiệp vụ được tóm tắt như sau:
    +	Cửa hàng nhập hàng từ Nhà cung cấp thông qua Phiếu nhập từ bộ phân kho thống kê khi kiểm tra lại mặt hàng tồn trong kho hàng.
    +	Mặt hàng được cập nhật các thông tin cơ bản bởi bộ phân kho để có thể cập nhật thông tin nhanh chóng cho bộ phận thu ngân.
    +	Phần mềm được sử dụng bởi Quản lý, Thu ngân và Thủ kho. Mỗi nhân viên có chức vụ này sẽ được Quản lý cấp tài khoản và mật khẩu tương ứng để đăng nhập vô hệ thống.
    +	Mỗi nhân viên tại của hàng sẽ được cập nhật thông tin như tên, tuổi, ngày sinh, chức vụ… đầy đủ trên hệ thống để tiện chỉnh sửa thông tin.
    +	Khi thanh toán, hóa đơn của khách hàng khi đặt ngưỡng thanh toán để tính điểm sẽ được lưu lại thông tin và số điểm tích lũy sẽ được cộng dồn theo giá trị hóa đơn tương ứng để giảm giá vào những lần thanh toán kế tiếp.
    +	Trong bán hàng, khi khách yêu cầu đổi trả hàng hóa thì yêu cầu khách thay bằng những sản phẩm tương đương hoặc thấp hơn số tiền đổi trả.
-	Nghiệp vụ:
    +	Quản lý Nhập Kho.
    +	Quản lý Sản phẩm.
    +	Quản lý Tài khoản.
    +	Quản lý Nhân viên.
    +	Quản lý Khách hàng.
    +	Quản lý Hóa đơn. 
    +	Quản lý Phiếu nhập.
    +	Quản lý Nhà cung cấp.
    +	Thống kê:
    + Thống kê Doanh thu.
    + Thống kê Phiếu nhập.
    + Thống kê Hóa đơn.
## 1.2. Xác định yêu cầu.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/Xacdinhyeucauchucnang.png).
-	Người sử dụng dễ dàng sử dụng phần mềm: trực quan, dễ nhìn, thao tác thuận tiện.
-	Thông tin thống kê phải đảm báo tính chính xác, khách quan.
# 2. Mô hình hóa.
## 2.1. Mô hình hóa biểu đồ chức năng (Usecase).
### 2.1.1. Usecase Tổng quát.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseTongquat.png)
### 2.1.2. Usecase Quản lý Tài khoản.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlytaikhoan.png)
### 2.1.3. Usecase Quản lý Nhân viên.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlynhanvien.png)
### 2.1.4. Usecase Quản lý Hóa đơn.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlyhoadon.png)
### 2.1.5. Usecase Quản lý Bán hàng.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlybanhang.png)
### 2.1.6. Usecase Quản lý Sản Phẩm.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlysanpham.png)
### 2.1.7. Usecase Quản lý Nhập Hàng.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlynhaphang.png)
### 2.1.8. Usecase Thống kê.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseThongke.png)
### 2.1.9. Usecase Quản lý Khách Hàng.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlykhachhang.png)
### 2.1.10. Usecase Quản lý Nhà Cung Cấp.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/usecaseQuanlyncc.png)
## 2.2. Biểu đồ cơ sở dữ liệu quan hệ(Class Diagram).
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/Classdiagram.png)
# 3. Thiết kế giao diện.
## 3.1. Phác thảo giao diện
### 3.1.1. Giao diện Đăng nhập.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/frmdangnhap.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|PictureBox|picLogo|Hiển thị Logo của của hàng|
|PictureBox|picShow|Ẩn hiện Mật khẩu được nhập|
|TextBox|txtName|Nơi Nhập tên đăng nhập|
|TextBox|txtPass|Nơi nhập mật khẩu |
|Button|btnDangNhap|Kiểm tra mật khẩu – tên có hợp lệ không, sau đó dẫn đến giao diện chính.|
### 3.1.2. Giao diển Trang chủ - Tổng quan.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodienchinh.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Panel|pnlMain|Chứa các button chức năng chính.|
||pnlUserControl|Không gian chứa UserControl tương ứng từng chức năng.|
||pnlThuNgan|Chứa các chức năng Thu Ngân.|
||pnlKhoHang|Chứa các chức năng Kho Hàng |
||pnlQuanLi|Chứa các chức năng Quản lí.|
||pnlThongKe|Chứa các chức năng Thống kê.|
||pnlHeThong|Chứa các chức năng Hệ thống.|
|PictureBox|picLogo|Logo Shop.|
||picExit|Thoát Chương trình.|
||picLogout|Đăng xuất.|
|Button|btnMain|Hiển thị Trang chủ - Tổng quan.|
||btnThuNgan|Hiển thị ra panel chứa chức năng Thu Ngân.|
||btnBanHang|Hiển thị UsC thao tác Thanh toán với khách.|
||btnHoaDon|Hiển thị UsC hiển thị Danh sách Hóa đơn trong CSDL.|
||btnKhoHang|Hiển thị panel chứa chức năng trong Kho hàng.|
||btnNhapHang|Hiển thị UsC thao tác Nhập hàng.|
||btnSanPham|Hiển thị UsC hiển thị Danh sách Sản phẩm trong CSDL|
||btnQuanLi|Hiển thị panel chứa các chức năng Quản lí.|
||btnNV|Hiển thị UsC thao tác với đối tượng Nhân Viên.|
||btnNCC|Hiển thị UsC thao tác với dối tượng Nhà Cung Cấp.|
||btnKhachHang|Hiển thị UsC thao tác với đổi tượng Khách hàng.|
||btnThongKe|Hiển thị panel chứa các chức năng Thống kê.|
||btnTKTK|Hiển thị UsC thao tác để Thống kê tồn kho.|
||btnTKPN|Hiển thị UsC thao tác để Thống kê phiếu nhập.|
||btnTKDTHiển thị UsC thao tác để Thống kê doanh thu.|
||btnHeThong|Hiển thị panel chứa chức năng hê thống.|
||btnTaiKhoan|Hiển thị UsC thao tác với đối tượng Tài khoản trong hệ thống.|
||btnNameUser|Hiển thị tên Nhân viên đang sử dụng hệ thống.|
### 3.1.3. Giao diện Hóa Đơn.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodienhoadon.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label|lblSoHD|Hiển thị tổng số hóa đơn được thanh toán trong ngày.|
||lblSoHD|Hiển thị tổng tiền thu được trong ngày.|
|DateEdit|dateHD|Hiển thị ngày làm cột mốc hiển thị.|
|ChartControl|ChartSP|Hiển thị biểu đồ sản phẩm bán chạy trong ngày.|
|PictureBox|picBill|Hiển thị ảnh Bill.|
||picDoanhThu|Hiển thị ảnh Doanh thu.|
### 3.1.4. Giao diện Nhập hàng.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodiennhaphang.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|TextBox|txtIDPN|Chứa thông tin mã phiếu nhập|
||tztIDNCC|Chứa thông tin mã nhà cung cấp|
||txtIDNV|Chứa thông tin mã nhân viên|
|PictureBox|picBoxNCC|Hiển thị danh sách nhà cung cấp|
||picBoxNV|Hiển thị danh sách nhân viên|
||picSearch|Tìm kiếm theo các thông tin tương ứng|
||picReset|Reset lại thông tin được nhập|
|Button|btnXuat|Xuất phiếu nhập|
||btnNhap|Hiển thị giao diện nhập hàng|
||btnXoa|Xóa phiếu được chọn|
|DataGridView|dgvDS|Danh sách phiếu nhập.|
### 3.1.5. Giao diện Sản phẩm.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodiensanpham.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label|	lblID	|Hiển thị mã sản phẩm|
||lblName	|Hiển thị tên sản phẩm|
||lblMau|	Hiển thị màu sản phẩm|
||lblSize|	Hiển thị Size sản phẩm|
||lblLoaiSP|	Hiển thị loại sản phẩm|
||lblSL	|Hiển thị số lượng sản phẩm|
||lblTenSP1-9	|Hiển thị tên sản phẩm của các sản phẩm|
||lblTrangThai	|Hiển thị trạng thái của sản phẩm|
|PictureBox	|picSP	|Hiển thị hình ảnh sản phẩm|
||Pic1-9|	Hiển thị hình ảnh sản phẩm của các sản phẩm|
|Button	|btnUpdate	|Cập nhật thông tin sản phẩm|
||btnNgungKD	|Chuyển trạng thái kinh doanh của sản phẩm|
||btnThem	|Thêm 1 sản phẩm mới trong CSDL|
||btnXoa	|Xóa sản phẩm hiện tại khỏi CSDL|
|TextBox	|txtTimKiem	|Chứa thông tin sản phẩm cần tìm|
### 3.1.6. Giao diện Nhân viên.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodiennhanvien.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label	|lblID	|Hiển thị mã Nhân viên|
||lblName	|Hiển thị tên nhân viên|
||lblGT	|Hiển thị giới tính Nhân viên|
||lblNgSinh	|Hiển thị Ngày sinh Nhân viên|
||lblSDT	|Hiển thị số điện thoại nhân viên|
||lblDiaChi	|Hiển thị địa chỉ của nhân viên|
||lblChucVu	|Hiển thị chức vụ của nhân viên|
|Button	|btnUpdate	|Cập nhật thông tin nhân viên|
||btnDel	|Xóa thông tin nhân viên|
||btnAdd	|Thêm mới 1 nhân viên|
|TextBox	|txtTimKiem	|Nhập thông tin nhân viên cần tìm|
|DataGridView	|dgvDS	|Danh sách Nhân viên|
### 3.1.7. Giao diện Nhà Cung Cấp.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodienncc.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label	|lblID	|Hiển thị mã Nhà cung cấp|
||lblName	|Hiển thị tên Nhà cung cấp|
||lblSDT	|Hiển thị số điện thoại Nhà cung cấp|
||lblDiaChi	|Hiển thị địa chỉ của Nhà cung cấp|
|Button	|btnUpdate	|Cập nhật thông tin Nhà cung cấp|
||btnDel	|Xóa thông tin Nhà cung cấp|
||btnAdd	|Thêm mới 1 Nhà cung cấp|
|TextBox	|txtTimKiem	|Nhập thông tin Nhà cung cấp cần tìm|
|DataGridView	|dgvDS	|Danh sách Nhà cung cấp|
### 3.1.8. Giao diện Khách Hàng.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodienkhachhang.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label	|lblID	|Hiển thị mã khách hàng.|
||lblName	|Hiển thị tên khách hàng.|
||lblSDT	|Hiển thị số điện thoại khách hàng.|
||lblDiemTL	|Hiển thị số điểm khách tích lũy được.|
||lblGT	|Hiển thị giới tính của khách hàng.|
||lblLoai	|Hiển thị loại khách hàng.|
|Button	|btnUpdate	|Cập nhật thông tin khách hàng.|
||btnDel	|Xóa thông tin khách hàng.|
||btnAdd	|Thêm 1 khách hàng mới.|
|TextBox	|txtTimKiem	|Tìm kiếm khách hàng.|
|DataGridView	|dgvDS	|Hiển thị danh sách khách hàng.|
### 3.1.9. Giao diện Thống kê Tồn Kho.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodientonkho.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|ChartControl	|chartSP	|Hiển thị biểu đồ những sản phẩm nổi bật trong CSDL.|
|DataGridView	|dgvDS	|Hiển thị danh sách sản phẩm của cửa hàng.|
|TextBox	|txtTimKiem	|Tìm kiếm sản phẩm.|
### 3.1.10. Giao diện Thống kê Phiếu Nhập.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodienphieunhap.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label	|lblSL	|Hiển thị số phiếu nhập tương ứng.|
|RadioButton	|radDate	|Hiển thị danh sách phiếu nhập trong ngày.|
||radMonth	|Hiển thị danh sách phiếu nhập trong tháng.|
||radYear	|Hiển thị danh sách phiếu nhập trong năm.|
|DateEdit	|dateHD	|Ngày được chọn.|
|DataGridView	|dgvDS	|Hiển thị danh sách phiếu nhập tương ứng.|
|PictureBox	|picPN	|Hiển thị ảnh tương ứng.|
|Button	|btnXuat	|Xuất file chưa danh sách phiếu nhập tương ứng.|
### 3.1.11. Giao diện Thống kê Doanh thu.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodiendoanhthu.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|DateEdit	|dateHD	|Hiển thị ngày thống kê tương ứng.|
|PictureBox	|picHD	|Hiển thị ảnh tương ứng.|
||	picDT	|Hiển thị ảnh tương ứng.|
|Label	|lblHD	|Hiển thị số lượng hóa đơn tương ứng theo mốc.|
||	lblDT	|Hiển thị số doanh thu đạt được tương ứng.|
|Button	|btnXuat	|Xuất file danh sách hóa đơn trong thời gian tương ứng.|
|DataGridView	|dgvDS	|Hiển thị danh sách hóa đơn tương ứng.|
### 3.1.12. Giao diện Tài Khoản.
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/giaodientaikhoan.png)
|            |Tên              |Chức năng                                         |
|:----------:|:---------------:|:------------------------------------------------:|
|Label	|lblName	|Hiển thị tên tài khoản|
||lblIDNV	|Hiển thị mã nhân viên sở hữu tài khoản|
|TextBox	|txtPass	|Chứa mật khẩu của tài khoản|
|DataGridView	|dgvDS	|Hiển thị danh sách các tài khoản trong hệ thống|
|Button	|btnUpdate	|Cập nhật thông tin tài khoản|
||btnAdd	|Thêm tài khoản mới|
||btnDel	|Xóa tài khoản được chọn|
# 4. Thiết kế cơ sở dử liệu.
## 4.1. Thiết kế cơ sở dữ liệu.
![]()
## 4.2. Thiết kế lớp chi tiết.
# 5. Kiểm thử
## 5.1. Phân vùng.
### 5.1.1. Mật khẩu Tài Khoản.
### 5.1.2. Ngày sinh Nhân viên.
### 5.1.3. Điểm tích lũy Khách hàng.
## 5.2. Test case – Đoán lỗi.
### 5.2.1. Testcase Đăng nhập.
### 5.2.2. Test case Thêm Nhân Viên.
### 5.2.3. Test case Thêm Tài khoản.
# 6. Nhận xét - đánh giá.
## 6.1. Phần mềm – Chương trình
### 6.1.1. Chức năng đã hoàn thành.
### 6.1.2. Chức năng chưa hoàn thành – phát triển sau.
## 6.2. Quá trình làm việc – Việc nhóm.
### 6.2.1. Phân công việc.
### 6.2.2. Khó khăn.
