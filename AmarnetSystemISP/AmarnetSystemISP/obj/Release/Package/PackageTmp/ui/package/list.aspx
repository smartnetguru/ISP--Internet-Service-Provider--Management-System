<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="StartNetwork.ui.package.list" %>

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
                <i class="fa fa-th-list"></i>
                Package List
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <asp:GridView ID="packageListGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover dataTable display" OnRowDataBound="packageListGridView_RowDataBound">
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="packageId" runat="server" Text='<%#Eval("PackageId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="PackageName" HeaderText="Package Name" />
                                <asp:BoundField DataField="packagePrice" HeaderText="Package Price (Taka)" />
                                <asp:BoundField DataField="packageMinSpd" HeaderText="Package Minimum Speed (MB/Ps)" Visible="false" />
                                <asp:BoundField DataField="packageMaxSpd" HeaderText="Package Maximum Speed (MB/Ps)" Visible="false" />
                                <asp:BoundField DataField="youtubeSpeed" HeaderText="Youtube Speed (MB/Ps)" Visible="false" />
                                <asp:BoundField DataField="starNetworkFtpSpd" HeaderText="Star Network FTP (MB/Ps)" Visible="false" />
                                <asp:BoundField DataField="otherFtpSpd" HeaderText="Other FTP (MB/Ps)" Visible="false" />
                                <asp:BoundField DataField="bdixSpd" HeaderText="BDIX Speed (MB/Ps)" Visible="false" />
                                <asp:BoundField DataField="RealIp" HeaderText="Real IP" />
                                <asp:BoundField DataField="IsActive" HeaderText="Is Active" />
                                <asp:BoundField DataField="IsDeleted" HeaderText="Is Deleted" />
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
             $('.dataTable').dataTable();
         });
    </script>
</asp:Content>
