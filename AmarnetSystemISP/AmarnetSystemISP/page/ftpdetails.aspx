<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ftpdetails.aspx.cs" Inherits="StartNetwork.page.ftpdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aamarnet System | FTP Collection</title>
    <link href="/sitecontent/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/ftp/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="/ftp/css/custom-css.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="fb-root"></div>
        <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.4";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
        <!---start-header---->
        <div class="header">
            <div class="wrap">
                <!---start-logo---->
                <div class="logo">
                    <a href="/index.aspx">
                        <img style="height: 120px; width: 700px;" src="/sitecontent/img/aamarnet.gif" class="img-responsive" /></a>
                </div>
                <!---End-logo---->
                <!---start-top-menu-search---->
                <div class="top-menu">
                    <div class="top-nav">
                        <%-- <ul>
                           <li><a href="/page/ftp.aspx">Home</a></li>
                        </ul>--%>
                    </div>
                    <div class="search">

                        <asp:TextBox runat="server" ID="searchTxtBx" CssClass="textbox" value="Search:" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Search';}"></asp:TextBox>
                        <asp:Button runat="server" ID="searchButton" OnClick="searchButton_OnClick" />

                    </div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
                <!---End-top-menu-search---->
            </div>
            <!---End-header---->
        </div>
        <div class="wrap">
            <div class="custom-menu">
                <ul>
                    <a href="/page/ftp.aspx" style="color: #000000">
                        <li>Home</li>
                    </a>
                    <li>Movies
                        <ul>

                            <asp:LinkButton runat="server" ID="BanglaMovie" OnClick="BanglaMovie_OnClick"><li>Bangla</li></asp:LinkButton>

                            <asp:LinkButton runat="server" ID="HindiMovie" Text="Hindi" OnClick="HindiMovie_OnClick"><li>Hindi</li> </asp:LinkButton>

                            <asp:LinkButton runat="server" ID="EnglishMovie" Text="" OnClick="EnglishMovie_OnClick"><li>English</li></asp:LinkButton>
                            <asp:LinkButton runat="server" ID="TamilMovie" Text="" OnClick="TamilMovie_Click"><li>Tamil</li></asp:LinkButton>
                        </ul>
                    </li>
                    <li>Songs (Audio)
                            <ul>

                                <asp:LinkButton runat="server" ID="BanlaAudioSongs" Text="" OnClick="BanlaAudioSongs_OnClick"><li>Bangla</li></asp:LinkButton>


                                <asp:LinkButton runat="server" ID="HindiAudioSongs" Text="" OnClick="HindiAudioSongs_OnClick"><li>Hindi</li></asp:LinkButton>

                                <asp:LinkButton runat="server" ID="EnglishAudioSongs" Text="" OnClick="EnglishAudioSongs_OnClick"><li>English</li></asp:LinkButton>
                            </ul>
                    </li>
                    <li>Songs (Video)
                            <ul>

                                <asp:LinkButton runat="server" ID="BanglaVedioSongs" Text="" OnClick="BanglaVedioSongs_OnClick"><li>Bangla</li></asp:LinkButton>

                                <asp:LinkButton runat="server" ID="HindiVideoSongs" Text="" OnClick="HindiVideoSongs_OnClick"><li>Hindi</li></asp:LinkButton>

                                <asp:LinkButton runat="server" ID="EnglishVideoSongs" Text="" OnClick="EnglishVideoSongs_OnClick"><li>English</li></asp:LinkButton>
                            </ul>
                    </li>
                    <asp:LinkButton runat="server" ID="Natok" Text="" OnClick="Natok_Click" Style="color: #000000"><li>Natok</li></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="Software" Text="" OnClick="Software_OnClick" Style="color: #000000"><li>Software</li></asp:LinkButton>

                    <asp:LinkButton runat="server" ID="Cartoon" Text="" OnClick="Cartoon_OnClick" Style="color: #000000"><li>Cartoon</li></asp:LinkButton>

                    <asp:LinkButton runat="server" ID="PcGams" Text="" OnClick="PcGams_OnClick" Style="color: #000000"><li>PC Games</li></asp:LinkButton>
                </ul>
            </div>
            <div class="clear"></div>

        </div>
        <div class="clear"></div>
        <!---start-content---->
        <div class="main-content">
            <div class="wrap">
                <div class="left-sidebar">
                    <div class="sidebar-boxs">
                        <div class="sidebar-box">

                            <a href="#"></a>
                        </div>
                        <div class="clear"></div>
                        <div class="type-videos">
                            <h3>Make Request</h3>
                            <div class="fb-comments" data-href="http://aamarnet.net/page/ftp.aspx" data-width="265" data-numposts="10"></div>
                        </div>
                    </div>

                </div>
                <div class="right-content">
                    <div class="right-content-heading">
                        <div class="right-content-heading-left">
                            <h3>Details</h3>
                        </div>
                        <div class="right-content-heading-right">
                            <div class="social-icons">
                                <ul>
                                    <li><a class="facebook" href="#" target="_blank"></a></li>
                                    <li><a class="twitter" href="#" target="_blank"></a></li>
                                    <li><a class="googleplus" href="#" target="_blank"></a></li>
                                    <li><a class="pinterest" href="#" target="_blank"></a></li>
                                    <li><a class="dribbble" href="#" target="_blank"></a></li>
                                    <li><a class="vimeo" href="#" target="_blank"></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="inner-page">


                        <div class="clear"></div>
                        <div class="video-details">
                            <div class="col-md-12" id="watchAndDownlodDiv" runat="server">
                                <div class="col-md-6" id="watchDiv" runat="server">
                                    <asp:LinkButton runat="server" ID="watchNowHyperLink" OnClick="watchNowHyperLink_OnClick">
                                        <img src="/ftp/images/watch.jpg" class="pull-right"/>
                                    </asp:LinkButton>
                                    <%--<asp:HyperLink runat="server" ID="watchNowHyperLink">
                                        <img src="/ftp/images/watch.jpg" class="pull-right"/>
                                    </asp:HyperLink>--%>
                                </div>
                                <div class="col-md-6">
                                    <asp:HyperLink runat="server" ID="downloadNowHyperLink">
                                        <img src="/ftp/images/download.jpg"/>
                                    </asp:HyperLink>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="title">
                                    <h1 style="font-size: 30px; font-weight: bold; color: #808080">
                                        <asp:Label runat="server" ID="lblCollectionTitle"></asp:Label></h1>

                                </div>
                                <div class="video-details">
                                    <div class="col-md-12" style="padding-top: 15px;">
                                        <div class="col-md-4">
                                            <asp:Image runat="server" ID="CollectionImage" Height="350" Width="300" />
                                        </div>
                                    </div>
                                    <div class="col-md-12" style="padding-top: 30px;">
                                        <p>
                                            <asp:Label runat="server" ID="ContentDetailsLbl"></asp:Label>
                                        </p>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <div class="clear"></div>
        <!---End-content---->
        <!---start-copy-right---->
        <div class="copy-right">
           <p>All rights reserved to <a href="http://aamarnet.net/">Aamarnet System</a></p>
        </div>
    </form>
</body>
</html>
