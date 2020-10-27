<%@ Page Title="" Language="C#" MasterPageFile="~/admin panel/admin.master" AutoEventWireup="true" CodeFile="adminyönetimi.aspx.cs" Inherits="admin_panel_adminyönetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 700px">
        <tr>
            <td><table align="left" style="width: 255px" >
                    <tr>
                        <td >Kullanıcı Adı</td>
                        <td>
                            <asp:TextBox ID="txtara" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td >
                            <asp:Button ID="btnara" runat="server" EnableTheming="True" Text="Ara" OnClick="btnara_Click" />
                        </td>
                    </tr>
                </table></td>
        </tr>
        <tr>
            <td align="center" font-size="10">                
                <asp:Label ID="lblara" runat="server" align="center" ForeColor="Maroon"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlara" runat="server" Width="100%" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <HeaderTemplate>
                        <table style="width: 100%; font-size: 12px;">
                            <tr>
                                <td width="30%">Kullanıcı Adı</td>
                                <td width="30%">Ad soyad</td>
                                <td width="20%">Görevi</td>
                                <td width="10%">Düzenle</td>
                                <td width="10%">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="White" ForeColor="#330099" />
                    <ItemTemplate>
                        <table style="width: 100%; font-size: 12px;">
                            <tr>
                                <td width="30%"><%#Eval("kullaniciadi") %></td>
                                <td width="30%"><%#Eval("AdSoyad") %></td>
                                <td width="20%"><%#Eval("grupadi") %></td>
                                <td width="10%">
                                <a href="adminyönetimi.aspx?kullaniciid=<%#Eval("kullaniciid") %>&islem=sil">
                                    <img border="0" height="30"src="../Images/icon/kul-duzenle.png" /></a></td>
                                <td width="10%">
                                    <img border="0" height="30" src="../Images/icon/kul-sil.png" /></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                
                <table style="width: 100%">
                    <tr>
                        <td style="height: 30px; width: 150px">
                            <asp:Button ID="btnyönetici" runat="server" Text="Yöneticiler" Width="113px" OnClick="btnyönetici_Click" />
                        </td>
                        <td style="height: 30px; width: 150px">
                            <asp:Button ID="btnyardimci" runat="server" Text="Yardımcı Yönetici" Width="113px" OnClick="btnyardimci_Click" />
                        </td>
                        <td style="height: 30px; width: 150px">
                            <asp:Button ID="btnkullanici" runat="server" Text="Kullanıcılar" Width="113px" OnClick="btnkullanici_Click" />
                        </td>
                        <td style="height: 30px; width:150px;">
                            <asp:Button ID="btnson" runat="server" Text="Son 20 Üye" Width="113px" OnClick="btnson_Click" />
                        </td>
                    </tr>
                </table>
                
            </td>
        </tr>
        <tr>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlkullanici" runat="server" Width="100%" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <HeaderTemplate>
                        <table style="width: 100%; font-size: 12px;">
                            <tr>
                                <td width="30%">Kullanıcı Adı</td>
                                <td width="30%">Ad soyad</td>
                                <td width="20%">Görevi</td>
                                <td width="10%">Düzenle</td>
                                <td width="10%">Sil</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemStyle BackColor="White" ForeColor="#330099" />
                    <ItemTemplate>
                        <table style="width: 100%; font-size: 12px;">
                            <tr>
                                <td width="30%"><%#Eval("kullaniciadi") %></td>
                                <td width="30%"><%#Eval("AdSoyad") %></td>
                                <td width="20%"><%#Eval("grupadi") %></td>
                                <td width="10%">
                                    <img border="0" height="30"src="../Images/icon/kul-duzenle.png" /></td>
                                <td width="10%">
                                   <a href="adminyönetimi.aspx?kullaniciid=<%#Eval("kullaniciid") %>&islem=sil"><img border="0" height="30" src="../Images/icon/kul-sil.png" /></a></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

