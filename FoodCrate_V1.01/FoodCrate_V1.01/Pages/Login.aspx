<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta charset="utf-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <title>Login</title>

        <!-- CSS -->
        <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500"/>
        <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
        <link href="../Styling/LoginPage/font-awesome.min.css" rel="stylesheet" />
        <link href="../Styling/LoginPage/form-elements.css" rel="stylesheet" />
        <link href="../Styling/LoginPage/LoginStyling.css" rel="stylesheet" />

        <!-- Favicon and touch icons -->
        <link rel="shortcut icon" href="../Styling/Icons/favicon.png" />
        <link rel="apple-touch-icon-precomposed" sizes="144x144" href="../Styling/Icons/apple-touch-icon-114-precomposed.png" />
        <link rel="apple-touch-icon-precomposed" sizes="72x72" href="../Styling/Icons/apple-touch-icon-72-precomposed.png" />
        <link rel="apple-touch-icon-precomposed" href="../Styling/Icons/apple-touch-icon-57-precomposed.png" />      

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <!-- Top content -->
        <div class="top-content">
        	
            <div class="inner-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-sm-8 col-sm-offset-2 text">
                            <h1><strong>Food</strong>Crate!</h1>
                            <div class="description">
                            	<p>
                                     <strong>Join us! </strong> never stuggle to make a meal again
                                    We supply the freshest ingredients right to your door step in a premium package for your convienince
	                            	
                            	</p>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-sm-offset-3 form-box">
                        	<div class="form-top">
                        		<div class="form-top-left">
                        			<h3>Login to our site</h3>
                            		<p>Enter your username and password to log on:</p>
                        		</div>
                        		<div class="form-top-right">
                        			<i class="fa fa-lock"></i>
                        		</div>
                            </div>
                            <div class="form-bottom">
			                    <form role="form" action="" method="post" class="login-form">
			                    	<div class="form-group">
			                    		<label class="sr-only" for="form-username">Username</label>
			                        	<input type="text" name="form-username" placeholder="Username..." class="form-username form-control" id="form-username"/>
			                        </div>
			                        <div class="form-group">
			                        	<label class="sr-only" for="form-password">Password</label>
			                        	<input type="password" name="form-password" placeholder="Password..." class="form-password form-control" id="form-password"/>
			                        </div>
			                        <button type="submit" class="btn">Sign in!</button>
                                    <small><a id="LocalLog" href="#" >Need an account? </a></small>
			                    </form>
		                    </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-sm-offset-3 social-login">
                        	<h3>Social Media Logins:</h3>
                        	<div class="social-login-buttons">
	                        	<a class="btn btn-link-2" href="SocialMediaLogins/FbLog.aspx">
	                        		<i class="fa fa-facebook"></i> Facebook
	                        	</a>
	                        	<a class="btn btn-link-2" href="SocialMediaLogins/GooglePLog.asp">
	                        		<i class="fa fa-twitter"></i> Twitter
	                        	</a>
	                        	<a class="btn btn-link-2" href="SocialMediaLogins/TwitterLog.asp">
	                        		<i class="fa fa-google-plus"></i> Google Plus
	                        	</a>
                        	</div>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>


        <!-- Javascript -->
    <script src="../scripts/CommonScrips/bootstrap.min.js"></script>
    <script src="../scripts/CommonScrips/jquery-1.11.1.min.js"></script>
    <script src="../scripts/CommonScrips/jquery.backstretch.min.js"></script>
    <script src="../scripts/LoginScripts/scripts.js"></script>
   </body>
</asp:Content>
