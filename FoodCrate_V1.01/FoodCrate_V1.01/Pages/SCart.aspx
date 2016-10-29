<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="SCart.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/LoginPage/font-awesome.min.css" rel="stylesheet" />
    <link href="../Styling/LoginPage/form-elements.css" rel="stylesheet" />
    <link href="../Styling/ShoppingCart/custom.css" rel="stylesheet" />
    <link href="../Styling/ShoppingCart/Table.css" rel="stylesheet" />
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
        <asp:Table ID="table"  runat="server" CssClass="../Styling/ShoppingCart/Table.css">
            <asp:TableHeaderRow>
                
                <asp:TableHeaderCell> Name of item</asp:TableHeaderCell>
                <asp:TableHeaderCell id="headNo" Width="250"> Qty</asp:TableHeaderCell>
                <asp:TableHeaderCell>Price</asp:TableHeaderCell>
                <asp:TableHeaderCell>Remove</asp:TableHeaderCell>
            </asp:TableHeaderRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server"> This is the name boys</asp:Label>
                </asp:TableCell>
                <asp:TableCell >
                    <input class="Quantity" type="number" min="0" name="NoItems" />
                </asp:TableCell>
                <asp:TableCell>
                         <asp:Label runat="server"> 1 000 000</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server"> This is the name boys</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <input class="Quantity" type="number" min="0" name="NoItems" />
                </asp:TableCell>
                <asp:TableCell>
                         <asp:Label runat="server"> 1 000 000</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>

                <asp:TableCell>
                    <asp:Label runat="server"> This is the name boys</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <input class="Quantity" type="number" min="0" name="NoItems" />
                </asp:TableCell>
                <asp:TableCell>
                         <asp:Label runat="server"> 1 000 000</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                </asp:TableCell>
            </asp:TableRow>


            <asp:TableFooterRow>             
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell>Total:</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="TotalPrice">R 15120284</asp:TableHeaderCell>
            </asp:TableFooterRow>

        </asp:Table>
        <asp:Button ID="Accept" class="btnacc" runat="server" Text="Accept" OnClick="Accept_Click" />
    </div>
</asp:Content>
