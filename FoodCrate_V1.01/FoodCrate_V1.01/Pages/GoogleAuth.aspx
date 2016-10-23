<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="GoogleAuth.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="Login" />
    <asp:Panel ID="pnlProfile" runat="server" Visible="false">
    <hr />
    <table>
        <tr>
            <td rowspan="6" valign="top">
                <asp:Image ID="ProfileImage" runat="server" Width="50" Height="50" />
            </td>
        </tr>
        <tr>
            <td>
                ID:
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name:
                <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Email:
                <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Gender:
                <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Type:
                <asp:Label ID="lblType" runat="server" Text=""></asp:Label>
            </td>
        </tr>
            <tr>
            <td>
                <asp:Button Text="Clear" runat="server" OnClick = "Clear" />
            </td>
        </tr>
    </table>
    </asp:Panel>
</asp:Content>
