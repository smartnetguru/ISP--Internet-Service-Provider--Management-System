<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="collection.aspx.cs" Inherits="StartNetwork.ui.ftpserver.collection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <asp:UpdatePanel runat="server" ID="updatePanel1" ChildrenAsTriggers="False" UpdateMode="Conditional">
        <ContentTemplate>
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
                <i class="fa fa-cloud-download"></i>
                Manage FTP Servers Collection
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
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ChildCatagoryDrpDwnList" Enabled="True"/>
                                </div>
                            </div>
                        <div class="col-md-4">
                                <div class="form-group">
                                    <label>Title :</label>
                                    <asp:TextBox runat="server" ID="TileTxtBx" CssClass="form-control" required="required"></asp:TextBox>
                                </div>
                            </div>
                        
                        </div>
                    </div>
                 <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-4">
                                <div class="form-group">
                                    <label>Description :</label>
                                    <asp:TextBox runat="server" ID="descriptionTxtBx" CssClass="form-control" TextMode="MultiLine" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>FTP Link :</label>
                                    <asp:TextBox runat="server" ID="ftpIpTxtBx" CssClass="form-control" required="required"></asp:TextBox>
                                </div>
                            </div>
                        <div class="col-md-4">
                                <div class="form-group">
                                    <label>Image :</label>
                                    <asp:FileUpload ID="imageUpload" runat="server" />
                                </div>
                            </div>
                        
                        <div class="col-md-4">
                                <div class="form-group">
                                    <label></label>
                                </div>
                            </div>
                        </div>
                    </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label>FTP Movie Location :</label>
                                <asp:TextBox runat="server" ID="ftpMovieLocation" required="required" CssClass="form-control" placeholder="e.g : /rootfolder/subfolder/filename"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-3">
                            <asp:Button runat="server" ID="btnSave" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_OnClick"/>
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </section>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="parentCatagoryDrpDwnList" EventName="SelectedIndexChanged"/>
            <asp:PostBackTrigger ControlID="btnSave"/>
        </Triggers>
    </asp:UpdatePanel>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
