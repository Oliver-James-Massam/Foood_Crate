<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm13" %>
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
        <script src="../scripts/LoginScripts/scriptsSign.js"></script>
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
                                     <strong>Awww yiss! </strong> Welcome to the well nourished side
	                            	
                            	</p>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-sm-offset-3 form-box">
                        	<div class="form-top">
                        		<div class="form-top-left">
                        			<h3>Join us!</h3>
                            		<p>Enter your details:</p>
                        		</div>
                        		<div class="form-top-right">
                        			<i class="fa fa-user-plus"></i>
                        		</div>
                            </div>
                            <div class="form-bottom">
			                    	<div class="form-group">
			                    		<label class="sr-only" for="form-username">Email</label>
			                        	<input type="text" name="form-username" placeholder="Email..." class="form-username form-control" id="form-username"/>
			                        </div>
			                        <div class="form-group">
			                        	<label class="sr-only" for="form-password">Password</label>
			                        	<input type="text" name="form-password" placeholder="Password..." class="form-password form-control" id="form-password"/>
			                        </div>
                                     <div class="form-group">
			                        	<label class="sr-only" for="form-password">Re-enter Password</label>
			                        	<input type="text" name="form-password" placeholder="Re-enter Password..." class="form-repassword form-control" id="form-repassword"/>
			                        </div>
                                    <div class="form-group">
			                        	<label class="sr-only" for="form-FirstName">First name</label>
			                        	<input type="text" name="form-FirstName" placeholder="First name..." class="form-Fname form-control" id="form-FirstName"/>
			                        </div>
                                    <div class="form-group">
			                        	<label class="sr-only" for="form-Surname">Surname</label>
			                        	<input type="text" name="form-Surname" placeholder="Surname..." class="form-surname form-control" id="form-Surname"/>
			                        </div>

			                        <button type="submit" class="btn">Sign in!</button>
		                    </div>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>
</asp:Content>
