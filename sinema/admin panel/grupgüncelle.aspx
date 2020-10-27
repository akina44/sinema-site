<%@ Page Title="" Language="C#" MasterPageFile="~/admin panel/admin.master" AutoEventWireup="true" CodeFile="grupgüncelle.aspx.cs" Inherits="admin_panel_grupgüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" style="width: 300px">
    <tr>
        <td style="width: 72px">Grup Adı</td>
        <td>
            <asp:TextBox ID="txtgrup" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 72px">&nbsp;</td>
        <td>
            <asp:Button ID="btndznle" runat="server" OnClick="btndznle_Click" Text="Güncelle" />
        </td>
    </tr>
</table>
</asp:Content>

