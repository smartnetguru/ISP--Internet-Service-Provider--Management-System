<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="StartNetwork.ui.package.edit" %>
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
                <i class="fa fa-edit"></i>
                     Update Package
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Package Name :</label>
                                <asp:TextBox ID="packageNameTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                         <div class="col-md-3">
                            <div class="form-group">
                                <label>Package Price :</label>
                                <asp:TextBox ID="packagePriceMoney" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                         <%--<div class="col-md-3">
                            <div class="form-group">
                                <label>Package Minimum Speed :</label>
                                <asp:TextBox ID="packageMinimumSpeed" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>--%>
                         <div class="col-md-3">
                            <div class="form-group">
                                <label>Package Speed :</label>
                                <asp:TextBox ID="packageMaxSpd" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Youtube Speed :</label>
                                <asp:TextBox ID="youtubeSpeedTxtxBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <asp:HiddenField ID="hiddenVieldForPackageId" runat="server" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        
                         <div class="col-md-3">
                            <div class="form-group">
                                <label>Star FTP Speed :</label>
                                <asp:TextBox ID="starNetWorkFtpTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                       <%--  <div class="col-md-3">
                            <div class="form-group">
                                <label>Other FTP :</label>
                                <asp:TextBox ID="otherFtptxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>--%>
                         <div class="col-md-3">
                            <div class="form-group">
                                <label>BDIX Speed :</label>
                                <asp:TextBox ID="bdixSpeedTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <label>Real IP :</label>
                            <asp:DropDownList ID="realIpdrpDwnList" runat="server" CssClass="form-control" required="required">
                                <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                <asp:ListItem Text="No" Value="No"></asp:ListItem>
                                <asp:ListItem Text="Required" Value="Required"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Branch :</label>
                                <asp:DropDownList ID="branchWisePackage" runat="server" CssClass="form-control" required="required"></asp:DropDownList>
                            </div>
                            
                        </div>
                    </div>
                </div>
                <div class="row clearfix">

                </div>
                <div class="row">
                    <div class="col-md-12">
                        
                    </div>
                </div>
                <div class="row" style="padding-top:20px;">
                    <div class="col-md-12">
                        <div class="col-md-3">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update Package" CssClass="btn btn-primary" OnClick="btnUpdate_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
