<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="banquat.ChiTietSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChiTietSanPham</title>
    <style>
    ul {
        list-style: none;
    }

    li {
        display: inline;
        margin-right: 20px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Thanh điều hướng</h2>
            <a href="TrangChu.aspx">
                <img src="images/logo.png" alt="Logo website bán quạt" width="120" />
            </a>
            <ul>
                <li><a href="DanhSachSanPham.aspx">Danh sách sản phẩm</a></li>
                <li><a href="GioHang.aspx">Giỏ hàng</a></li>
                <li><a href="ThanhVien.aspx">Trang thành viên</a></li>
                <li><a href="TimKiem.aspx">Tìm kiếm và lọc sản phẩm</a></li>
                <li><a href="BaoCaoThongKe.aspx">Báo cáo thống kê</a></li>
                <li><a href="QuanLySanPham.aspx">Quản lý danh sách sản phẩm</a></li>
            </ul>
        </div>
        <hr />
        <div id="noiDungChiTiet" runat="server"></div>

    </form>
</body>
</html>
