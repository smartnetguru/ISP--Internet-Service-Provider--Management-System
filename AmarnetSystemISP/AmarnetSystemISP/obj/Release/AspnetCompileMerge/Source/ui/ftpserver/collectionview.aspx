﻿<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="collectionview.aspx.cs" Inherits="StartNetwork.ui.ftpserver.collectionview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="content-header">
        <h1>FTP Server Collection
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
                <i class="fa fa-th-list"></i>
                FTP Server Cololection View
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-4"></div>
                        <div class="col-md-4">
                            <asp:Image runat="server" ID="CollectionImage" Height="100" Width="100"/>
                        </div>
                        <div class="col-md-4"></div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-6">
                            <div class="col-md-6">
                                <b>FTP Parent Catagory</b>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="ftpParentCatagoryId"></asp:Label>
                            </div>
                        </div>
                         <div class="col-md-6">
                            <div class="col-md-6">
                                <b>FTP Child Catagory :</b>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="ftpChildCatagory"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-6">
                            <div class="col-md-6">
                                <b>Title :</b>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="titleTxtBx"></asp:Label>
                            </div>
                        </div>
                         <div class="col-md-6">
                            <div class="col-md-6">
                                <b>Description :</b>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="descriptionLabel"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-6">
                            <div class="col-md-6">
                                <b>Item FTP Full Link :</b>
                            </div>
                            <div class="col-md-6">
                                <asp:HyperLink runat="server" ID="ftpFullLink" Target="_blank"></asp:HyperLink>
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
