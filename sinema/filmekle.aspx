<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="filmekle.aspx.cs" Inherits="filmekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="satir-1">Film Türü</div>
<div class="satir-2">
    <asp:DropDownList ID="ddfilmtür" runat="server" Height="18px" Width="123px" AutoPostBack="True"></asp:DropDownList>
</div>
<div class="satir-3"></div>

<div class="satir-1">Yapım Yeri</div>
<div class="satir-2">
    <asp:DropDownList ID="ddyyeri" runat="server" Height="18px" Width="123px"></asp:DropDownList>
</div> 
    <div class="satir-3"></div>
    <div class="satir-1">Yapım Yılı</div>

<div class="satir-2"><asp:DropDownList ID="ddyyılı" runat="server" Height="16px" Width="122px"></asp:DropDownList></div>
   
    

    <div class="satir-3"></div>
    <div class="satir-1">Film Adı</div>

<div class="satir-2">
    <asp:TextBox ID="txtfilmadi" runat="server" Width="276px"></asp:TextBox>
    </div>
   
    

    <div class="satir-3"></div>
    <div class="satir-1">Senaryo</div>

<div class="satir-2">
    <asp:TextBox ID="txtsnry" runat="server" Width="277px"></asp:TextBox>
    </div>
   
    

    <div class="satir-3"></div>
     <div class="satir-1">Oyuncular</div>

<div class="satir-2">
    <asp:TextBox ID="txtync" runat="server" Width="277px"></asp:TextBox>
    </div>
   
    

    <div class="satir-3"></div>
     <div class="satir-1">Yapımcı</div>

<div class="satir-2">
    <asp:TextBox ID="txtyapimci" runat="server" Width="273px"></asp:TextBox>
    </div>
   
    

    <div class="satir-3"></div>
         <div class="satir-1">Yönetmen</div>

<div class="satir-2">
    <asp:TextBox ID="txtyntmn" runat="server" Width="275px"></asp:TextBox>
    </div>
   
    

    <div class="satir-3"></div>
      <div class="satir-1">Konu</div>

<div class="satir-5">
    <asp:TextBox ID="txtkonu" runat="server" Width="280px" TextMode="MultiLine" Height="141px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnkaydet" runat="server" Text="Fİlmi Kaydet" OnClick="btnkaydet_Click" />
    </div>
   
    

    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

