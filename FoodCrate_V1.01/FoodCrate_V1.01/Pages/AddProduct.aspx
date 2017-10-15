<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm7" %>
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
                        <a href="../Pages/AdminEditUser.aspx">Edit User</a>
                    </li>
                    <li>
                        <a href="../Pages/AddProduct.aspx" class ="active">Add Product</a>
                    </li>
                </ul>
            </div>

        <div id="page-content-wrapper">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <%--Heading--%>
                        <h1>Add Product</h1>
                        <%--Product Name--%>
                        <div class="form-group">
                            <label for="txtName">Product Name</label>
                            <input type="text" class="form-control" id="txtName" placeholder="e.g. Huletts White Sugar" runat="server"/>
                        </div>
                        <%--Product Type--%>
                        <div class="form-group">
                            <label for="txtType">Product Type</label>
                            <input type="text" class="form-control" id="txtType" placeholder="e.g. Sugar" runat="server"/>
                        </div>

                        <%--Product Description--%>
                        <div class="form-group">
                            <label for="txtDescription">Product Description</label>
                            <textarea class="form-control" id="txtDescription" rows="3" placeholder="Maximum of 255 characters" runat="server"></textarea>
                        </div>

                        <%--Product Weight--%>
                        <div class="form-group">
                            <div class="form-row">
                                <label for="txtWeight">Product Weight</label>
                                <div class="input-group">
                                    <span class="input-group-addon">g</span>
                                    <input type="number" value="500" min="0" step="1" data-number-to-fixed="2" data-number-stepfactor="100" class="form-control currency" id="txtWeight" style="width: 15%;" runat="server"/>
                                </div>
                            </div>
                        </div>
                        <%--Product Price--%>
                        <div class="form-group">
                            <div class="form-row">
                                <label for="txtPrice">Product Price</label>
                                <div class="input-group">
                                    <span class="input-group-addon">R</span>
                                    <input type="number" value="49.99" min="0" step="0.01" data-number-to-fixed="2" data-number-stepfactor="100" class="form-control currency" id="txtPrice" style="width: 15%;" runat="server" />
                                </div>
                            </div>
                        </div>

                        <%--Product Picture--%>
                        <div class="form-group">
                            <label for="txtPicture">Product Picture Name (including extension)</label>
                            <input type="text" class="form-control" id="txtPicture" value="noimage.jpg" aria-describedby="imageHelp" runat="server"/>
                            <small id="imageHelp" class="form-text text-muted">Dont forget to add the image extension (e.g. .jpeg or .png). If no image is available, leave it as noimage.jpg</small>
                        </div>
                        <br />
                        <button type="submit" class="btn btn-primary" runat="server" onserverclick="addProduct">Add</button>
                    </div>
                </div>
            </div>
        </div>

    </div>


</asp:Content>
