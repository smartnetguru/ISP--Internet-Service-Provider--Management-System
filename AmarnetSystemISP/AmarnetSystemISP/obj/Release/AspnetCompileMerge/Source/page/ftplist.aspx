<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ftplist.aspx.cs" EnableEventValidation="true" Inherits="StartNetwork.page.ftplist" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aamarnet System | FTP Collection</title>
    <link href="/sitecontent/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/ftp/css/custom-css.css" rel="stylesheet" type="text/css" media="all" />
    <link href="/ftp/css/style.css" rel="stylesheet" type="text/css" media="all" />
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
                        <%--<ul>
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
                            <h3> Colletcions</h3>
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
                    <div class="content-grids">
                        <div class="inner-page">
                            <div class="clear"></div>
                            <div class="video-details">
                                <div class="row" runat="server" id="HeaderId" style="padding-bottom: 4px;">
                                    <div class="col-md-12">
                                        <div class="col-md-3">
                                            <h2 style="font-weight: bold">Image</h2>
                                        </div>
                                        <div class="col-md-4">
                                            <h2 style="font-weight: bold">Name 
                                            </h2>
                                        </div>
                                    </div>
                                </div>
                                <asp:Repeater runat="server" ID="contentListRepeter">
                                    <ItemTemplate>
                                        <div class="row" style="padding-bottom: 4px;">
                                            <div class="col-md-12">
                                                <asp:Label runat="server" ID="ftpCollectionId" Visible="False" Text='<%#Eval("FTPcollectionId") %>'></asp:Label>
                                                <div class="col-md-3">
                                                    <asp:Image runat="server" ID="collectionImage" ImageUrl='<%# "~/FtpCollectionImage/"+Eval("FTPcollectionImageName") %>' Height="130" Width="150" />
                                                </div>
                                                <div class="col-md-4">
                                                    <h3>
                                                        <asp:Label runat="server" ID="lblTitle" Text='<%#Eval("FTPcollectionTitle") %>'></asp:Label></h3>
                                                </div>
                                                <div class="col-md-5">
                                                    <div class="col-md-12">
                                                        <div class="col-md-4">
                                                            <%--<asp:LinkButton runat="server" ID="btnWatchNow" CssClass="btn btn-primary" Text="Watch"></asp:LinkButton>--%>
                                                        </div>
                                                        <div class="col-md-4">
                                                            <asp:LinkButton runat="server" ID="btnDetails" CssClass="btn btn-info pull-right" Text="Details" OnClick="btnDetails_OnClick"></asp:LinkButton>
                                                        </div>

                                                        <div class="col-md-4">
                                                            <asp:HyperLink runat="server" ID="btnDwnLoad" CssClass="btn btn-success" NavigateUrl='<%#Eval("FTPcollectionFullLink") %>' Text="Download"></asp:HyperLink>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <asp:HiddenField ID="startPointHiddenfield" runat="server" />
                                <asp:HiddenField ID="endPointHiddenField" runat="server" />
                                <asp:HiddenField ID="hiddenFieldForOnStandingPage" runat="server" />
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="col-md-4">
                                        <asp:Button ID="previouButton" runat="server" Text="Previous" CssClass="btn btn-primary pull-right" OnClick="previouButton_Click"/>
                                    </div>
                                    <div class="col-md-5 custom-col-md-5">
                                        <asp:Repeater ID="pageRptr" runat="server">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnPageNumber" runat="server" CssClass="btn btn-primary" Text='<%#Container.DataItem.ToString() %>' OnClick="btnPageNumber_Click"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <div class="col-md-3">
                                        <asp:Button ID="nextButton" runat="server" Text="Next" CssClass="btn btn-primary" OnClick="nextButton_Click" />
                                    </div>
                                </div>
                            </div>

                            </div>
                        </div>

                        <div class="clear"></div>
                        <!---start-pagenation----->

                        <div class="clear"></div>
                        <!---End-pagenation----->
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
