# Thành viên
<h4>Tên nhóm: FASHION  </h4>

  
| STT | Họ tên | Chức vụ  |
|----------------|--------------------|--------------------|
|  1  |  Ngyễn Văn Vương   |   Nhóm trưởng  |
|  2  |  Đặng Hữu Phúc  |   Thành viên  |
|  3  |  Võ Minh Tính  |   Thành viên  |
-----------------------------------------------
### Sử dụng 
```yaml
Sử dụng:
- .Net Framework version 4.8
- Composer version 2.7.6
- PHP 8.2.12
- Laravel Framework 11.10.0
- xampp - V3.3.0
- cloudinary
- Visual studio 2022
- Visual code
```

-----------------------------------------------

### Chi tiết
![Chi tiết dự án](https://asset.cloudinary.com/dkcizqsb3/dfc4edbaba7453d63cc24ad1c1ccbbbd)

-----------------------------------------------
# Dự án

Hệ thống quản lý bán hàng shop thời trang

Mô tả dự án:

Hệ thống quản lý bán hàng shop thời trang là một nền tảng đa chức năng được phát triển để phục vụ cho việc kinh doanh và quản lý các sản phẩm thời trang trực tuyến và tại cửa hàng. Hệ thống này bao gồm hai giao diện chính: một giao diện web dành cho khách hàng (user) và một giao diện quản trị (admin) để quản lý các sản phẩm, đơn hàng, khách hàng và các khía cạnh khác của cửa hàng.

Với giao diện web dành cho khách hàng, người dùng có thể dễ dàng truy cập vào các sản phẩm thời trang như quần áo, giày dép, phụ kiện. Trang chủ sẽ hiển thị các sản phẩm nổi bật như top sản phẩm bán chạy và top sản phẩm đang giảm giá. Người dùng có thể tìm kiếm, xem chi tiết sản phẩm, đánh giá, chọn kích thước và màu sắc phù hợp. Hệ thống giỏ hàng được tối ưu hóa, cho phép khách hàng thêm sản phẩm, áp dụng voucher, và chọn phương thức thanh toán linh hoạt như thanh toán khi nhận hàng hoặc qua Momo. Ngoài ra, khách hàng có thể kiểm tra đơn hàng bằng số điện thoại mà không cần đăng nhập, hoặc quản lý đơn hàng đã đặt, đang giao, hay đơn hàng đã hủy thông qua tài khoản cá nhân.

Giao diện quản trị cung cấp các chức năng mạnh mẽ để hỗ trợ quản lý toàn diện. Quản trị viên có thể thêm, sửa, xóa các thông tin về sản phẩm, kích thước, màu sắc, danh mục. Ngoài ra, hệ thống cho phép quản lý đơn hàng từ việc xem chi tiết, cập nhật trạng thái, sắp xếp và lọc đơn hàng theo nhiều tiêu chí khác nhau. Hệ thống quản lý khách hàng giúp quản lý thông tin, giỏ hàng và trạng thái tài khoản của khách hàng. Ngoài ra, các chức năng quản lý voucher, báo cáo thống kê về đơn hàng và doanh thu cũng được tích hợp, cung cấp cho admin những dữ liệu cần thiết để đánh giá tình hình kinh doanh và đưa ra quyết định kịp thời.

Với giao diện WinForms dành cho quản trị viên và nhân viên tại cửa hàng, hệ thống còn hỗ trợ bán hàng trực tiếp thông qua POS. Nhân viên có thể dễ dàng tìm kiếm sản phẩm trong kho, thanh toán cho khách hàng bằng tiền mặt hoặc chuyển khoản. Cùng với đó, các báo cáo thống kê và quản lý đơn hàng, khách hàng đều được tự động hóa, mang lại sự tiện lợi và chính xác trong quá trình vận hành.

Hệ thống không chỉ giúp tối ưu hóa quá trình kinh doanh thời trang mà còn nâng cao trải nghiệm mua sắm của khách hàng, từ đó thúc đẩy hiệu quả kinh doanh cho cửa hàng.

### Yêu cầu 

<h3>Web: Laravel</h3>
<p>AI: gợi ý sản phẩm phân cụm người dung </p>
<p>Ngôn ngữ: Javascript, php ,sass, html/css </p>
<p>Framework: Bootstrap</p>

<p>Nghiệp vụ</p>

# Bảng Phân Công Công Việc

## 1. Admin Panel

| UC  | Tính năng                                                                 | Người phụ trách | Ghi chú                                           | Đã hoàn thành |
|-----|---------------------------------------------------------------------------|------------------|--------------------------------------------------|---------------|
| UC1 | COLOR - Thêm, xóa, sửa                                                     | Tính     | Quản lý màu sắc cho sản phẩm                     | Chưa          |
| UC2 | SIZE - Thêm, xóa, sửa                                                      | Tính    | Quản lý kích thước sản phẩm                      | Chưa          |
| UC3 | CATEGORY - Thêm, xóa, sửa                                                   | Tính    | Quản lý danh mục sản phẩm                        | Chưa          |
| UC4 | PRODUCT - Thêm, xóa, sửa                                                    | Tính     | Quản lý sản phẩm, chi tiết sản phẩm              | Chưa          |
| UC5 | PRODUCT - Thêm bằng file excel                                               | Tính    | Nhập sản phẩm từ file Excel                      | Chưa          |
| UC6 | PRODUCT - Phân trang theo row, search                                        | Tính    | Tìm kiếm, phân trang sản phẩm                    | Chưa          |
| UC7 | Quản lý chi tiết sản phẩm - Thêm, xóa, sửa, cập nhật số lượng tồn          | Tính    | Cập nhật chi tiết sản phẩm và số lượng tồn       | Chưa          |
| UC8 | CUSTOMER - Thêm, xóa, sửa                                                    | Tính    | Quản lý thông tin khách hàng                     | Chưa          |
| UC9 | CUSTOMER - Xem chi tiết giỏ hàng khách hàng                                 | Tính    | Xem giỏ hàng khách hàng                          | Chưa          |
| UC10| CUSTOMER - Cập nhật trạng thái tài khoản bị khóa                           | Tính    | Khóa/mở khóa tài khoản khách hàng                | Chưa          |
| UC11| ORDER - Xem chi tiết đơn hàng                                               | Phúc     | Quản lý thông tin chi tiết đơn hàng              | Chưa          |
| UC12| ORDER - Cập nhật trạng thái đơn hàng                                        | Phúc      | Cập nhật trạng thái giao hàng                    | Chưa          |
| UC13| ORDER - Sắp xếp theo thời gian đặt                                          | Phúc      | Sắp xếp đơn hàng theo thời gian                  | Chưa          |
| UC14| ORDER - Lọc theo trạng thái, hình thức thanh toán                          | Phúc     | Lọc đơn hàng theo trạng thái                    | Chưa          |
| UC15| ORDER - Tìm kiếm theo số điện thoại và địa chỉ                             | Phúc     | Tìm kiếm đơn hàng                                | Chưa          |
| UC16| VOUCHER - Thêm, xóa, sửa                                                     | Phúc      | Quản lý voucher                                  | Chưa          |
| UC17| BÁO CÁO THỐNG KÊ - Tổng số đơn hàng                                         | Phúc      | Thống kê tổng số đơn hàng                        | Chưa          |
| UC18| BÁO CÁO THỐNG KÊ - Tổng số lượng sản phẩm đã mua                            | Phúc     | Thống kê tổng số sản phẩm đã mua                 | Chưa          |
| UC19| BÁO CÁO THỐNG KÊ - Tổng doanh thu                                           | Phúc      | Thống kê tổng doanh thu                          | Chưa          |
| UC20| BÁO CÁO THỐNG KÊ - Theo thời gian                                           | Phúc     | Thống kê theo thời gian                          | Chưa          |
| UC20| Phân Quyền Nhân Viên                                          | Phúc     | Phân Quyền hệ thống                          | Chưa          |
---

## 2. User Panel

| UC  | Tính năng                                                                 | Người phụ trách | Ghi chú                                           | Đã hoàn thành |
|-----|---------------------------------------------------------------------------|------------------|--------------------------------------------------|---------------|
| UC21| TRANG HOME - Xem top 8 sản phẩm bán chạy                                    | Vương     | Hiển thị sản phẩm bán chạy                       | Chưa          |
| UC22| TRANG HOME - Xem top 8 sản phẩm sale                                        | Vương      | Hiển thị sản phẩm giảm giá                       | Chưa          |
| UC23| TRANG PRODUCT - Xem tất cả sản phẩm                                         | Vương     | Hiển thị danh sách sản phẩm                      | Chưa          |
| UC24| TRANG PRODUCT - Tìm kiếm sản phẩm theo tên                                 | Vương     | Tìm kiếm sản phẩm theo tên                       | Chưa          |
| UC25| TRANG PRODUCT - Xem sản phẩm theo danh mục                                 | Vương      | Hiển thị sản phẩm theo danh mục                  | Chưa          |
| UC26| TRANG PRODUCT DETAIL - Xem chi tiết sản phẩm                               | Vương     | Hiển thị thông tin chi tiết sản phẩm             | Chưa          |
| UC27| TRANG PRODUCT DETAIL - Xem số lượng sản phẩm đã bán                        | Vương      | Thống kê số lượng sản phẩm đã bán                | Chưa          |
| UC28| TRANG PRODUCT DETAIL - Xem số lượt đánh giá sản phẩm                       | Vương      | Thống kê lượt đánh giá                           | Chưa          |
| UC29| TRANG PRODUCT DETAIL - Xem đánh giá sản phẩm                               | Vương      | Hiển thị đánh giá sản phẩm                       | Chưa          |
| UC30| TRANG PRODUCT DETAIL - Chọn màu sản phẩm theo kích thước                   | Vương     | Lựa chọn màu và kích thước sản phẩm              | Chưa          |
| UC31| TRANG CART - Tự động cập nhật tiền khi thêm sản phẩm                       | Vương      | Tự động tính toán lại tổng tiền                 | Chưa          |
| UC32| TRANG CART - Cập nhật thông tin nhận hàng                                  | Vương      | Cập nhật thông tin nhận hàng                     | Chưa          |
| UC33| TRANG CART - Nhập mã voucher, tự cập nhật số tiền                         | Vương     | Áp dụng mã giảm giá                              | Chưa          |
| UC34| TRANG CART - Thanh toán sau khi nhận hàng hoặc bằng Momo                    | Vương      | Tích hợp thanh toán Momo và kiểm tra đơn hàng    | Chưa          |
| UC35| TRANG KIỂM TRA ĐƠN HÀNG - Xem đơn hàng theo số điện thoại                   | Vương      | Kiểm tra đơn hàng cho khách hàng chưa đăng nhập | Chưa          |
| UC36| TRANG VOUCHER - Lưu voucher về                                              | Vương      | Lưu thông tin mã giảm giá của người dùng        | Chưa          |
| UC37| TRANG MY PROFILE - Xem, cập nhật thông tin và đổi mật khẩu                | Vương     | Quản lý thông tin cá nhân người dùng            | Chưa          |
| UC38| TRANG MY ORDER - Xem đơn đã đặt, đơn đang giao, đơn đã nhận, đơn hủy      | Vương      | Hiển thị trạng thái đơn hàng của người dùng     | Chưa          |
| UC39| TRANG MY VOUCHER - Xem voucher đã lưu                                       | Vương      | Hiển thị các voucher đã lưu của người dùng      | Chưa          |
| UC40| TRANG LOGIN - Đăng nhập, đăng ký, quên mật khẩu                           | Vương      | Quản lý xác thực người dùng                     | Chưa          |

---

## 3. Backend & Database

| Công việc                    | Người phụ trách | Ghi chú                                        | Đã hoàn thành |
|------------------------------|------------------|------------------------------------------------|---------------|
| Thiết kế Database            | Tính , Phúc | Thiết kế cấu trúc cơ sở dữ liệu                 | Done         |
| Tích hợp thanh toán Momo      | Vương | Cấu hình thanh toán Momo                       | Done          |
| Chat box  AI   | Nhóm | tư vấn tự động cho khách hàng                     | Chưa          |

<h3>App: Winform </h3>
<p>Ngôn ngữ: C# </p>

# Bản Phân Công Công Việc

## ADMIN

| Tính năng                          | Người phụ trách | Ghi chú                                 | Đã hoàn thành |
|------------------------------------|------------------|----------------------------------------|---------------|
| **COLOR** - Thêm, xóa, sửa , tìm kiếm        | Vương     | Quản lý màu sắc sản phẩm                | Chưa          |
| **SIZE** - Thêm, xóa, sửa , tìm kiếm          | Vương      | Quản lý kích thước sản phẩm             | Chưa          |
| **CATEGORY** - Thêm, xóa, sửa , tìm kiếm      | Vương      | Quản lý danh mục sản phẩm               | Chưa          |
| **EMPLOYEES**                       |                  |                                        |               |
| - Thêm, xóa, sửa nhân viên , tìm kiếm         | Tính      | Quản lý thông tin nhân viên             | Chưa          |
| - Phân quyền                        | Phúc      | Quản lý phân quyền nhân viên            | Chưa          |
| **PRODUCT**                        |                  |                                        |               |
| - Thêm, xóa, sửa , tìm kiếm                   | Vương      | Quản lý thông tin sản phẩm              | Chưa          |
| - Quản lý chi tiết sản phẩm         | Vương     | Cập nhật chi tiết và số lượng tồn       | Chưa          |
| - Xem số lượng sản phẩm còn lại trong kho | Vương      | Kiểm tra số lượng sản phẩm trong kho   | Chưa          |
| **CUSTOMER**                       |                  |                                        |               |
| - Thêm, xóa, sửa , tìm kiếm                   | Tính       | Quản lý thông tin khách hàng            | Chưa          |
| - Cập nhật trạng thái tài khoản bị khóa | Phúc  | Khóa/mở khóa tài khoản khách hàng       | Chưa          |
| **ORDER**                          |                  |                                        |               |
| - Xem chi tiết đơn hàng             | Tính      | Quản lý thông tin chi tiết đơn hàng     | Chưa          |
| - Cập nhật trạng thái đơn hàng      | Tính      | Cập nhật trạng thái đơn hàng            | Chưa          |
| - Sắp xếp theo thời gian đặt        | Tính      | Sắp xếp đơn hàng theo thời gian         | Chưa          |
| - Lọc theo trạng thái và hình thức thanh toán | Tính | Lọc đơn hàng theo trạng thái và thanh toán | Chưa          |
| - Tìm kiếm theo số điện thoại và địa chỉ | Tính | Tìm kiếm đơn hàng theo số điện thoại và địa chỉ | Chưa          |
| **VOUCHER** - Thêm , xóa , sửa , tìm kiếm  | Phúc     | Quản lý voucher                         | Chưa          |
| **BÁO CÁO THỐNG KÊ**               |                  |                                        |               |
| - Tổng số đơn hàng                  | Phúc      | Thống kê tổng số đơn hàng               | Chưa          |
| - Tổng số lượng sản phẩm đã mua     | Phúc     | Thống kê tổng số sản phẩm đã mua        | Chưa          |
| - Tổng doanh thu                    | Phúc      | Thống kê tổng doanh thu                 | Chưa          |
| - Thống kê theo thời gian           | Phúc      | Thống kê theo thời gian                 | Chưa          |
| **POS**                            |                  |                                        |               |
| - Bán sản phẩm cho khách hàng       | Vương     | Xử lý bán hàng tại cửa hàng             | Chưa          |
| - Thanh toán bằng tiền mặt hoặc qua ngân hàng | Vương | Xử lý thanh toán tiền mặt hoặc ngân hàng | Chưa          |




###### Chức năng hệ thống
##### CHỨC NĂNG HỆ THỐNG WEB
#### ADMIN:
- **COLOR**
  - Thêm, xóa, sửa
- **SIZE**
  - Thêm, xóa, sửa
- **CATEGORY**
  - Thêm, xóa, sửa
- **PRODUCT**
  - Thêm, xóa, sửa
  - Thêm bằng file Excel
  - Phân trang theo hàng - tìm kiếm
  - Quản lý chi tiết sản phẩm
    - Thêm, xóa, sửa chi tiết sản phẩm
    - Cập nhật số lượng tồn
- **CUSTOMER**
  - Thêm, xóa, sửa
  - Xem chi tiết giỏ hàng khách hàng
  - Cập nhật trạng thái tài khoản bị khóa
- **ORDER**
  - Xem chi tiết đơn hàng
  - Cập nhật trạng thái đơn hàng
  - Sắp xếp theo thời gian đặt (tăng dần và giảm dần)
  - Lọc theo trạng thái đơn hàng và hình thức thanh toán
  - Tìm kiếm theo số điện thoại và địa chỉ
- **VOUCHER**
  - Thêm, xóa, sửa
- **BÁO CÁO THỐNG KÊ**
  - Tổng số đơn hàng
  - Tổng số lượng sản phẩm đã mua
  - Tổng doanh thu
  - Thống kê theo thời gian

#### USER:
- **TRANG HOME**
  - Xem top 8 sản phẩm bán chạy nhất
  - Xem top 8 sản phẩm sale nhiều nhất
- **TRANG PRODUCT**
  - Xem tất cả sản phẩm
  - Tìm kiếm sản phẩm theo tên
  - Xem sản phẩm theo danh mục
- **TRANG PRODUCT DETAIL**
  - Xem chi tiết sản phẩm
  - Xem số lượng sản phẩm đã bán
  - Xem số lượt đánh giá sản phẩm
  - Xem đánh giá sản phẩm
  - Chọn màu sản phẩm theo kích thước
  - Thêm vào giỏ hàng (lưu vào database nếu đăng nhập, lưu ở session nếu không đăng nhập)
- **TRANG CART**
  - Tự động cập nhật tiền khi tăng số lượng hoặc thêm sản phẩm
  - Cập nhật thông tin nhận hàng
  - Nhập mã voucher để tự cập nhật lại số tiền (yêu cầu đăng nhập và lưu voucher)
  - Áp dụng voucher giảm số lượng voucher
  - Mỗi voucher chỉ sử dụng 1 lần
  - Thanh toán sau khi nhận hàng và thanh toán bằng Momo (thông tin đơn hàng gửi về email)
  - Cập nhật số lượng tồn của chi tiết sản phẩm
- **TRANG KIỂM TRA ĐƠN HÀNG**
  - Xem đơn hàng theo số điện thoại (dành cho khách hàng vãng lai nếu chưa đăng nhập)
- **TRANG VOUCHER**
  - Lưu voucher về
- **TRANG MY PROFILE**
  - Xem thông tin profile, cập nhật thông tin và đổi mật khẩu
- **TRANG MY ORDER**
  - Xem đơn đã đặt (cập nhật thông tin địa chỉ, hủy đơn hàng, xem chi tiết đơn hàng)
  - Xem đơn đang giao (xem chi tiết đơn hàng)
  - Xem đơn đã nhận (xem chi tiết đơn hàng, feedback và đánh giá sản phẩm)
  - Xem đơn hủy (xem chi tiết đơn hàng)
- **TRANG MY VOUCHER**
  - Xem voucher đã lưu
- **TRANG LOGIN**
  - Đăng nhập
  - Đăng ký
  - Quên mật khẩu (mật khẩu mới gửi về email)

##### CHỨC NĂNG HỆ THỐNG WINFORMS

#### ADMIN:
- **COLOR**
  - Thêm, xóa, sửa
- **SIZE**
  - Thêm, xóa, sửa
- **CATEGORY**
  - Thêm, xóa, sửa
- **EMPLOYEES**
  - Thêm, xóa, sửa nhân viên
  - Phân quyền
- **PRODUCT**
  - Thêm, xóa, sửa
  - Phân trang theo hàng - tìm kiếm
  - Quản lý chi tiết sản phẩm
    - Thêm, xóa, sửa chi tiết sản phẩm
    - Cập nhật số lượng tồn
- **CUSTOMER**
  - Thêm, xóa, sửa
  - Cập nhật trạng thái tài khoản bị khóa
- **ORDER**
  - Xem chi tiết đơn hàng
  - Cập nhật trạng thái đơn hàng
  - Sắp xếp theo thời gian đặt (tăng dần và giảm dần)
  - Lọc theo trạng thái đơn hàng và hình thức thanh toán
  - Tìm kiếm theo số điện thoại và địa chỉ
- **VOUCHER**
  - Thêm, xóa, sửa
- **BÁO CÁO THỐNG KÊ**
  - Tổng số đơn hàng
  - Tổng số lượng sản phẩm đã mua
  - Tổng doanh thu
  - Thống kê theo thời gian
- **POS**
  - Bán sản phẩm cho khách hàng khi mua tại cửa hàng
  - Thanh toán bằng tiền mặt hoặc qua ngân hàng

#### EMPLOYEES:
- **PRODUCT**
  - Xem số lượng sản phẩm còn lại trong kho
- **ORDER**
  - Xem chi tiết đơn hàng
  - Cập nhật trạng thái đơn hàng
  - Sắp xếp theo thời gian đặt (tăng dần và giảm dần)
  - Lọc theo trạng thái đơn hàng và hình thức thanh toán
  - Tìm kiếm theo số điện thoại và địa chỉ
- **POS**
  - Bán sản phẩm cho khách hàng khi mua tại cửa hàng
  - Thanh toán bằng tiền mặt hoặc qua ngân hàng
- **BÁO CÁO THỐNG KÊ**
  - Tổng số đơn hàng
  - Tổng số lượng sản phẩm đã mua
  - Tổng doanh thu
  - Thống kê theo thời gian


