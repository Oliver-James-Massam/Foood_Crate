<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FoodCrate_V1._01.Pages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Food Crate</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Header -->
    <a name="about"></a>
    <div class="intro-header">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="intro-message">
                        <h1 style="color:#FFFFFF;">Food Crate</h1>
                        <h3 style="color:#FFFFFF;">Fresh ingredients delivered to your door!</h3>
                        <hr class="intro-divider"/>
                        <ul class="list-inline intro-social-buttons">
                            <li>
                                <a href="Catalog.aspx" class="btn btn-default btn-lg"><i class="fa fa-th-list fa-fw"></i> <span class="page-name">Product Catalogue</span></a>
                            </li>
                            <li runat="server" onserverclick="checkLogout">
                                <% if (Session["login"].Equals(false)) %>
                                <%{ %>
                                    <a href="Login.aspx" class="btn btn-default btn-lg"><i class="fa fa-user fa-fw"></i> <span class="page-name">Login</span></a>
                                <%} %>
                                <%else %>
                                <%{ %>
                                    <a id="logoutHome" href="Login.aspx" class="btn btn-default btn-lg"><i class="fa fa-user fa-fw"></i> <span class="page-name">Logout</span></a>
                                <%} %>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.intro-header -->

    <!-- Page Content -->

	<a  name="services"></a>
    <div class="content-section-a">

        <div class="container">
            <div class="row">
                <div class="col-lg-5 col-sm-6">
                    <hr class="section-heading-spacer"/>
                    <div class="clearfix"></div>
                    <h2 class="section-heading" style="color:#B20000;">Large Ingredient List</h2>
                    <p class="lead">You never have to wait in lines at the shops ever again as we stock all major name brand products. If you can find it in either your local Pick 'n Pay, Spar or Checkers then we will most likely have it. If not, we're probably adding it to our database as we speak.</p>
                </div>
                <div class="col-lg-5 col-lg-offset-2 col-sm-6">
                    <a href="Catalog.aspx">
                        <img class="img-responsive" src="../Images/HomePage/ingredients.jpg" alt="Ingredients"/>
                    </a>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.content-section-a -->

    <div class="content-section-b">

        <div class="container">

            <div class="row">
                <div class="col-lg-5 col-lg-offset-1 col-sm-push-6  col-sm-6">
                    <hr class="section-heading-spacer"/>
                    <div class="clearfix"></div>
                    <h2 class="section-heading" style="color:#B20000;">Delivery to your Doorstep</h2>
                    <p class="lead">We supply the freshest ingredients right to your door step in a premium package for your convienince. You name the place and we'll deliver it!</p>
                </div>
                <div class="col-lg-5 col-sm-pull-6  col-sm-6">
                    <a href="Catalog.aspx">
                        <img class="img-responsive" src="../Images/HomePage/delivery.jpg" alt="FedEx Courier"/>
                    </a>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.content-section-b -->

    <div class="content-section-a">

        <div class="container">

            <div class="row">
                <div class="col-lg-5 col-sm-6">
                    <hr class="section-heading-spacer"/>
                    <div class="clearfix"></div>
                    <h2 class="section-heading" style="color:#B20000;">Order Items based on Recipes</h2>
                    <p class="lead">Coming Soon! Select an existing recipe or create your own and have your shopping cart filled with all the ingredients they require.</p>
                </div>
                <div class="col-lg-5 col-lg-offset-2 col-sm-6">
                    <a href="Catalog.aspx">
                        <img class="img-responsive" src="../Images/HomePage/recipe.jpg" alt="Ingredients by Recipe"/>
                    </a>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    

    <!-- Footer -->
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <p class="copyright text-muted small">Copyright &copy; FoodCrate 2016. All Rights Reserved</p>
                </div>
            </div>
        </div>
    </footer>

    <!-- jQuery -->
    <script src="../scripts/CommonScrips/jquery-1.11.1.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../scripts/CommonScrips/bootstrap.min.js"></script>
</asp:Content>
