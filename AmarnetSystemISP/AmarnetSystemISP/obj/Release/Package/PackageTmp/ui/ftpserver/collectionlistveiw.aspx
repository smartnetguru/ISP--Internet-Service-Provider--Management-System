<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="collectionlistveiw.aspx.cs" Inherits="StartNetwork.ui.ftpserver.collectionlistveiw" %>

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
                FTP Server Cololection List
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>Parent Catagory :</label>
                                <asp:DropDownList runat="server" ID="parentCatagoryDrpDwnList" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="parentCatagoryDrpDwnList_OnSelectedIndexChanged">
                                    <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Movie" Value="Movie"></asp:ListItem>
                                    <asp:ListItem Text="Songs" Value="Songs"></asp:ListItem>
                                    <asp:ListItem Text="Natok" Value="Natok"></asp:ListItem>
                                    <asp:ListItem Text="Cartoon" Value="Cartoon"></asp:ListItem>
                                    <asp:ListItem Text="Software" Value="Software"></asp:ListItem>
                                    <asp:ListItem Text="Games" Value="Games"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>Child Catagory :</label>
                                <asp:DropDownList runat="server" CssClass="form-control" ID="ChildCatagoryDrpDwnList" Enabled="True" />
                            </div>
                        </div>
                        <div class="col-md-4" style="padding-top: 25px;">
                            <div class="form-group">
                                <label></label>
                                <asp:Button runat="server" ID="btnGetList" CssClass="btn btn-primary" Text="Get List" OnClick="btnGetList_OnClick" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:GridView runat="server" ID="CollectionListGridView" AutoGenerateColumns="False" CssClass="dataTable dataTables_scroll table table-bordered table-hover display">
                            <Columns>
                                <asp:TemplateField Visible="False">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="FTPcollectionId" Text='<%#Eval("FTPcollectionId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Image runat="server" ID="ftpCollectionImage" Height="40" Width="60" ImageUrl='<%# "~/FtpCollectionImage/"+Eval("FTPcollectionImageName") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="FTPcollectionTitle" HeaderText="Title" />
                                <asp:TemplateField HeaderText="FTP Path">
                                    <ItemTemplate>
                                        <asp:HyperLink runat="server" ID="ftpLink" NavigateUrl='<%#Eval("FTPcollectionFullLink") %>' Text='<%#Eval("FTPcollectionFullLink") %>' Target="_blank"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="btnView" CssClass="btn btn-info" ToolTip="View" OnClick="btnView_OnClick">
                                                    <i class="fa fa-eye"></i> View
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="btnEdit" CssClass="btn btn-primary" ToolTip="Edit" OnClick="btnEdit_OnClick">
                                                    <i class="fa fa-edit"></i> Edit
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="btnDelete" CssClass="btn btn-danger" ToolTip="Delete" OnClick="btnDelete_OnClick">
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
        function pageLoad() {
            $(document).ready(function () {

                $('.dataTable').dataTable({ "bState": true });
            });
        }
    </script>
</asp:Content>
