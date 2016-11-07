<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script src="../scripts/CommonScrips/bootstrap.min.js"></script>
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/AdminCss/simple-sidebar.css" rel="stylesheet" />
    <link href="../Styling/AdminCss/font-awesome.min.css" rel="stylesheet" />
    <link href="../Styling/AdminCss/metisMenu.min.css" rel="stylesheet" />
    <link href="../Styling/AdminCss/morris.css" rel="stylesheet" />
    <script src="../scripts/AdminScripts/bootstrap.min.js"></script>
    <script src="../scripts/AdminScripts/jquery.min.js"></script>
    <script src="../scripts/AdminScripts/metisMenu.js"></script>
    <script src="../scripts/AdminScripts/morris-data.js"></script>
    <script src="../scripts/AdminScripts/morris.min.js"></script>
    <script src="../scripts/AdminScripts/raphael.min.js"></script>
    <script src="../scripts/AdminScripts/sb-admin-2.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="wrapper">
        <div id="sidebar-wrapper">
                <ul class="sidebar-nav">
                    <li class="sidebar-brand">
                        <a href="../Pages/AdminPage.aspx">
                            Welcome Admin   
                        </a>
                    </li>
                    <li>
                        <a href="../Pages/AdminPage.aspx" class ="active">Dashboard</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminAddUser.aspx">Add user</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminEditUser.aspx">Edit User</a>
                    </li>
                    <li>
                        <a href="../Pages/AddProduct.aspx">Add Product</a>
                    </li>
                </ul>
            </div>

<div id="page-content-wrapper">
        <div class="container-fluid">
    <div class="row">
        <div class="col-lg-12">
            <h1>Dash Board</h1>
            <br/>

            <!-- the cool boxes for text feed back </-->

            <div class="col-lg-4 col-md-4">
                <div class="panel panel-blue-green">
                    <div class="panel-words">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-dollar fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="huge" id ="cashGen" runat="server" contenteditable="true">1 000 000</div>
                                <div>Total generated Cash!</div>
                            </div>
                        </div>
                    </div>
            </div>
        </div>

            <div class="col-lg-4 col-md-4">
                    <div class="panel panel-green-yellow">
                        <div class="panel-words">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-shopping-cart fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div id="TxtTotalNoSales" class="huge" runat="server" contenteditable="true">DumbVal</div>
                                    <div>Total Generated Sales</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                  <div class="col-lg-4 col-md-4">
                    <div class="panel panel-orange">
                        <div class="panel-words">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-users fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge" id ="uniqCust" runat="server" contenteditable="true">DumbVal</div>
                                    <div>Total Unique customers</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            <div class="col-lg-4 col-md-4">
                    <div class="panel panel-Red">
                        <div class="panel-words">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-calendar-check-o fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge" id ="WeeklySaleNo" runat="server" contenteditable="true">DumbVal</div>
                                    <div>Weekly sales</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

             <div class="col-lg-4 col-md-4">
                    <div class="panel panel-Red-blue">
                        <div class="panel-words">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-bank fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge" id ="CashThisWeek" runat="server" contenteditable="true">DumbVal</div>
                                    <div>Cash generated this week</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            <div class="col-lg-4 col-md-4">
                    <div class="panel panel-black">
                        <div class="panel-words">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-align-justify fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge" id="TotalItems" runat="server" contenteditable="true">DumbVal</div>
                                    <div>Total number of items sold</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
            <!-- End of the cool boxes for text feed back </-->


            </div>
        </div>
    </div>
</div>
</asp:Content>
