﻿<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="StartNetwork.ui.torrent.add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
<%--    <asp:UpdatePanel ID="updatePanel" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
        <ContentTemplate>--%>
              <section class="content-header">
        <h1>Torrent Server
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
                <i class="fa fa-cloud-download"></i>
                     Manage Torrent Server
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Torrent Server Name :</label>
                                <asp:TextBox ID="torrentServerNameTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                         <div class="col-md-3">
                            <div class="form-group">
                                <label>Torrent Server Link :</label>
                                <asp:TextBox ID="torrentServerLink" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                         <div class="col-md-3">
                            <div class="form-group">
                                <label> Image :</label>
                                <asp:FileUpload ID="imageUpload" runat="server" />
                            </div>
                        </div>
                        <asp:HiddenField ID="hiddenfieldForTorrentServerId" runat="server" />
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-2">
                        <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-primary col-md-12" OnClick="btnAdd_Click" />
                    </div>
                        </div>
                </div>

                <div class="row" style="padding-top:50px;">
                    <div class="col-md-12">

                        <asp:GridView ID="torrentServerList" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover dataTable display" OnRowDataBound="torrentServerList_RowDataBound">
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="torrentServerIdLabel" runat="server" Text='<%#Eval("TorrentServerId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="TorrentServerName" HeaderText=" Name" />
                                <asp:TemplateField HeaderText="Torrent Server Link">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="TorrentServerLink" runat="server" NavigateUrl='<%#Eval("TorrentServerLink") %>' Text='<%#Eval("TorrentServerLink") %>' Target="_blank"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:BoundField DataField="IsActive" HeaderText="Is Active" />
                                <asp:BoundField DataField="IsDeleted" HeaderText="Is Deleted" />
                                <asp:TemplateField HeaderText="Image">
                                    <ItemTemplate>
                                        <asp:Image ID="imageLabel" runat="server" ImageUrl='<%#"~/TorrentImage/"+Eval("TorrentServerImage") %>' Height="60" Width="60" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="ViewLinkBtn" runat="server" CssClass="btn btn-info" ToolTip="View" OnClick="ViewLinkBtn_Click">
                                            <i class="fa fa-file"></i> View
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="EditLinkBtn" runat="server" CssClass="btn btn-primary" ToolTip="Edit" OnClick="EditLinkBtn_Click">
                                            <i class="fa fa-edit"></i> Edit
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="ActivateLinkBtn" runat="server" CssClass="btn btn-success" ToolTip="Activate" OnClick="ActivateLinkBtn_Click">
                                            <i class="fa fa-check"></i> Activate
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="DeactivateLinkBtn" runat="server" CssClass="btn btn-warning" ToolTip="Deactivate" OnClick="DeactivateLinkBtn_Click">
                                            <i class="fa fa-close"></i> Deactivate
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="DeleteLinkBtn" runat="server" CssClass="btn btn-danger" OnClick="DeleteLinkBtn_Click">
                                            <i class="fa fa-trash"></i> Delete
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                </div>
            </div>
        </section>
<%--        </ContentTemplate>
        <Triggers>--%>
           <%-- <asp:PostBackTrigger ControlID="btnAdd" />--%>
<%--        </Triggers>
    </asp:UpdatePanel>--%>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
             $('.dataTable').dataTable(
                 {
                     stateSave: true
                    
                 });
         });
    </script>
</asp:Content>
