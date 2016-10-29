<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="SCartReview.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />

    <link href="../Styling/ShoppingCart/custom.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid breadcrumbBox text-center">
		<ol class="breadcrumb">
			<li><a href="../Pages/SCart.aspx">OverView</a></li>
			<li  class="active"><a href="../Pages/SCartReview.aspx">Discounts and tax</a></li>
			<li><a href="../Pages/ScartCheckOut.aspx">Checkout!</a></li>
		</ol>
	</div>
</asp:Content>
