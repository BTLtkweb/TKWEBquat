<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangki.aspx.cs" Inherits="BTL.dangki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="dangki.aspx">
    <h1>Đăng ký thành viên</h1>

    <div>
        <label>Tên đăng nhập:</label><br />
        <input type="text" name="tenDangNhap" />
    </div>

    <br />

    <div>
        <label>Mật khẩu:</label><br />
        <input type="password" name="matKhau" />
    </div>

    <br />

    <div>
        <label>Nhập lại mật khẩu:</label><br />
        <input type="password" name="nhapLaiMatKhau" />
    </div>

    <br />

    <div>
        <label>Họ tên:</label><br />
        <input type="text" name="ten" />
    </div>

    <br />

    <div>
        <label>Số điện thoại:</label><br />
        <input type="text" name="soDienThoai" />
    </div>

    <br />

    <div>
        <label>Ngày sinh:</label><br />
        <input type="date" name="ngaySinh" />
    </div>

    <br />

    <div>
        <label>Giới tính:</label><br />
        <input type="radio" name="gioiTinh" value="Nam" checked /> Nam
        <input type="radio" name="gioiTinh" value="Nữ" /> Nữ
    </div>

    <br />

    <div>
        <label>Email:</label><br />
        <input type="email" name="email" />
    </div>

    <br />

    <input type="submit" value="Đăng ký" />

    <input type="button" value="Quay lại đăng nhập" onclick="location.href='DangNhap.aspx'" />

    <br /><br />

    <label id="lblThongBao" runat="server" style="color:red;"></label>

</form>
</body>
</html>
