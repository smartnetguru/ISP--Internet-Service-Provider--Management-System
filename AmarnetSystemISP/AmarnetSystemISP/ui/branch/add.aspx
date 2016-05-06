<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="StartNetwork.ui.location.add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <section class="content-header">
        <h1>Branch
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
                <i class="fa fa-location-arrow"></i>
                Manage Branch
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>Branch Name :</label>
                                <asp:TextBox ID="BranchNameTxtBx" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>Branch Address :</label>
                                <asp:TextBox ID="branchAdd" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>Created Date :</label>
                                <asp:TextBox ID="branchCreatedDate" runat="server" CssClass="form-control form-control-inline input-medium default-date-picker" required="required"></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-4">
                            <div class="form-group">
                                
                                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-primary" style="margin-top:23px;" OnClick="btnAdd_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <asp:HiddenField ID="HiddenFieldForUpdate" runat="server" />
                <div class="row clearfix"></div>
                <div class="row">
                    <div class="col-md-12">
                         <asp:GridView ID="BranchListGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover dataTable display" OnRowDataBound="BranchListGridView_RowDataBound">
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="branchIdLabel" runat="server" Text='<%#Eval("branchId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="BranchName" HeaderText="Branch Name" />
                                <asp:BoundField DataField="BranchAdd" HeaderText="Branch Address" />
                                <asp:BoundField DataField="branchCreatedDate" HeaderText="Created Date" />
                                <asp:BoundField DataField="IsActive" HeaderText="Is Active" />
                                <asp:BoundField DataField="IsDeleted" HeaderText="Is Deleted" />
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
             $('.default-date-picker').datepicker({ autoclose: true, format: "dd/mm/yyyy" });
         });
    </script>
</asp:Content>
