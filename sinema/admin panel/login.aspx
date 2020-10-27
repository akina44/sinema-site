<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_panel_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: center">sinema.com Yönetim Paneli</td>
    </tr>
    <tr>
        <td>         <table align="center" style="width: 306px" >
              <tr>
                    <td style="text-align: center;" colspan="2">
                        <asp:Label ID="lblbilgi" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 106px">Kullanıcı Adı:</td>
                    <td>
                        <asp:TextBox ID="txtkullaniciadi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 106px">Şifre:</td>
                    <td>
                        <asp:TextBox ID="txtsifre" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 106px">&nbsp;</td>
                    <td>
                        <asp:Button ID="btngiris" runat="server" OnClick="btngiris_Click" Text="Giriş" />
                    </td>
                </tr>
            </table></td>
    </tr>
    <tr>
        <td>
   
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

