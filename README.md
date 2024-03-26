# **Tổng quan**
+ Đồ án môn học Công Nghệ Phần Mềm
  - Tên đề tài: CỬA HÀNG THỜI TRANG 3TN
  - Mô tả: Quản lý cho một cửa hàng thời trang
  - GVHD: **ThS. Nguyễn Hữu Trung**.
+ Thành viên:
  - [Phan Anh Thăng](https://github.com/thanqphan) MSSV: 2011069025
  - [Vũ Lê Anh Thi](https://github.com/Anhthi0210) MSSV: 2011061865
  - [Huỳnh Thị Trúc Ngân](https://github.com/tNgan23) MSSV: 2011064432
  - Ngô Hoài Phát Tấn MSSV: 2011110597
+ Công nghệ:
  - Ngôn ngữ: C#
  - Môi trường: .Net Framework 4.6
  - Database: SQL Server
+ Mã nguồn: [https://github.com/thanqphan/3TN_SHOP](https://github.com/thanqphan/3TN_SHOP)
# Mục lục
- [Tổng quan](#tổng-quan)
- [Mục lục](#mục-lục)
- 1. [Khảo sát hiện trạng](#1-khảo-sát-hiện-trạng).
  - 1.1. [Khảo sát hiện trạng](#11-khảo-sát-hiện-trạng).
    - 1.1.1. [Hiện trạng tổ chức](#111-hiện-trạng-tổ-chức).
    - 1.1.2. [Hiện trạng nghiệp vụ](#112-hiện-trạng-nghiệp-vụ).
  - 1.2. [Xác định yêu cầu.](#12-xác-định-yêu-cầu).
- 2. [Mô hình hóa.](#2-mô-hình-hóa).
  - 2.1. [Mô hình hóa biểu đồ chức năng (Usecase)](#21-mô-hình-hóa-biểu-đồ-chức-năng-usecase).
    - 2.1.1. [Usecase Tổng quát.](#211-usecase-tổng-quát)
    - 2.1.2. [Usecase Quản lý Tài khoản.](#212-usecase-quản-lý-tài-khoản)
    - 2.1.3. [Usecase Quản lý Nhân viên](#213-usecase-quản-lý-nhân-viên).
    - 2.1.4. [Usecase Quản lý Hóa đơn.](#214-usecase-quản-lý-hóa-đơn)
    - 2.1.5. [Usecase Quản lý Bán hàng.](#215-usecase-quản-lý-bán-hàng)
    - 2.1.6. [Usecase Quản lý Sản Phẩm.](#216-usecase-quản-lý-sản-phẩm)
    - 2.1.7. [Usecase Quản lý Nhập Hàng.](#217-usecase-quản-lý-nhập-hàng)
    - 2.1.8. [Usecase Thống kê.](#218-usecase-thống-kê)
    - 2.1.9. [Usecase Quản lý Khách Hàng.](#218-usecase-thống-kê)
    - 2.1.10. [Usecase Quản lý Nhà Cung Cấp.](#2110-usecase-quản-lý-nhà-cung-cấp)
  - 2.2. [Biểu đồ cơ sở dữ liệu quan hệ(Class Diagram).](#22-biểu-đồ-cơ-sở-dữ-liệu-quan-hệclass-diagram)
- 3. [Thiết kế giao diện.](#3-thiết-kế-giao-diện)
  - 3.1. Phác thảo giao diện.
    - 3.1.1. [Giao diện Đăng nhập.](#311-giao-diện-đăng-nhập)
    - 3.1.2. [Giao diển Trang chủ - Tổng quan.](#312-giao-diển-trang-chủ---tổng-quan)
    - 3.1.3. [Giao diện Hóa Đơn.](#313-giao-diện-hóa-đơn)
    - 3.1.4. [Giao diện Nhập hàng.](#314-giao-diện-nhập-hàng)
    - 3.1.5. [Giao diện Sản phẩm.](#315-giao-diện-sản-phẩm)
    - 3.1.6. [Giao diện Nhân viên.](#316-giao-diện-nhân-viên)
    - 3.1.7. [Giao diện Nhà Cung Cấp.](#317-giao-diện-nhà-cung-cấp)
    - 3.1.8. [Giao diện Khách Hàng.](#318-giao-diện-khách-hàng)
    - 3.1.9. [Giao diện Thống kê Tồn Kho.](#319-giao-diện-thống-kê-tồn-kho)
    - 3.1.10. [Giao diện Thống kê Phiếu Nhập.](#3110-giao-diện-thống-kê-phiếu-nhập)
    - 3.1.11. [Giao diện Thống kê Doanh thu.](#3111-giao-diện-thống-kê-doanh-thu)
    - 3.1.12. [Giao diện Tài Khoản.](#3112-giao-diện-tài-khoản)
- 4. [Thiết kế cơ sở dử liệu.](#4-thiết-kế-cơ-sở-dử-liệu)
  - 4.1. [Thiết kế cơ sở dữ liệu.](#41-thiết-kế-cơ-sở-dữ-liệu)
    - 4.1.1. [Bảng khách hàng.](#41-thiết-kế-cơ-sở-dữ-liệu)
    - 4.1.2. [Bảng tài khoản.](#412-bảng-tài-khoản)
    - 4.1.3. [Bảng chi tiết hóa đơn.](#413-bảng-chi-tiết-hóa-đơn)
    - 4.1.4. [Bảng chi tiết phiếu nhập.](#414-bảng-chi-tiết-phiếu-nhập)
    - 4.1.5. [Bảng hóa đơn.](#415-bảng-hóa-đơn)
    - 4.1.6. [Bảng loại sản phẩm.](#416-bảng-loại-sản-phẩm)
    - 4.1.7. [Bảng nhà cung cấp.](#417-bảng-nhà-cung-cấp)
    - 4.1.8. [Bảng nhân viên.](#418-bảng-nhân-viên)
    - 4.1.9. [Bảng phiếu nhập.](#419-bảng-phiếu-nhập)
    - 4.1.10. [Bảng sản phẩm.](#4110-bảng-sản-phẩm)
  - 4.2. [Thiết kế lớp chi tiết.](#42-thiết-kế-lớp-chi-tiết)
- 5. [Nhận xét - đánh giá.](#5-nhận-xét---đánh-giá)
  - 5.1. [Phần mềm – Chương trình](#51-phần-mềm--chương-trình)
    - 5.1.1. [Chức năng đã hoàn thành.](#511-chức-năng-đã-hoàn-thành)
    - 5.1.2. [Chức năng chưa hoàn thành – phát triển sau.](#512-chức-năng-chưa-hoàn-thành--phát-triển-sau)
  - 5.2. [Quá trình làm việc – Việc nhóm.](#52-quá-trình-làm-việc--việc-nhóm)
    - 5.2.1. [Phân công việc.](#521-phân-công-việc)
    - 5.2.2. [Khó khăn.](#522-khó-khăn)
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
![](https://github.com/thanqphan/3TN_SHOP/blob/master/GUI/Resources/csdl.png)
### 4.1.1. Bảng khách hàng.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaKH	              |Mã Khách hàng	                |Varchar(20)		     |Khóa chính             |
|HoTen	|Họ và tên Khách hàng	|Nvarchar(50)||	
|DiemTichLuy	|Điểm tích lũy của Khách hàng	|Int|	|
|SDT	|Số điện thoại của Khách hàng	|Varchar(12)|	|
|GioiTinh	|Giới tính khách hàng	|Nvarchar(20)||
### 4.1.2. Bảng tài khoản.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|TenTK	|Tên tài khoản	|Varchar(20)	|Khóa chính|
|MatKhau	|Mật khẩu tài khoản	|Varchar(20)||	
|MaNV	|Mã nhân viên thuộc tài khoản	|Varchar(20)	|ID nằm trong dto.NHANVIEN|
### 4.1.3. Bảng chi tiết hóa đơn.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaHD	|Mã Hóa đơn	|Varchar(20)|	ID tồn tại trong dto.HOADON|
|MaSP	|Mã Sản phẩm	Varchar(20)|	ID tồn tại tring dto.SANPHAM|
|DonGia	|Đơn giá của 1 sản phẩm	|Money||	
|SoLuongBan	|Số lượng sản phẩm được bán	|int	||
### 4.1.4. Bảng chi tiết phiếu nhập.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaPN	|Mã Phiếu nhập	|Varchar(20)	|ID tồn tại trong dto.PHIEUNHAP|
|MaSP	|Mã Sản phẩm	|Varchar(20)	|ID tồn tại tring dto.SANPHAM|
|SoLuongNhap	|Số lượng sản phẩm được nhập	|Int||	
|TongTien	|Tổng thành tiền sản phẩm được nhập	|money	||
### 4.1.5. Bảng hóa đơn.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaHD	|Mã Phiếu nhập	|Varchar(20)	|Khóa chính|
|NgLap	|Mã Sản phẩm	|Date	||
|MaKH	|Mã Khách hàng	|Varchar(20)	|ID tồn tại tring dto.KHACHHANG|
|MaNV	|Mã Nhân viên	|Varchar(20)	|ID tồn tại tring dto.NHANVIEN|
|TongSL	|Tổng số lượng mua	|Int||	
|TongThanhTien	|Tổng thành tiền 	|Money	||
|TienGiamGia	|Tiền giảm giá dựa vào điểm tích lũy	|Money||	
|TongTien	|Thành tiền cuối cùng	|money	||
### 4.1.6. Bảng loại sản phẩm.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaLoaiSP	|Mã loại sản phẩm	|Varchar(20)	|Khóa chính|
|TenLoaiSP	|Tên loại sản phẩm	|Nvarchar(50)||	
### 4.1.7. Bảng nhà cung cấp.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaNCC	|Mã nhà cung cấp	|Varchar(20)	|Khóa chính|
|TenNCC	|Tên nhà cung cấp	|Nvarchar(50)||	
|DiaChi	|Địa chỉ nhà cung cấp	|Nvarchar(50)	||
|SDT	|Điện thoại liên lạc nhà cung cấp	|Varchar(12)	||
|TrangThai	|Trạng thái hợp tác của nhà cung cấp	|Nvarchar(20)||	
### 4.1.8. Bảng nhân viên.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaNV	|Mã nhân viên	|Varchar(20)	|Khóa chính|
|HoTen	|Họ và tên nhân viên	|Nvarchar(50)	||
|DiaChi|	Địa chỉ nhân viên 	|Nvarchar(50)	||
|SDT	|Số điện thoại liên lạc	|Varchar(12)||	
|GT	|Giới tính nhân viên	|Nvarchar(10)	||
|NgSinh	|Ngày sinh nhân viên	|Date	||
|ChucVu	|Chức vụ nhân viên	|Nvarchar(30)	||
### 4.1.9. Bảng phiếu nhập.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaPN	|Mã phiếu nhập	|Varchar(20)	|Khóa chính|
|NgLap	|Ngày lập phiếu nhập	|Date	||
|MaNCC	|Mã nhà cung cấp	|Varchar(20)	|ID nằm trong dto.NHACUNGCAP|
|MaNV	|Mã nhân viên	|Varchar(20)|	ID nằm trong dto.NHANVIEN|
|TongSL	|Tổng số lượng sản phẩm nhập vào	|Int	||
|TongThanhTien	|Tổng tiền nhập 	|Money	||
|GiaTrietKhau	|Phần trăm triết khấu nhập	|Varchar(20)	||
|TongTienNhap	|Tổng tiền nhập	|Money||	
|Note	|Ghi chú liên quan đến nhập hàng	|Nvarchar(max)||	
### 4.1.10. Bảng sản phẩm.
|Tên thuộc tính     |Diễn giải                      |Kiểu dữ liệu        |Ràng buộc              |
|:-----------------:|:-----------------------------:|:------------------:|:---------------------:|
|MaSP	|Mã sản phẩm	|Varchar(20)|	Khóa chính|
|TenSP	|Tên sản phẩm	|Nvarchar(50)	||
|MauSP	|Màu sản phẩm 	|Nvarchar(20)||	
|SizeSP	|Size sản phẩm	|Varchar(10)	||
|DonGia	|Đơn giá sản phẩm 	|Money||	
|MaLoaiSP	|Mã loại sản phẩm	|Varchar(20)	|ID nằm trong dto.SANPHAM|
|SoLuongKho 	|Số lượng sản phẩm trong kho	|Int	||
|TrangThai	|Trạng thái của sản phẩm	|Nvarchar(20)	||
## 4.2. Thiết kế lớp chi tiết.
-	Sử dụng mô hình 3 lớp và xây dựng:
 - **Presentation Layer**: Lớp này làm nhiệm vụ giao tiếp với người dùng cuối để thu thập dữ liệu và hiển thị kết quả/dữ liệu thông qua các thành phần trong giao diện người sử dụng.
 - **Business Logic Layer**: Lớp này thực hiện các nghiệp vụ chính của hệ thống, sử dụng các dịch vụ do lớp Data Access cung cấp, và cung cấp các dịch vụ cho lớp Presentation.
 - **Data Access Layer**: Lớp này thực hiện các nghiệp vụ liên quan đến lưu trữ và truy xuất dữ liệu của ứng dụng.
# 5. Nhận xét - đánh giá.
## 5.1. Phần mềm – Chương trình
### 5.1.1. Chức năng đã hoàn thành.
-	Các chức năng : Thêm, Xóa, Sửa, Tìm kiếm.
-	Report in hóa đơn, Report phiếu nhập.
-	Xuất file .excel Thống kê Doanh thu, phiếu nhập, hóa đơn.
-	Phân quyền đăng nhập.
-	Tính % giảm giá của khách hàng theo điểm tích lũy.
-	Thanh toán
### 5.1.2. Chức năng chưa hoàn thành – phát triển sau.
-	Tích điểm sau Thanh toán.
-	Khách hàng sử dụng trực tiếp phần mềm.
-	Tính lương cho Nhân viên.
## 5.2. Quá trình làm việc – Việc nhóm.
### 5.2.1. Phân công việc.
|Thông tin thành viên     |Nội dung công việc thực hiện                      |Hoàn thành|Tham gia |
|:-----------------------:|:------------------------------------------------:|:--------:|:-------:|
|Phan Anh Thăng 2011069025	|Hoàn thiện Usecase Diagram.Thiết kế giao diện form liên quan.Thiết kế Database.Lập trình – Code:Chuẩn bị solution theo mô hình 3 tier.frmMainusctrlThuNganusctrlNhanVienusctrlHeThong-frmTaiKhoanTham gia kiểm thử phần mềm.Hoàn thành file Document – Báo cáo.	|100%	|25%|
|Vũ Lê Anh Thi 2011061865	|Hoàn thiện Activity Diagram.Thiết kế giao diện form liên quan.Thiết kế Database.Lập trình - Code:UsctrlDoanhThu, UsctrlTongQuan. UsctrlSanPham.ReportPhieuNhap.Thống kê PhieuNhap.Thống kê NhapHang.Tham gia kiểm thử phần mềm.	|100%	|25%|
|Huỳnh Thị Trúc Ngân 2011064432	|Hoàn thiện Sequence Diagram.Thiết kế Database.Lập trình – Code:usctrlHoaDonustrlKhachHangustrlPhieuNhapTạo reportHoaDonTham gia kiểm thử phần mềm.Chuẩn bị .pptx thuyết trình.	|100%	|25%|
|Ngô Hoài Phát Tấn 2011110597	|Phác thảo giao diện phần mềm.Thiết kế Database.Lập trình – Code:usctrlNhaCungCapTham gia kiểm thử phần mềm.	|100%	|25%|
### 5.2.2. Khó khăn.
-	Thời gian meeting để phân chia công việc chưa được thống nhất: mất thời gian, vấn đề công việc không được truyền đạt.
-	Khả năng thành viên trong team có chênh lệch.
-	Giai đoạn chuyển giao file bị trục trặc do sử dụng cách phổ thông: gửi file nén.

