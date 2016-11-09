<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <!-- CSS -->
        <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500"/>
        <link href="../Styling/BootStrap/bootstrap.min.css" rel="stylesheet" />
        <link href="../Styling/LoginPage/font-awesome.min.css" rel="stylesheet" />
        <link href="../Styling/LoginPage/form-elements.css" rel="stylesheet" />
        <link href="../Styling/LoginPage/LoginStyling.css" rel="stylesheet" />
        <script src="../scripts/CommonScrips/bootstrap.min.js"></script>
        <script src="../scripts/CommonScrips/jquery-1.11.1.min.js"></script>
        <script src="../scripts/CommonScrips/jquery.backstretch.min.js"></script>
        <script src="../scripts/LoginScripts/scripts.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
			                    	<div class="form-group">
			                    		<label class="sr-only" for="form-username">Username</label>
			                        	<input type="text" runat="server" name="form-username" placeholder="Username..." class="form-username form-control" id="username"/>
			                        </div>
			                        <div class="form-group">
			                        	<label class="sr-only" for="form-password">Password</label>
			                        	<input type="password" runat="server" contenteditable="true" name="form-password" placeholder="Password..." class="form-password form-control" id="password"/>
			                        </div>

			                        <button type="submit" runat="server" onserverclick="Unnamed_ServerClick" class="btn">Sign in!</button>
                                    <small><a id="LocalLog" href="../Pages/Signup.aspx" >Need an account? </a></small>
		                    </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-sm-offset-3 social-login">
                        	<h3>Social Media Logins:</h3>
                        	<div class="social-login-buttons">
	                        	<a class="btn btn-link-2" href="https://www.facebook.com/v2.4/dialog/oauth/?client_id= 1758990991018810 &redirect_uri=http://localhost:58267/Pages/Auth.aspx&response_type=code&state=1&scope=email">
	                        		<i class="fa fa-facebook"></i> Facebook
	                        	</a>
                                <!--
	                        	<a class="btn btn-link-2" href="https://accounts.google.com/o/oauth2/auth?redirect_uri=http://localhost:58267/Pages/GoogleAuth.aspx&response_type=code&client_id=1057923077800-6s9t8ailp3lpihdhqup80sei93crmq3k.apps.googleusercontent.com&scope=https://www.googleapis.com/auth/analytics.readonly+https://www.googleapis.com/auth/userinfo.email&approval_prompt=force&access_type=offline">
	                        		<i class="fa fa-google-plus"></i> Google Plus
	                        	</a>
                                -->
                        	</div>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>
</asp:Content>
