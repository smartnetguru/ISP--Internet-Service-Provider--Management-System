<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="sliderimage.aspx.cs" Inherits="StartNetwork.ui.webessential.sliderimage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="content-header">
        <h1>Web Essential
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
                Manage Web Slider
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-4">
                            <label>Slider Title :</label>
                            <asp:TextBox ID="sliderMainTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <label>Slider Message Text : </label>
                            <asp:TextBox ID="sliderMsgTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <label>Slider Image :</label>
                           <asp:FileUpload ID="sliderImage" runat="server" />
                        </div>
                        
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-4" id="checkPoint" runat="server">
                           <asp:CheckBoxList ID="ImageIsActive" runat="server" CssClass="checkbox-inline" style="margin-top:30px;">
                               <asp:ListItem Text="Is Active" Value="active"></asp:ListItem>
                           </asp:CheckBoxList>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-4">
                            <asp:Button ID="btnAddImage" runat="server" Text="Add Slider Image" CssClass="btn btn-primary" style="margin-top:30px;" OnClick="btnAddImage_Click" />
                        </div>
                    </div>
                </div>
                <asp:HiddenField ID="HiddenFieldforUpdateSliderImageId" runat="server" />
                <div class="row" style="padding-top:50px;">
                    <div class="col-md-12">
                         <asp:GridView ID="SliderImageListGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover dataTable display" OnRowDataBound="SliderImageListGridView_RowDataBound">
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="sliderImageSerialLbl" runat="server" Text='<%#Eval("ImageId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="SliderTitle" HeaderText=" Title" />
                                <asp:BoundField DataField="SliderMsg" HeaderText="Slider Image Message" />

                                <asp:BoundField DataField="sliderActiveImage" HeaderText="Active Image" />
                                <%--<asp:BoundField DataField="onlineTvServerLink" HeaderText="Online TV Link" />--%>
                                <asp:TemplateField HeaderText="Image">
                                    <ItemTemplate>
                                        <asp:Image ID="imageLabel" runat="server" ImageUrl='<%#"~/SliderImgae/"+Eval("ImageName") %>' Height="60" Width="60" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <%--<asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="ViewLinkBtn" runat="server" CssClass="btn btn-info" ToolTip="View" OnClick="ViewLinkBtn_Click">
                                            <i class="fa fa-file"></i> View
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="EditLinkBtn" runat="server" CssClass="btn btn-primary" ToolTip="Edit" OnClick="EditLinkBtn_Click">
                                            <i class="fa fa-edit"></i> Edit
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <%--<asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="ActivateLinkBtn" runat="server" CssClass="btn btn-success" ToolTip="Activate" OnClick="ActivateLinkBtn_Click">
                                            <i class="fa fa-check"></i> Activate
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                                 <%--<asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="DeactivateLinkBtn" runat="server" CssClass="btn btn-warning" ToolTip="Deactivate" OnClick="DeactivateLinkBtn_Click">
                                            <i class="fa fa-close"></i> Deactivate
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
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
             $('.dataTable').dataTable(
                 {
                     stateSave: true

                 });
         });
    </script>
</asp:Content>
