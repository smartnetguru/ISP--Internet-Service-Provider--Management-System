﻿<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="StartNetwork.ui.onlinetv.view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
     <section class="content-header">
        <h1>Online TV Server
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
                <i class="fa fa-eye"></i>
                      Online TV Server view of <small>[<asp:Label ID="OnlineTvId" runat="server"></asp:Label>]</small>
            <div class="pull-right">
                       <a href="add.aspx" style="color: white">
                           <i class="fa fa-arrow-left fa-2x"></i>
                       </a>
                   </div>
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="col-md-4">
                                </div>
                                <div class="col-md-4">
                                    <asp:Image ID="OnlineTvSerVerImage" runat="server" Height="200" Width="200" />
                                </div>
                                <div class="col-md-4">
                                </div>
                            </div>
                        </div>
                         <div class="row" style="padding-top: 30px;">
                            <div class="col-md-12">
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Online TV Server Name :</b>
                                            <asp:Label ID="OnlineTvServernameLbl" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Online TV Server Link :</b>
                                          <asp:HyperLink ID="onlineTvServerLinkLbl" runat="server" CssClass="userDetailsLabel" Target="_blank"></asp:HyperLink>
                                      
                                        </p>
                                    </div>
                                </div>
                                </div>
                             </div>
                      
                     </div>
                    </div>
                </div>
            </div>
        </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
