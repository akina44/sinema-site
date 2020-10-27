<%@ Page Title="" Language="C#" MasterPageFile="~/admin panel/admin.master" AutoEventWireup="true" CodeFile="grupyönetimi.aspx.cs" Inherits="grupyönetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
         
        <tr>
            <td style="width: 97px">Grup Adı:</td>
            <td>
                <asp:TextBox ID="txtgrupadi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 97px">&nbsp;</td>
            <td>
                <asp:Button ID="btnekle" runat="server" OnClick="btnekle_Click" Text="Ekle" />
            </td>
        </tr>
        <tr>
            <td style="width: 97px">&nbsp;</td>
            <td>
                
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 97px">&nbsp;</td>
            <td>
                
                &nbsp;</td>
        </tr>
    </table>
    <table style="width: 794px">
        <asp:Repeater ID="rpgruplar" runat="server">
<ItemTemplate>
     <tr>
                        <td style="width: 527px; height: 44px">
                            <%#Eval("grupadi") %>
                        </td>
                        <td  style="width: 134px; height: 44px; ">
                            <a href="grupgüncelle.aspx?grupid=<%#Eval("grupid")%>"><img alt="" src="../Images/icon/kul-duzenle.png"border="0" width="50" height="50"   align="middle" /></a>

                        </td>
                        <td style="height: 44px;  ">
                            
                            <a href="grupyönetimi.aspx?grupid=<%#Eval("grupid")%>&islem=sil"><img alt="" src="../Images/icon/kul-sil.png" border="0"width="50" height="50" align="middle" /></a>

                        </td>
                    </tr>
</ItemTemplate>
        </asp:Repeater>
                   
                </table>

</asp:Content>

