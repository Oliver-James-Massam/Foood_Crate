<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Global.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="FoodCrate_V1._01.MasterPage.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="../Styling/PreviewCard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="page">
        <div class="page_header">
            <h1>Welcome Lance Govender</h1>
            <hr class="style12" />
        </div>
    </div>
    <div><!--This is Test Display-->
        <table>
            <tr>
                <td>
                    <div class='card'>
                        <div class='card_top'>
                            <img src="../Images/Food/onions.jpg" />
                        </div>
                        <div class='card_bottom'>
                            <h2>Test Heading Is Quite Long</h2>
                            <div class='card_bottom__description'>
                                <!-- Limited to a maximum of 60 words -->
                                <p>
                                    The lead character, called 'The Bride,' was a member
                                    of the Deadly Viper Assassination Squad, led by her
                                    lover 'Bill.' Upon realizing she was pregnant with Bill's
                                    child, 'The Bride' decided to escape her life as a killer.
                                    She fled to Texas, met a young man, who, on the day
                                    of their wedding rehearsal was gunned down by....
                                </p>
                                <!-- Need Dynamic Pages in the href below for each product -->
                                <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                            </div>
                        </div>
                    </div>
                </td>
                <td>
                    <div class='card'>
                        <div class='card_top'>
                            <img src="../Images/Error/Error_Image_Not_Found3.png" />
                        </div>
                        <div class='card_bottom'>
                            <h2>Clover Milk</h2>
                            <div class='card_bottom__description'>
                                <p>
                                    The lead character, called 'The Bride,' was a member
                                    of the Deadly Viper Assassination Squad, led by her
                                    lover 'Bill.' Upon realizing she was pregnant with Bill's
                                    child, 'The Bride' decided to escape her life as a killer.
                                    She fled to Texas, met a young man, who, on the day
                                    of their wedding rehearsal was gunned down by....
                                </p>
                                <!-- Need Dynamic Pages in the href below for each product -->
                                <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                            </div>
                        </div>
                    </div>
                </td>
                <td>
                    <div class='card'>
                        <div class='card_top'>
                            <img src="../Images/Food/strawberries.jpg">
                        </div>
                        <div class='card_bottom'>
                            <h2>Test Heading Is Quite Long</h2>
                            <div class='card_bottom__description'>
                                <p>
                                    The lead character, called 'The Bride,' was a member
                                    of the Deadly Viper Assassination Squad, led by her
                                    lover 'Bill.' Upon realizing she was pregnant with Bill's
                                    child, 'The Bride' decided to escape her life as a killer.
                                    She fled to Texas, met a young man, who, on the day
                                    of their wedding rehearsal was gunned down by....
                                </p>
                                <!-- Need Dynamic Pages in the href below for each product -->
                                <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                            </div>
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class='card'>
                        <div class='card_top'>
                            <img src="../Images/Food/onions.jpg">
                        </div>
                        <div class='card_bottom'>
                            <h2>Test Heading Is Quite Long</h2>
                            <div class='card_bottom__description'>
                                <p>
                                    this is a short one
                                </p>
                                <!-- Need Dynamic Pages in the href below for each product -->
                                <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                            </div>
                        </div>
                    </div>
                </td>
                <td>
                    <div class='card'>
                        <div class='card_top'>
                            <img src="../Images/Error/Error_404_Not_Found3.png" />
                        </div>
                        <div class='card_bottom'>
                            <h2>Test Heading Is Quite Long</h2>
                            <div class='card_bottom__description'>
                                <p>
                                    dfdsfsdfsdfsdfafasdf dsfasdf asdfdsa fdsfasdfadf adsf asd asdf d a f asd fasd fas fasd fasdf afafsad  
                                </p>
                                <!-- Need Dynamic Pages in the href below for each product -->
                                <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                            </div>
                        </div>
                    </div>
                </td>
                <td>
                    <div class='card'>
                        <div class='card_top'>
                            <img src="../Images/Food/strawberries.jpg" />
                        </div>
                        <div class='card_bottom'>
                            <h2>Test Heading Is Quite Long</h2>
                            <div class='card_bottom__description'>
                                <p>
                                    The lead character, called 'The Bride,' was a member
                                    of the Deadly Viper Assassination Squad, led by her
                                    lover 'Bill.' Upon realizing she was pregnant with Bill's
                                    child, 'The Bride' decided to escape her life as a killer.
                                    She fled to Texas, met a young man, who, on the day
                                    of their wedding rehearsal was gunned down by....
                                </p>
                                <!-- Need Dynamic Pages in the href below for each product -->
                                <a href='../Pages/Catalog.aspx' target='_blank'>Read more</a>
                            </div>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
