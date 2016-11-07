<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/Home/css/SearchStyle.css?version=1.0" rel="stylesheet" />
    <link href="../Styling/PreviewCard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Welcome Message -->
    <div class="page" style="padding-top:50px;">
        <div class="page_header">
            <h1>Welcome <%Response.Write(Session["user"]); %></h1>
            <hr class="style12" />
        </div>
    </div>
    <!-- Search Bar -->
    <div class="container">
        <div class="row">
            <div id="custom-search-input">
                <div class="input-group col-md-12">
                    <input type="text" class="  search-query form-control" placeholder="Search our Catalogue by the Name or Type of Product" />
                    <span class="input-group-btn">
                        <button class="btn btn-danger" type="button">
                            <span> <i class="fa fa-search"></i></span>
                        </button>
                    </span>
                </div>
            </div>
        </div>
    </div>
    <!-- Card Display -->
    <div id="cardDisplay" class="cardDisplay">
        <div class='card'>
            <div class='card_top'>
                <img src="../Images/Food/onions.jpg" />
            </div>
            <div class='card_bottom'>
                <h2>Test Heading Is Quite Long</h2>
                <div class='card_bottom__description'>
                    <p>
                        The milk is full cream from clovers prestigious dairy farms
                    </p>
                    <!-- Need Dynamic Pages in the href below for each product -->
                    <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
