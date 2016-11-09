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
    <div class="col-centered">
        <div class='col-lg-9' style="padding-bottom:0px;min-height: 1px;box-sizing:padding-box">
            <div id="prodDetails" class='thumbnail' runat='server'>
            </div>
        </div>
    </div>
    <div class="col-centered">
        <div class='col-lg-9'>
            <div id="prodDetails2" class='thumbnail' runat='server'>
                <a class='btn btn-success' id ='Buy' runat='server' onserverclick='addToCart_Click'>Add to Cart</a>
            </div>
        </div>
    </div>
</asp:Content>
