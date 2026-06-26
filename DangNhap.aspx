<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="banquat.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="DangNhap.aspx">
         <h1>Đăng nhập</h1>
        <div>
            <label>Tên đăng nhập:</label><br />
            <input id="txtTenDangNhap" name="tenDangNhap" type="text" />
        </div>
        <br />
        <div>
            <label>Mật khẩu:</label><br />
            <input id="txtMatKhau" name="matKhau" type="password" />
        </div>
        <div>
            <br />
            <input type="submit" value="Đăng nhập" />
            <br />
            <a href="DangKy.aspx">
            <input type="button" value="Đăng ký" />
            </a>
        </div>
        <label id="lblThongBao" runat="server" style="color:red;"></label>
    </form>
    
</body>
</html>
