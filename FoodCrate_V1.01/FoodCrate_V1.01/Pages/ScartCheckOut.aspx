<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="ScartCheckOut.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/ShoppingCart/ThankYou.css" rel="stylesheet" />
        <script src="../scripts/CommonScrips/jquery-1.11.1.min.js"></script>
        <script src="../scripts/CommonScrips/jquery.backstretch.min.js"></script>
    <script src="../scripts/CommonScrips/ThankYouImage.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wow">
        </div>
    <div class="Trans">
    <div class="container-fluid breadcrumbBox text-center">
		<ol class="breadcrumb">
            <li ><a href="../Pages/Home.aspx">Go back home</a></li>
			<li><a href="../Pages/Catalog.aspx">Get back shopping</a></li>
		</ol>
	</div>
    <br />
    <!-- thank you message and end transaction -->
        <div class="jumbotron">
            <h1>Thank your for your support</h1>
              </div>
        </div>

</asp:Content>
