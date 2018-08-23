<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SportFinder._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container heading">
        <h1>Sport Finder</h1>
        <h2>Playing sports is a favorite activity for many people around the world. It provides us with enjoyment and also freshens up our mind. 
            Indulging in sports helps our body function smoothly and more efficiently. Sports involve the activity of each and every muscle in our body. 
            This strengthens the body and promotes good health.
        </h2>
        <h2>
            This test helps you understand what kind of activity you should go for. When you are ready please press Start and select an answer from the following questions.
        </h2>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row questions">
                    <div class="col-sm-12">               
                        <asp:Button ID="StartBtn" runat="server" Text="Start" OnClick="StartBtn_Click" CssClass="button" Font-Bold="True" />

                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View1" runat="server">
                                <asp:Label ID="Option1Lbl" runat="server" Text="Label">In team sport, working together and relying on teammates are qualities worth fostering. 
                                    In individual sport, the ability to rely on yourself and a discipline to keep yourself accountable are critical for success.
                                    Wich sport would you like to begin with?
                                </asp:Label>
                                <br />
                                <asp:Button ID="TeamBtn" runat="server" OnClick="TeamBtn_Click" Text="Team" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="IndividualBtn" runat="server" OnClick="IndividualBtn_Click" Text="Individual" CssClass="button" Font-Bold="True" />
                            </asp:View>
                        </asp:MultiView>
                        <br /><br />
                        <asp:MultiView ID="MultiView2" runat="server">
                            <asp:View ID="View2" runat="server">
                                <asp:Label ID="Option2Lbl" runat="server" Text="Label">Are you a speed addict or you prefer something more chilled?</asp:Label>
                                <br />
                                <asp:Button ID="FastBtn" runat="server" OnClick="FastBtn_Click" Text="Fast" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="SlowBtn" runat="server" OnClick="SlowBtn_Click" Text="Slow" CssClass="button" Font-Bold="True" />
                            </asp:View>
                        </asp:MultiView>
                        <br /><br />
                        <asp:MultiView ID="MultiView3" runat="server">
                            <asp:View ID="View3" runat="server">
                                <asp:Label ID="Option3Lbl" runat="server" Text="Label">In summer you have the possibility to face many outdoor activities but
                                    people tend to only do sports in summer which leads to a non balanced lifestyle and health. 
                                    If you want to become successful in the areas of health, profession, and sports you definitely need to do winter sports as well.
                                </asp:Label>
                                <br />
                                <asp:Button ID="SummerBtn" runat="server" OnClick="SummerBtn_Click" Text="Summer" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="WinterBtn" runat="server" OnClick="WinterBtn_Click" Text="Winter" CssClass="button" Font-Bold="True" />
                            </asp:View>
                        </asp:MultiView>
                        <br /><br />
                        <asp:MultiView ID="MultiView4" runat="server">
                            <asp:View ID="View4" runat="server">
                                <asp:Label ID="Option4Lbl" runat="server" Text="Label">Despite the differences between indoor sports and outdoor sports, there is no clear ‘winner’ 
                                    to this debate. The true answer is based solely on each and every individual’s preference. 
                                    And so, I ask you: Which one will you choose, outdoor or indoor sports?
                                </asp:Label>
                                <br />
                                <asp:Button ID="IndoorBtn" runat="server" OnClick="IndoorBtn_Click" Text="Indoor" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="OutdoorBtn" runat="server" OnClick="OutdoorBtn_Click" Text="Outdoor" CssClass="button" Font-Bold="True" />
                            </asp:View>
                            <asp:View ID="View5" runat="server">
                                <asp:Label ID="Option5Lbl" runat="server" Text="Label">A winter sport is a recreational activity which is played on snow or ice. Which area do you prefer?</asp:Label>
                                <br />
                                <asp:Button ID="SnowBtn" runat="server" OnClick="SnowBtn_Click" Text="Snow" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="IceBtn" runat="server" OnClick="IceBtn_Click" Text="Ice" CssClass="button" Font-Bold="True" />
                            </asp:View>
                        </asp:MultiView>
                        <br /><br />
                        <asp:MultiView ID="MultiView5" runat="server">
                            <asp:View ID="View6" runat="server">
                                <asp:Label ID="Option6Lbl" runat="server" Text="Label">And finnaly choose a kind of activity from the following list os sports/games.</asp:Label>
                                <br />
                                <asp:Button ID="BallBtn" runat="server" OnClick="BallBtn_Click" Text="Ball" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="WaterBtn" runat="server" OnClick="WaterBtn_Click" Text="Water" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="WheelsBtn" runat="server" OnClick="WheelsBtn_Click" Text="Wheels" CssClass="button" Font-Bold="True" />
                                <asp:Button ID="CombatBtn" runat="server" OnClick="CombatBtn_Click" Text="Combat" CssClass="button" Font-Bold="True" />
                            </asp:View>
                        </asp:MultiView>
                        <br /><br />
                        <asp:Button ID="ResultsBtn" runat="server" Text="Results" Visible="false" OnClick="ResultsBtn_Click" CssClass="button" Font-Bold="True"/>
                    </div>
                </div>
                <div class="row answers">
                    <div class="col-sm-12">  
                        <asp:Label ID="ResultsTxtLbl" runat="server" Text="Label" Visible="false" CssClass="answerTextLabel">According to Sport Finder, the type of activity you should focus on is/are: </asp:Label>
                        <br />
                        <asp:Label ID="ResultsLbl" runat="server" Text="Label" Visible="false" CssClass="answerLabel"></asp:Label>
                    </div>
                </div>
            </div>
	    </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
