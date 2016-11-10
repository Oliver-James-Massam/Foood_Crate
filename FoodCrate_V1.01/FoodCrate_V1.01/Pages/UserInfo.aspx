<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="FoodCrate_V1._01.Pages.UserInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styling/Home/css/UserDetails.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'/>
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container" style="margin-top: 20px; margin-bottom: 20px;">
	<div class="row panel">
		<div class="col-md-4 bg_blur ">

		</div>
        <div class="col-md-8  col-xs-12">
           <div class="header">
                <h1 id ="dataholder1" runat="server" contenteditable="true">Name / Surname</h1>
                <p>Email:</p> <p id="Emailaddr" runat="server" contenteditable="true">LOL@LanceWhy.com</p>
               <br />
            <div class="row">
                <div class="col-md-12" id="Name">
                    <div class="group">
                        <div class="col-sm-2">
                        <label class="NameEdit">New name of user:</label>
                            </div>
                        <div class="col-md-10">
                        <input id="ChangeName" type="text" runat="server" contenteditable="true" name="Name" class="form-control" placeholder="Please enter the new name" required="required" data-error="Please enter a name."/>
                        </div>
                    </div>
                </div>
            </div>
               <br />
            <div class="row">
                <div class="col-md-12" id="Surname">
                    <div class="group">
                        <div class="col-sm-2">
                        <label class="NameEdit">New name of user:</label>
                            </div>
                        <div class="col-md-10">
                        <input id="SurnameChange" type="text" runat="server" contenteditable="true" name="surname" class="form-control" placeholder="Please enter the new Surname" required="required" data-error="Please enter a surname."/>
                        </div>
                    </div>
                </div>
            </div>
               <br />
                                                  
            <div class="col-md-12">
                        <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" class="btn btn-success btn-send enabled" Width="100%" runat="server" Text="Update User" />
                </div>
           </div>
        </div>
    </div>   
    
</div>

</asp:Content>
