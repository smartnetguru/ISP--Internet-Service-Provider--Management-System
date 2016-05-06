<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="StartNetwork.ui.package.view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="content-header">
        <h1>Package
            <small></small>
        </h1>

    </section>
    <section class="content">
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

        <div class="panel panel-primary">
            <div class="panel-heading">
                <i class="fa fa-info-circle"></i>
                View Package of <small>[<asp:Label ID="packageIdLabel" runat="server"></asp:Label>]</small>
                 <div class="pull-right">
                       <a href="view.aspx" style="color: white">
                           <i class="fa fa-arrow-left fa-2x"></i>
                       </a>
                   </div>
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-6">
                            <p>
                                <b>Package Name :</b>
                                <asp:Label ID="PackagenameLabel" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label>
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p>
                                <b>Package Price :</b>
                                <asp:Label ID="packagePriceLabel" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> ৳ 
                            </p>
                        </div>
                       <%-- <div class="col-md-6">
                            <p>
                                <b>Package Minimum Speed :</b>
                                <asp:Label ID="packageMinSpdlbl" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> Mbps
                            </p>
                        </div>--%>
                        <div class="col-md-6">
                            <p>
                                <b>Package Speed :</b>
                                <asp:Label ID="packageMaxSpeedlbl" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> Mbps
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p>
                                <b>Youtube Speed :</b>
                                <asp:Label ID="youtubeSpd" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> Mbps
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p>
                                <b>Star FTP Speed :</b>
                                <asp:Label ID="starNetworkSpdLbl" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> Mbps
                            </p>
                        </div>
                      <%--  <div class="col-md-6">
                            <p>
                                <b>Other FTP Speed :</b>
                                <asp:Label ID="otherFtpSpdlbl" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> Mbps
                            </p>
                        </div>--%>
                        <div class="col-md-6">
                            <p>
                                <b>BDIX Speed :</b>
                                <asp:Label ID="bdixSpdLbl" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> Mbps
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p>
                                <b>Real IP :</b>
                                <asp:Label ID="realIpLabel" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label>
                            </p>
                        </div>
                        <div class="col-md-6">
                            <p>
                                <b>Branch Name :</b>
                                <asp:Label ID="branchName" runat="server" CssClass="userDetailsLabel" style="text-align:center"></asp:Label> 
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
