<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="AdminDeleteUser.aspx.cs" Inherits="FoodCrate_V1._01.Pages.AdminDeleteUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../scripts/CommonScrips/bootstrap.min.js"></script>
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/AdminCss/simple-sidebar.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.1.0.min.js" ></script>
    <script src="../scripts/AdminScripts/bootstrap-checkbox.min.js"></script>
    <script src="../scripts/AdminScripts/bootstrap-checkbox.js"></script>
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
                        <a href="../Pages/AdminPage.aspx">Dashboard</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminAddUser.aspx">Add user</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminDeleteUser.aspx" class ="active">Remove User</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminEditUser.aspx">Edit User</a>
                    </li>
                    <li>
                        <a href="../Pages/EditProduct.aspx">Edit Product</a>
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
                            <h1>Delete users or admins</h1>
    <div class="row">
        <div class="col-md-12" id="Block">
            <div class="group">
                <div class="col-sm-2">
                <label class="EmailDelete">Email of user:</label>
                    </div>
                <div class="col-md-10">
                <input id="delete_Email" type="email" name="Email" class="form-control" placeholder="Please enter the Email" required="required" data-error="Please enter a email."/>
                        </div>
            </div>

        <div class="row">
        <div class="col-md-12">
            <div class="col-sm-2">
        <label class="Emp">Is this an employee:</label>
            </div>
            <div class="col-md-10" >
                <asp:CheckBox ID="CheckIsSure" Checked="false" runat="server" />
            </div>
        </div>
        </div>
        <br />

        <div class="row">                                    
            <div class="col-md-12">
                <asp:Button ID="btnDelete" runat="server" Text="Delete user" class="btn btn-success" />
        </div>  
        </div>


        </div>
        </div>
</div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>