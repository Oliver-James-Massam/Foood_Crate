<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Auth.aspx.cs" Inherits="FoodCrate_V1._01.Pages.Auth" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>Id:</td>
                            <td><%# Eval("id") %><br />
                                <td>koisdgsdfg </td>
                            </td>
                        </tr>
                        <tr>
                            <td>First Name:</td>
                            <td><%# Eval("first_name") %><br />
                            </td>
                        </tr>
                        <tr>
                            <td>Last Name:</td>
                            <td><%# Eval("last_name") %><br />
                            </td>
                        </tr>
                        <tr>
                            <td>Email:</td>
                            <td><%# Eval("email") %><br />
                            </td>
                        </tr>
                        <tr>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:ListView>
        </div>
</asp:Content>
