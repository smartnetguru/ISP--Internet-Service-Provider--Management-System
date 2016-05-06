<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="StartNetwork.ui.profile.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="content-header">
        <h1>Profile
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
            <div class="panel-heading panel-heading-edited">
                <div class="bio-graph-heading">
                    <i class="fa fa-user"></i>
                    Profile
                   <div class="pull-right">
                       <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-default" OnClick="btnEdit_Click" style="float:left;margin-right:10px;">
                           <i class="fa fa-edit"></i>  Edit Profile
                       </asp:LinkButton>
                       <asp:LinkButton ID="btnChangePass" runat="server" CssClass="btn btn-default" style="float:left" OnClick="btnChangePass_Click">
                           <i class="fa fa-key"></i> Change Password
                       </asp:LinkButton>
                   </div>
                </div>
            </div>

            <div class="panel-body bio-graph-info">

                <div class="row">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="col-md-4">
                                </div>
                                <div class="col-md-4">
                                    <asp:Image ID="profileImage" runat="server" Height="200" Width="200" />
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
                                            <b>Name :</b>
                                            <asp:Label ID="nameLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Email :</b>
                                            <asp:Label ID="EmailLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>

                                <div class="col-md-6">

                                    <div class="bio-row">
                                        <p>
                                            <b>Gender :</b>
                                            <asp:Label ID="GenderLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Blood Group :</b>
                                            <asp:Label ID="BloodGroupLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Contact Number :</b>
                                            <asp:Label ID="ContactNumberLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Father's Name :</b>
                                            <asp:Label ID="FataherNameLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Mother's Name :</b>
                                            <asp:Label ID="MothernameLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Nationality :</b>
                                            <asp:Label ID="NationalityLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>National ID :</b>
                                            <asp:Label ID="nationalIDLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Permanent Address :</b>
                                            <asp:Label ID="permanentAddlabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Present Address :</b>
                                            <asp:Label ID="presentAddLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Role as a user :</b>
                                            <asp:Label ID="userRoleLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                
                                <div class="col-md-6">
                                    <div class="bio-row">
                                        <p>
                                            <b>Date Of Birth :</b>
                                            <asp:Label ID="DOBLabel" runat="server" CssClass="userDetailsLabel"></asp:Label>
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
