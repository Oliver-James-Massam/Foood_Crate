<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="FoodCrate_V1._01.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/Catalog/shop-item.css" rel="stylesheet" />
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-centered">
        <div class="col-lg-9">
            <div class="thumbnail">
                    <img class="img-responsive" src="http://placehold.it/800x300" alt=""/>
                    <div class="caption-full">
                        <h4 class="pull-right" id="Price">R322.42</h4>
                        <h4>Product Name</h4>
                        <p>This is a short reivew</p>
                        <p>Long reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong reviewLong review</p>
                    </div>
                <br />
            <a class="btn btn-success" id ="Buy">Buy</a>
                </div>
            </div>
        </div>
</asp:Content>
