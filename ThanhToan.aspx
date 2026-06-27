<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="BTL.ThanhToan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Thanhtoan</title>
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
            <h1>Thanh toán</h1>
            <div>
                <a href="TrangChu.aspx">
                    <img src="images/logo.png" alt="Logo website bán quạt" width="120" />
                </a>
                <ul>
                    <li><a href="DanhSachSanPham.aspx">Danh sách sản phẩm</a></li>
                    <li><a href="GioHang.aspx">Giỏ hàng</a></li>
                    <li><a href="ThanhVien.aspx">Trang thành viên</a></li>
                    <li><a href="BaoCaoThongKe.aspx">Báo cáo thống kê</a></li>
                    <li><a href="QuanLySanPham.aspx">Quản lý danh sách sản phẩm</a></li>
                </ul>
            </div>
            <hr />
            <h2>Thông tin nhận hàng</h2>
                <div>
                    <label>Họ tên:</label><br />
                    <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <label>Số điện thoại:</label><br />
                    <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <label>Địa chỉ:</label><br />
                    <asp:TextBox ID="txtDiaChi" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <br />
                <asp:Button ID="btnDatHang" runat="server" Text="Đặt hàng" OnClick="btnDatHang_Click" />
            <br /><br />
            <label id="lblThongBao" runat="server" style="color:red;"></label>
    </form>
</body>
</html>
