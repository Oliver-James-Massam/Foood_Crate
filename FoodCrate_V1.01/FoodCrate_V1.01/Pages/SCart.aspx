﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="SCart.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/LoginPage/font-awesome.min.css" rel="stylesheet" />
    <link href="../Styling/LoginPage/form-elements.css" rel="stylesheet" />
    <link href="../Styling/ShoppingCart/Improved%20Table.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wow">

    </div>
        <div class="Cart">
        <div class="container-fluid breadcrumbBox text-center">
		<ol class="breadcrumb">
			<li class="active"><a href="../Pages/SCart.aspx">Overview</a></li>
			<li ><a href="../Pages/SCartReview.aspx">Discounts and tax</a></li>
			<li  ><a href="../Pages/ScartCheckOut.aspx">Checkout!</a></li>
		</ol>
	</div>

        <asp:Table ID="table"  runat="server" >
            <asp:TableHeaderRow>
                
                <asp:TableHeaderCell> Name of item</asp:TableHeaderCell>
                <asp:TableHeaderCell id="headNo" Width="250"> Qty</asp:TableHeaderCell>
                <asp:TableHeaderCell>Price</asp:TableHeaderCell>
                <asp:TableHeaderCell>Remove</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <asp:Button ID="Accept" class="btnacc" runat="server" Text="Accept order and proceed to review" OnClick="Accept_Click" />
    </div>
</asp:Content>
