<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="SCartReview.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/ShoppingCart/custom.css" rel="stylesheet" />
    <link href="../Styling/ShoppingCart/TableReview.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid breadcrumbBox text-center">
		<ol class="breadcrumb">
			<li><a href="../Pages/SCart.aspx">OverView</a></li>
			<li  class="active"><a href="../Pages/SCartReview.aspx">Discounts and tax</a></li>
			<li><a href="../Pages/ScartCheckOut.aspx">Checkout!</a></li>
		</ol>
	</div>
    <!-- insert the table for the review --> 
    <div>
        <div class ="Review">
        <asp:Table ID="Table1" runat="server">
               <asp:TableRow>
                   <asp:TableCell > <!-- This is the values with out any discounts or tax -->
                       Face Value 
                   </asp:TableCell>
                   <asp:TableCell ID ="FaceVal">
                        Amount
                   </asp:TableCell>
               </asp:TableRow>
    
            <asp:TableRow>
                   <asp:TableCell > <!-- Tax value -->
                       Tax
                   </asp:TableCell>
                   <asp:TableCell ID ="Tax">
                        14%
                   </asp:TableCell>
               </asp:TableRow>
            <asp:TableRow>
                   <asp:TableCell ID ="Tb3"> <!-- shipping is 0.02 of total if price is over 300 no shipping cost -->
                       Cost shipping! (if purchase is over R300) 
                   </asp:TableCell>
                   <asp:TableCell ID ="Shipping">
                        Free!/Not
                   </asp:TableCell>
               </asp:TableRow>

                <asp:TableRow>
                   <asp:TableHeaderCell BackColor="#ce4242" ForeColor="white" > <!-- shipping is 0.02 of total if price is over 300 no shipping cost -->
                       Total Due
                   </asp:TableHeaderCell>
                   <asp:TableCell ID ="Total" ForeColor="white" BackColor="#ea7070 ">
                         R58008
                   </asp:TableCell>
               </asp:TableRow>
        </asp:Table>
        </div>
    </div>
    <div>
        <asp:Button ID="Accept" class="ButSub" runat="server" Text="Accept and pay!" OnClick="Accept_Click" />
        </div>
</asp:Content>
