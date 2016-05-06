<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ftpwatch.aspx.cs" Inherits="StartNetwork.page.ftpwatch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aamarnet System | FTP Collection</title>
    <link href="/sitecontent/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/ftp/css/video-js.css" rel="stylesheet" />
    <script src="/ftp/css/video.js"></script>
    <script src="/content/plugins/jQuery/jQuery-2.1.4.min.js"></script>
    <link href="/ftp/css/style.css" rel="stylesheet" type="text/css" media="all" />


    <%-- <script src="/ftp/jwplayer.js"></script>--%>
    <script>

        videojs.options.flash.swf = "/ftp/video-js.swf";
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scriptMnaager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="updatePanel1" ChildrenAsTriggers="false" UpdateMode="Conditional" runat="server">
            <ContentTemplate>

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
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                        <!---End-top-menu-search---->
                    </div>
                    <!---End-header---->
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

                            </div>
                        </div>
                        <div class="right-content">
                            <div class="right-content-heading">
                                <div class="right-content-heading-left">
                                    <h3></h3>
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
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div id="msgBox" runat="server">
                                                <div class="">
                                                    <button type="button" class="close close-sm" data-dismiss="alert">
                                                        <i class="fa fa-times"></i>
                                                    </button>
                                                    <h4>
                                                        <i class="fa fa-ok-sign"></i>
                                                        <asp:Label ID="msgBoxTitle" runat="server" Text=""></asp:Label>
                                                    </h4>
                                                    <p>
                                                        <asp:Label ID="msgBoxDetails" runat="server" Text=""></asp:Label>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row" style="padding-bottom:30px;">
                                        <div class="col-md-12">
                                            <div class="col-md-12">
                                                <h2 style="color: red"><b>Attention !!</b></h2>
                                            </div>
                                            <div class="col-md-12">
                                                <p>
                                                  <b> If Video is not Playing please Try Sometimes Later or download and Enjoy Your Video.</b>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="video-details">

                                        <video id="loadVideoSource" runat="server" class="video-js vjs-default-skin vjs-tech" controls="controls" preload="auto" width="640" height="500" data-setup="{}" type="video/mp4" />
                                        <%-- <source id="loadVideoSource" runat="server" type="video/mp4" />--%>
                                        <%-- <video id="LoadVideo" runat="server" class="video-js vjs-default-skin" controls="controls" preload="auto" width="640" height="500" data-setup="{}">
                                    <source id="loadVideoSource" runat="server" type="video/mp4"/>
                                </video>--%>
                                        <%--<asp:HiddenField ID="hiddenField" runat="server" />--%>
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
                <script src="/ftp/css/video.js"></script>

            </ContentTemplate>
        </asp:UpdatePanel>
        <%--<script type="text/javascript">
             var MainUrl = document.getElementById('<%=hiddenField.ClientID %>').value;
             jwplayer('mediaPlayer').setup({
                 flashplayer: "/ftp/player.swf",
                 file: MainUrl,
            height: "270",
            width: "380"
        })
    </script>--%>
        <%--<script>
           var MainUrl = document.getElementById('<%=hiddenField.ClientID %>').value;
           $('#loadVideoSource > source').attr("src", MainUrl);
       </script>--%>
    </form>

</body>
</html>
