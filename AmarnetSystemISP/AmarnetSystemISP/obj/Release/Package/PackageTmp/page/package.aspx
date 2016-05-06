<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="package.aspx.cs" Inherits="StartNetwork.page.package" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headCContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <hr />
    <div class="container">
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
        <div class="row" style="padding-bottom:50px;">
            <div class="col-md-12">
                <div class="page-header">
                    <h1><i class="fa fa-info-circle"></i>Packeges
                    <small>Our Package Services</small></h1>
                </div>
            </div>
            <div class="col-md-12">
                <div class="col-md-4">
                    <label>
                        Select Your Area for Check Packge Information :
                    </label>
                </div>
                <div class="col-md-8">
                     <asp:DropDownList ID="branchWisePackage" runat="server" CssClass="form-control" required="required" AutoPostBack="true" OnSelectedIndexChanged="branchWisePackage_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row" style="padding-bottom: 50px;">
            <div class="col-md-12">
                <asp:Repeater ID="packageReperter" runat="server">
                    <ItemTemplate>
                        <div class="col-md-3" style="padding-bottom:40px;">
                            <div class="col-md-12 package_Name_Header">
                                <h5>
                                    <asp:Label ID="packageNameLbl" runat="server" Text='<%#Eval("PackageName") %>'></asp:Label></h5>
                            </div>
                            <div class="col-md-12 free_header_bar"></div>
                            <div class="col-md-12 package_PriceHeader">
                                <div class="col-md-12">
                                    <h4>
                                        <asp:Label ID="packagePriceMoney" runat="server" Text='<%#Eval("packagePrice") +" "+"৳" %>'></asp:Label></h4>
                                </div>
                                <div class="col-md-12">
                                    <p style="font-size: 12px; color: #a3a3a3;">permonth </p>
                                </div>
                            </div>
                           <%-- <div class="col-md-12 package_row_style">
                                <div class="col-md-6">
                                    <p>Min Speed : </p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="packageMinSpeed" runat="server" Text='<%#Eval("packageMinSpd") %>'></asp:Label></b> Mbps </p>
                                </div>


                            </div>--%>
                            <%--<div class="col-md-12 package_row_style set_package_background_color">
                                <div class="col-md-6">
                                    <p>Max Speed : </p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="packageMaxSpeed" runat="server" Text='<%#Eval("packageMaxSpd") %>'></asp:Label></b> Mbps </p>
                                </div>


                            </div>--%>
                            <div class="col-md-12 package_row_style">
                                <div class="col-md-6">
                                    <p>
                                        Youtube Speed :
                                    </p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="packageYoutubeSpeed" runat="server" Text='<%#Eval("youtubeSpeed") %>'></asp:Label>
                                        </b> Mbps</p>
                                </div>

                            </div>
                            <div class="col-md-12 package_row_style set_package_background_color">
                                <div class="col-md-6">
                                    <p>Star Network FTP :</p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="starnetFtpSpd" runat="server" Text='<%#Eval("starNetworkFtpSpd") %>'></asp:Label>
                                        </b> Mbps</p>
                                </div>

                            </div>
                            <%--<div class="col-md-12 package_row_style">
                                <div class="col-md-6">
                                    <p>Other FTP :</p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="otherFtp" runat="server" Text='<%#Eval("otherFtpSpd") %>'></asp:Label></b> Mbps</p>
                                </div>

                            </div>--%>
                            <div class="col-md-12 package_row_style set_package_background_color">
                                <div class="col-md-6">
                                    <p>BDIX Speed :</p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="bdixSpd" runat="server" Text='<%#Eval("bdixSpd") %>'></asp:Label></b> Mbps</p>
                                </div>

                            </div>
                            <div class="col-md-12 package_row_style">
                                <div class="col-md-6">
                                    <p>Real IP :</p>
                                </div>
                                <div class="col-md-6">
                                    <p><b>
                                        <asp:Label ID="realIp" runat="server" Text='<%#Eval("RealIp") %>'></asp:Label></b></p>
                                </div>

                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptContentPLaceHolder" runat="server">
</asp:Content>
