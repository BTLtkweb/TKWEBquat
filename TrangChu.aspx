<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="BTL.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang chủ</title>
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
    <form id="tc" runat="server">
        <div id="lblXinChao" runat="server"></div>
        <div>
            <h2>Thanh điều hướng</h2>
            <a href="TrangChu.aspx">
                <img src="./images/logo.jpg" alt="Logo website bán quạt" width="120" />
            </a>
            <ul>
                <li><a href="DanhSachSanPham.aspx">Danh sách sản phẩm</a></li>
                <li><a href="GioHang.aspx">Giỏ hàng</a></li>
                <li><a href="ThanhVien.aspx">Trang thành viên</a></li>
                <li><a href="BaoCaoThongKe.aspx">Báo cáo thống kê</a></li>
                <li><a href="QuanLySanPham.aspx">Quản lý danh sách sản phẩm</a></li>
            </ul>
        </div>
        <a href="ChiTietSanPham.aspx?id=1">
        <img src="images/quat1.png" alt="Chi tiết sản phẩm quạt" width="120" />
        </a>
    </form>
</body>
</html>
