<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="SCart.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/LoginPage/font-awesome.min.css" rel="stylesheet" />
    <link href="../Styling/LoginPage/form-elements.css" rel="stylesheet" />
        <link href="../Styling/ShoppingCart/custom.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container-fluid breadcrumbBox text-center">
		<ol class="breadcrumb">
			<li class="active"><a href="../Pages/SCart.aspx">Overview</a></li>
			<li ><a href="../Pages/SCartReview.aspx">Discounts and tax</a></li>
			<li  ><a href="../Pages/ScartCheckOut.aspx">Checkout!</a></li>
		</ol>
	</div>
    <div id="Cart">
        <asp:Table ID="CartTable" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell> Quantity</asp:TableHeaderCell>
                <asp:TableHeaderCell> Name of item</asp:TableHeaderCell>
                <asp:TableCell>Price</asp:TableCell>
                <asp:TableCell>Remove</asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>
                    <input id="Quantity" type="number" name="NoItems" class="form-control"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label runat="server"> This is the name boys</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                         <asp:Label runat="server"> 1 000 000</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableFooterRow>
                <asp:TableHeaderCell>Total:</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell>Add addition of all products</asp:TableHeaderCell>
            </asp:TableFooterRow>

        </asp:Table>
        
    </div>
</asp:Content>
