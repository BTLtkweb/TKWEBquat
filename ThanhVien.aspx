<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThanhVien.aspx.cs" Inherits="BTL.ThanhVien1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Nâng cấp gói thành viên</h2>
        <asp:DropDownList ID="ddlGoi" runat="server">
            <asp:ListItem Value="Thường">Gói Thường</asp:ListItem>
            <asp:ListItem Value="Bạc">Gói Bạc</asp:ListItem>
            <asp:ListItem Value="Vàng">Gói Vàng</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" OnClick="btnDangKy_Click" />
        <br />
        <asp:Label ID="lblThongBao" runat="server" ForeColor="Green"></asp:Label>
    </form>
</body>
</html>
