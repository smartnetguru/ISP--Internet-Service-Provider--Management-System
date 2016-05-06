<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="onlinetv.aspx.cs" Inherits="StartNetwork.page.onlinetv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headCContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="page-header">
                    <h1><i class="fa fa-desktop"></i> Online TV 
                    <small>All TV Channels</small></h1>
                </div>
            </div>
        </div>
          <div class="row">
            <div class="col-md-12">
                <div class="col-md-12">
                    <h3 style="color: red">Attention !!</h3>
                </div>
                <div class="col-md-12">
                    <p>
                        IPTV is NOT an alternative to your traditional Home Television! IT requires constant heavy bandwidth and High speed internet broadcast from channels.
We are NOT responsible for any interruption, buffering, freezing, kicks out and if not stable to normally watch.
                    </p>
                </div>
                </div>
              </div>

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

        <div class="row" style="padding-bottom: 30px;">
            <div class="col-md-12">
                <asp:Repeater ID="onlineTvserverRepert" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4" style="padding-bottom: 50px;">
                            <div class="ih-item square colored effect2">
                                <asp:HyperLink ID="TorrentHyperlink" runat="server" NavigateUrl='<%#Eval("onlineTvServerLink") %>' Target="_blank">
                                    <div class="img">
                                        <asp:Image ID="torrentImage" runat="server" ImageUrl='<%#"~/OnlineTVImage/"+Eval("onlineTvServerImage")  %>' />
                                    </div>
                                    <div class="info">
                                        <h3>
                                            <asp:Label ID="TorrentServerName" runat="server" Text='<%#Eval("onlineTvServerName") %>'></asp:Label></h3>

                                    </div>
                                </asp:HyperLink>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>


    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptContentPLaceHolder" runat="server">
</asp:Content>
