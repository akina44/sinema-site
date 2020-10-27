<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="uyeol.aspx.cs" Inherits="uyeol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; color: #CC0000; text-align: center">
        <asp:Label ID="lblbilgi" runat="server" Text="Label"></asp:Label>

    </div>
    <div class="satir">
    <div class="uyeolsol">Email:</div>
    <div class="uyeolorta">
        <asp:TextBox ID="txtemail" runat="server" Width="212px"></asp:TextBox>
        </div>
    <div class="uyeolsag">
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtemail" CssClass="hatamesaj">Email adresiniz uygun değil.</asp:CompareValidator>
        </div>
</div><!--uyeol satır bitti-->
        <div class="satir">
    <div class="uyeolsol">Şifre:</div>
    <div class="uyeolorta">
        <asp:TextBox ID="txtsifre" runat="server" Width="212px" TextMode="Password"></asp:TextBox>
        </div>
    <div class="uyeolsag">
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtsifre" CssClass="hatamesaj">Lütfen doldurunuz.</asp:RequiredFieldValidator>
        
        </div>
</div><!--uyeol satır bitti-->
        <div class="satir">
    <div class="uyeolsol">Şifre(Tekrar):</div>
    <div class="uyeolorta">
        <asp:TextBox ID="txtsifre2" runat="server" Width="212px" TextMode="Password"></asp:TextBox>
        </div>
    <div class="uyeolsag">
        
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtsifre2" CssClass="hatamesaj" ControlToCompare="txtsifre">Şifreler uyuşmuyor.</asp:CompareValidator>
        
        </div>
</div><!--uyeol satır bitti-->
         <div class="satir">
    <div class="uyeolsol">Ad Soyad</div>
    <div class="uyeolorta">
        <asp:TextBox ID="txtadsoyad" runat="server" Width="212px"></asp:TextBox>
        </div>
    <div class="uyeolsag">
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtadsoyad" CssClass="hatamesaj">Lütfen doldurunuz.</asp:RequiredFieldValidator>
        
        </div>
</div><!--uyeol satır bitti-->
         <div class="satir">
    <div class="uyeolsol">Kullanıcı Adı</div>
    <div class="uyeolorta">
        <asp:TextBox ID="txtkullaniciadi" runat="server" Width="212px"></asp:TextBox>
        </div>
    <div class="uyeolsag">
        
        </div>
</div>
         <div class="satir">
    <div class="uyeolsol">Meslek</div>
    <div class="uyeolorta">
        <asp:DropDownList ID="drpmeslek" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpmeslek_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
    <div class="uyeolsag">
        
        </div>
</div><!--uyeol satır bitti-->
         <div class="satir">
    <div class="uyeolsol">Cinsiyet</div>
    <div class="uyeolorta">
        <asp:RadioButton ID="rdkız" runat="server" Text="Bayan" Checked="True" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rderkek" runat="server" Text="Erkek" />
        </div>
    <div class="uyeolsag">
        
        </div>
</div><!--uyeol satır bitti-->
         <div class="satir">
    <div class="uyeolsol">Doğum Tarihi</div>
    <div class="uyeolorta">
        <asp:TextBox ID="txtdogum" runat="server" Width="212px"></asp:TextBox>
        </div>
    <div class="uyeolsag">
        
        </div>
</div><!--uyeol satır bitti-->
         <div class="satir">
    <div class="uyeolsol">Resim</div>
    <div class="uyeolorta">
        <asp:FileUpload ID="flresim" runat="server" />
        </div>
    <div class="uyeolsag">
        
        </div>

</div><!--uyeol satır bitti-->
             <div class="satir">
    <div class="uyeolsol"></div>
    <div class="uyeolorta">
        
        </div>
    <div class="uyeolsag">
        
        <asp:Button ID="btnkaydet" runat="server" Text="Kaydet" OnClick="btnkaydet_Click" />
        
        </div>

</div><!--uyeol satır bitti-->
</asp:Content>

