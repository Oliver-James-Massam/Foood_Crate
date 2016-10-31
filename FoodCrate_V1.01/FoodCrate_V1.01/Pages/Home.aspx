<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FoodCrate_V1._01.Pages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Food Crate</title>

    <!-- Bootstrap Core CSS -->
    <link href="../Styling/Home/css/bootstrap.min.css" rel="stylesheet"/>

    <!-- Custom CSS -->
    <link href="../Styling/Home/css/landing-page.css" rel="stylesheet"/>

    <!-- Custom Fonts -->
    <link href="../Styling/Home/font/font-awesome.min.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<!-- Navigation-->
    <nav class="navbar navbar-default navbar-fixed-top topnav" role="navigation">
        <div class="container topnav">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand topnav" href="#">Start Bootstrap</a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a href="#about">About</a>
                    </li>
                    <li>
                        <a href="#services">Services</a>
                    </li>
                    <li>
                        <a href="#contact">Contact</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav> --%>


    <!-- Header -->
    <a name="about"></a>
    <div class="intro-header">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="intro-message">
                        <h1>Food Crate</h1>
                        <h3>Fresh ingredients delivered to your door!</h3>
                        <hr class="intro-divider"/>
                        <ul class="list-inline intro-social-buttons">
                            <li>
                                <a href="Information.aspx" class="btn btn-default btn-lg"><i class="fa fa-info-circle fa-fw"></i> <span class="page-name">About Us</span></a>
                            </li>
                            <li>
                                <a href="Catalog.aspx" class="btn btn-default btn-lg"><i class="fa fa-th-list fa-fw"></i> <span class="page-name">Product Catalogue</span></a>
                            </li>
                            <li>
                                <a href="Login.aspx" class="btn btn-default btn-lg"><i class="fa fa-user fa-fw"></i> <span class="page-name">Login</span></a>
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
                    <h2 class="section-heading">Large Ingredient List</h2>
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
                    <h2 class="section-heading">Delivery to your Doorstep</h2>
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
                    <h2 class="section-heading">Order Items based on Recipes</h2>
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
