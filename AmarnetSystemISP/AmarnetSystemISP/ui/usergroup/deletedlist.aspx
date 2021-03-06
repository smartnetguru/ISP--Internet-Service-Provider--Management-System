﻿<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="deletedlist.aspx.cs" Inherits="VersityFinalProject.settings.usergroup.deletedlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
     <section class="content-header">
                <h1>Deletd List Of User Group
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
             User Group List
        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-12">
                    <asp:GridView ID="userGroupDeletedListGridView" AutoGenerateColumns="false" runat="server" CssClass="table table-bordered table-hover dataTable display" OnRowDataBound="userGroupListGridView_RowDataBound">
                        <Columns>
                            <asp:TemplateField Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="userGroupIdLabel" runat="server" Text='<%#Eval("UserGroupId") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="UserGroupName" HeaderText="Group Name" />
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="IsActive" HeaderText="Is Active" />
                            <asp:BoundField DataField="IsDeleted" HeaderText="Is Deleted" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
                </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $('.dataTable').dataTable();
        });
    </script>
</asp:Content>
