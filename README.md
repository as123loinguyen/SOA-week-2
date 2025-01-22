# Mô tả
Dự án này minh họa một API Todo đơn giản được xây dựng bằng ASP.NET Core. Nó bao gồm các chức năng để quản lý danh sách công việc (todo), cho phép bạn tạo, đọc, cập nhật và xóa các mục công việc.

## Tính năng

- **Tạo** một mục công việc mới.
- **Lấy** tất cả các mục công việc hoặc lọc dựa trên trạng thái hoàn thành.
- **Lấy** một mục công việc cụ thể theo ID.
- **Cập nhật** một mục công việc hiện có.
- **Xóa** một mục công việc theo ID.

## Yêu cầu

- .NET SDK (phiên bản 8.0 hoặc tương thích)
- Một trình soạn thảo mã như Visual Studio Code hoặc Visual Studio

## Cách chạy dự án

1. Clone kho lưu trữ:

   ```bash
   git clone <repository-url>
   cd TodoApi
   ```

2. Khôi phục các phụ thuộc:

   ```bash
   dotnet restore
   ```

3. Xây dựng dự án:

   ```bash
   dotnet build
   ```

4. Chạy dự án:

   ```bash
   dotnet run
   ```

   Ứng dụng sẽ khởi động và bạn sẽ thấy đầu ra tương tự như sau:

   ```
   Now listening on: https://localhost:7151
   ```

5. Kiểm tra các endpoint API bằng công cụ như [Postman](https://www.postman.com/) hoặc [cURL](https://curl.se/).

## Các endpoint API

### URL cơ bản

`https://localhost:7151`

### 1. Lấy tất cả các mục công việc

**GET** `/todoitems`

- **Mô tả**: Lấy tất cả các mục công việc.
![image](https://github.com/user-attachments/assets/b59ccef9-46e0-4ad8-85f8-8bebf609ef8c)


### 2. Lấy các mục công việc đã hoàn thành

**GET** `/todoitems/complete`

- **Mô tả**: Lấy tất cả các mục công việc được đánh dấu là đã hoàn thành.
![image](https://github.com/user-attachments/assets/cdb1b69f-8dde-4c81-bfca-2dfeac5990e3)


### 3. Lấy mục công việc theo ID

**GET** `/todoitems/{id}`

- **Mô tả**: Lấy một mục công việc cụ thể theo ID.
![image](https://github.com/user-attachments/assets/a4f46abd-4808-4b3c-977c-df26422ff2cd)


### 4. Tạo mục công việc mới

**POST** `/todoitems`

- **Mô tả**: Thêm một mục công việc mới.
![image](https://github.com/user-attachments/assets/65b8bb39-a480-47a0-aa94-6ac34697894c)


### 5. Cập nhật một mục công việc

**PUT** `/todoitems/{id}`

- **Mô tả**: Cập nhật một mục công việc cụ thể theo ID.
![image](https://github.com/user-attachments/assets/4db0e7df-6329-4ecb-b081-441980b65f1a)

### 6. Xóa một mục công việc

**DELETE** `/todoitems/{id}`

- **Mô tả**: Xóa một mục công việc theo ID.
![image](https://github.com/user-attachments/assets/2bcd84ad-9402-45b6-9418-a118a65e498b)



## Kết quả mong đợi

- API xử lý chính xác các yêu cầu và phản hồi cho các thao tác CRUD.
- Dữ liệu được lưu trữ trong bộ nhớ, sẽ bị đặt lại khi ứng dụng dừng.

## Lưu ý

- Dự án sử dụng cơ sở dữ liệu trong bộ nhớ, nghĩa là dữ liệu sẽ không được lưu trữ sau khi ứng dụng dừng.
- Để sử dụng trong môi trường sản xuất, hãy tích hợp với một cơ sở dữ liệu như SQL Server hoặc SQLite.


