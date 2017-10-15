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
    <div class="col-centered" >
        <div class='col-lg-9' >
            <div id="prodDetails" class='thumbnail' runat='server'>
            </div>
        </div>
    </div>
    <div class="col-centered">
        <div class='col-lg-9' style="border-top:none;">
            <div id="prodDetails2" class='thumbnail' runat='server'>
                <div class="form-group">
                            <div class="form-row" style="padding-left:1%;">
                                <div class="input-group">
                                    <span class="input-group-addon">Quantity</span>
                                    <input type="number" value="1" min="1" step="1" data-number-to-fixed="2" data-number-stepfactor="100" class="form-control currency" id="txtQuantity" style="width: 10%;" runat="server"/>
                                </div>
                            </div>
                        </div>
                <a class='btn btn-success' id='Buy' runat='server' onserverclick='addToCart_Click'>Add to Cart</a>
            </div>
        </div>
    </div>
    
</asp:Content>
