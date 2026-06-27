<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="BTL.DanhSachSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Danh sách sản phẩm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTimKiem" runat="server" placeholder="Nhập tên quạt..."></asp:TextBox>
            <asp:DropDownList ID="ddlLoai" runat="server">
                <asp:ListItem Text="Tất cả" Value="Tất cả"></asp:ListItem>
                <asp:ListItem Text="Quạt đứng" Value="Quạt đứng"></asp:ListItem>
                <asp:ListItem Text="Quạt hơi nước" Value="Quạt hơi nước"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" OnClick="btnTimKiem_Click" />
        </div>

        <asp:Repeater ID="rptSanPham" runat="server">
    <ItemTemplate>
        <a href='ChiTietSanPham.aspx?id=<%# Eval("MaSP") %>' style="text-decoration: none; color: black;">
            
            <div style="border:1px solid #ccc; margin:10px; padding:10px; border-radius: 8px; transition: 0.3s;">
                <img src='<%# Eval("HinhAnh") %>' width="100" />
                
                <h3><%# Eval("TenSP") %></h3>
                <p>Hãng: <%# Eval("Hang") %> - Loại: <%# Eval("Loai") %></p>
                <p>Giá: <%# String.Format("{0:N0}", Eval("Gia")) %> VNĐ</p>
            </div>

        </a>
    </ItemTemplate>
</asp:Repeater>
    </form>
</body>
</html>
