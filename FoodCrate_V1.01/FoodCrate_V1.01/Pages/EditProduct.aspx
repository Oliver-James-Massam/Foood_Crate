<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../scripts/CommonScrips/bootstrap.min.js"></script>
    <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styling/AdminCss/simple-sidebar.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div id ="wrapper">
        <div id="sidebar-wrapper">
                <ul class="sidebar-nav">
                    <li class="sidebar-brand">
                        <a href="../Pages/AdminPage.aspx">Welcome Admin</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminPage.aspx">Dashboard</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminAddUser.aspx">Add user</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminDeleteUser.aspx" ">Remove User</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminEditUser.aspx">Edit User</a>
                    </li>   
                    <li>
                        <a href="../Pages/EditProduct.aspx" class ="active">Edit Product</a>
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
                            <h1>Edit Product</h1>


                            <!-- Add the layyout you need here --> 

                            <!-- TextBox block -->
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
                            <!-- just change the text for the context you need -->

            <!-- Button            block -->
                    <br />

        <div class="row">                                    
            <div class="col-md-12">
                <asp:Button ID="btnDelete" runat="server" Text="Delete user" class="btn btn-success" />
        </div>  
        </div>

            <!-- -->

                </div> </div>
        </div></div>
    </div></div></div>

</asp:Content>
