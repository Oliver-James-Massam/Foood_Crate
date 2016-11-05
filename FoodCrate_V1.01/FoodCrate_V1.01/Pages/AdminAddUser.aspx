<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="AdminAddUser.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm5" %>
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
                        <a href="../Pages/AdminPage.aspx">
                            Welcome Admin   
                        </a>
                    </li>
                    <li>
                        <a href="../Pages/AdminPage.aspx"  >Dashboard</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminAddUser.aspx" class ="active">Add user</a>
                    </li>
                    <li>
                        <a href="../Pages/AdminDeleteUser.aspx">Remove User</a>
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
                            <h1>Add a new User/ Employee</h1>
                            <br/>

                            <div class="row">
                                <div class="col-md-11">
                                    <div class="group">
                                        <div class="col-sm-1">
                                        <label class="name">Firstname:</label>
                                            </div><div class="col-md-11">
                                        <input id="input_name" type="text" name="name" class="form-control" runat="server" contenteditable="true" placeholder="Please enter your firstname" required="required" data-error="Please enter a Firstname."/>
                                                </div>
                                    </div>
                                </div>
                                </div>
                            <div class="row">
                                <div class="col-md-11">
                                    <div>
                                        <div class="col-sm-1">
                                        <label class="lastname">Lastname:</label>
                                            </div>
                                        <div class="col-md-11">
                                        <input id="input_lastname" type="text" name="surname" class="form-control" runat="server" contenteditable="true" placeholder="Please enter your surname" required="required" data-error="Please enter a Lastname."/>
                                            </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-11">
                                    <div class="col-sm-1">
                                        <label class="email">Email:</label>
                                        </div>
                                    <div class="col-md-11">
                                        <input id="input_email" type="email" name="email" class="form-control" runat="server" contenteditable="true" placeholder="Please enter your email" required="required" data-error="Please enter a Valid email."/>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                <div class="col-md-11">
                                    <div class="col-sm-1">
                                        <label class="password">Password:</label>
                                        </div>
                                    <div class="col-md-11">
                                        <input id="input_password" type="text" runat="server" contenteditable="true" name="passwrd" class="form-control" placeholder="Please enter your password" required="required" data-error="Please enter a password."/>
                                        </div>
                                    </div>
                                </div>

                            <div class="row">
                                <div class="col-md-11">
                                    <div class="col-sm-1">
                                <label class="Emp">Employee:</label>
                                    </div>
                                    <div class="col-md-11" >
                                        <asp:CheckBox ID="CheckIsAdmin" runat="server" value="false"/>
                                    </div>
                                </div>
                            </div>
                            <br />

                             <div class="row">                                    
                                 <div class="col-md-12">
                                     <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add user" class="btn btn-success" />
                                </div>  
                            </div>
                          </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>