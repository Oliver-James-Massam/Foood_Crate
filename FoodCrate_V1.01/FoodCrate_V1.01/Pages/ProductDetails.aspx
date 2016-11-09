<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="FoodCrate_V1._01.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/Catalog/shop-item.css" rel="stylesheet" />
    <style>
        @font-face {
            font-family: inlineHeading;
            src: url('../Fonts/FoobarProRegular.otf');
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="prodDetails" class="col-centered" runat="server">
        
    </div>
</asp:Content>
