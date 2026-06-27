<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaoCaoThongKe.aspx.cs" Inherits="BTL.BaoCaoThongKe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Baó cáo thống kê</title>
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
        <h2>Báo Cáo Thống Kê</h2>
        <div style="font-size: 18px; line-height: 2;">
            <ul>
                <li><a href="Trangchu.aspx">Trang chủ</a></li>
                <li><a href="DanhSachSanPham.aspx">Danh sách sản phẩm</a></li>
                <li><a href="GioHang.aspx">Giỏ hàng</a></li>
                <li><a href="ThanhVien.aspx">Trang thành viên</a></li>
                <li><a href="BaoCaoThongKe.aspx">Báo cáo thống kê</a></li>
                <li><a href="QuanLySanPham.aspx">Quản lý danh sách sản phẩm</a></li>
            </ul>
            <p>Tổng số đơn hàng: <asp:Label ID="lblTongDon" runat="server" Font-Bold="true"></asp:Label></p>
            <p>Sản phẩm bán chạy nhất: <asp:Label ID="lblBanChayNhat" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label></p>
            
        </div>
    </form>
</body>
</html>
