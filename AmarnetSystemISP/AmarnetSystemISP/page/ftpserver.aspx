<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ftpserver.aspx.cs" Inherits="StartNetwork.page.ftpserver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headCContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="page-header">
                    <h1><i class="fa fa-server"></i> FTP Server
                    <small> All FTP Servers</small></h1>
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
         <div class="row">
            <div class="col-md-12">
                <asp:Repeater ID="ftpServerRepeter" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4" style="padding-bottom: 50px;">
                            <div class="ih-item square colored effect2">
                                <asp:HyperLink ID="TorrentHyperlink" runat="server" NavigateUrl='<%#Eval("FtpserverLink") %>' Target="_blank">
                                    <div class="img">
                                        <asp:Image ID="torrentImage" runat="server" ImageUrl='<%#"~/FtpServerImage/"+Eval("FtpServerImage")  %>' />
                                    </div>
                                    <div class="info">
                                        <h3>
                                            <asp:Label ID="TorrentServerName" runat="server" Text='<%#Eval("FtpServerName") %>'></asp:Label></h3>

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
