<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="BTL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập - Cửa Hàng Quạt Điện</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh; /* Cao bằng 100% màn hình */
        }

        /* Biến form thành một hộp (card) nổi bật */
        #form1 {
            background: #ffffff;
            padding: 40px 30px;
            border-radius: 12px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 350px;
            box-sizing: border-box;
        }

        /* Tiêu đề */
        h1 {
            text-align: center;
            color: #333;
            margin-top: 0;
            font-size: 26px;
            margin-bottom: 25px;
        }

        /* Nhóm các ô nhập liệu */
        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: block;
            margin-bottom: 8px;
            color: #555;
            font-weight: 600;
            font-size: 14px;
        }

        /* Ô nhập text và password */
        .form-group input[type="text"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px 12px;
            border: 1px solid #ccc;
            border-radius: 6px;
            box-sizing: border-box; /* Chống tràn viền */
            font-size: 14px;
            transition: border-color 0.3s;
        }
        
        .form-group input[type="text"]:focus,
        .form-group input[type="password"]:focus {
            border-color: #007bff; /* Đổi màu viền khi bấm vào */
            outline: none;
        }

        /* Khu vực nút bấm nằm ngang */
        .action-buttons {
            display: flex;
            gap: 15px;
            margin-top: 25px;
        }

        /* Định dạng chung cho nút */
        .action-buttons input[type="submit"],
        .action-buttons input[type="button"] {
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-weight: bold;
            font-size: 15px;
            transition: background-color 0.2s;
        }

        /* Thẻ a bọc nút đăng ký */
        .action-buttons a {
            flex: 1;
            text-decoration: none;
        }

        /* Nút Đăng nhập */
        .btn-login {
            background-color: #0d6efd;
            color: white;
            flex: 1;
        }

        .btn-login:hover {
            background-color: #0b5ed7;
        }

        /* Nút Đăng ký */
        .btn-register {
            background-color: #e9ecef;
            color: #333;
        }

        .btn-register:hover {
            background-color: #dde0e3;
        }

        /* Thông báo lỗi */
        .error-message {
            display: block;
            text-align: center;
            margin-top: 15px;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post" action="Dangnhap.aspx">
        <h1>Đăng nhập</h1>
        
        <div class="form-group">
            <label>Tên đăng nhập:</label>
            <input id="txtTenDangNhap" name="tenDangNhap" type="text" placeholder="Nhập tài khoản..." />
        </div>
        
        <div class="form-group">
            <label>Mật khẩu:</label>
            <input id="txtMatKhau" name="matKhau" type="password" placeholder="Nhập mật khẩu..." />
        </div>
        
        <div class="action-buttons">
            <input type="submit" value="Đăng nhập" class="btn-login" />
            <a href="dangki.aspx">
                <input type="button" value="Đăng ký" class="btn-register" />
            </a>
        </div>
        
        <asp:Label ID="lblThongBao" runat="server" ForeColor="Red" CssClass="error-message"></asp:Label>
    </form>
</body>
</html>