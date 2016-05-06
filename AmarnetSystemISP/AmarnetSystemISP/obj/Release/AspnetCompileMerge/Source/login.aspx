<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StartNetwork.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Aamarnet System| Log in</title>
    <link rel="icon" href="/sitecontent/img/snlogoIcon.png" type="image/png"/>
    <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport' />
    <!-- Bootstrap 3.3.4 -->
    <link href="/sitecontent/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Font Awesome Icons -->
    <link href="/sitecontent/css/font-awesome-4.3.0/css/font-awesome.css" rel="stylesheet" type="text/css" />
    <!-- Theme style -->
    <link href="/content/dist/css/AdminLTE.min.css" rel="stylesheet" type="text/css" />
    <!-- iCheck -->
    <link href="/content/plugins/iCheck/square/blue.css" rel="stylesheet" type="text/css" />
    <link href="/content/css/appstyle.css" rel="stylesheet" />
</head>
<body class="login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="/index.aspx"><b>Aamarnet</b>System</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Sign in Here</p>
            <form id="form1" runat="server">
                <div class="form-group has-feedback">
                    <asp:TextBox ID="userIdTxtBx" runat="server" class="form-control" placeholder="Email" ValidationGroup="login"></asp:TextBox>

                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="passwordTxtBX" runat="server" class="form-control" TextMode="Password" placeholder="Password" ValidationGroup="login"></asp:TextBox>

                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck" style="margin-left: 20px;">
                            <label>
                                <asp:CheckBox ID="rememberMeChkBox" runat="server" />
                                Remember Me
                            </label>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <asp:Button ID="loginBtn" runat="server" Text="Sign In" class="btn btn-primary btn-block btn-flat" OnClick="loginBtn_Click" ValidationGroup="login" />

                    </div>
                    <!-- /.col -->
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <label>
                            <asp:Label ID="logInErrorMsg" runat="server" ForeColor="Red"></asp:Label>
                        </label>
                    </div>
                </div>
                <a href="#forgotPassModal" role="button" data-toggle="modal" id="forgotPass">I Forgot My Password</a>
                <%--<a id="forgotPass" data-toggole="modal" role="button">I forgot my password</a>--%><br />

                <div class="modal fade" id="forgotPassModal" tabindex="-1" role="dialog" data-width="760" style="display: none;" aria-hidden="true">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button aria-label="Close" data-dismiss="modal" class="close" type="button"><span aria-hidden="true">×</span></button>
                                <h4 class="modal-title">Forgot Password ??</h4>
                            </div>
                            <div class="modal-body">

                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="col-md-12">
                                            <asp:TextBox ID="forgorPassEmailTxtBx" runat="server" CssClass="form-control" ValidationGroup="resetPass" placeholder="Enter Your Email Address"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                               
                            </div>
                            <div class="modal-footer">
                                <button data-dismiss="modal" class="btn btn-default pull-left" type="button">Close</button>
                                <asp:Button ID="forGotPassBtn" runat="server" Text="Reset Password" CssClass="btn btn-primary" OnClick="forGotPassBtn_Click" ValidationGroup="resetPass" />

                            </div>
                        </div>
                        <!-- /.modal-content -->
                    </div>
                    <!-- /.modal-dialog -->
                </div>

            </form>




        </div>
        <!-- /.login-box-body -->
    </div>
    <!-- /.login-box -->

    <!-- jQuery 2.1.4 -->
    <script src="/content/plugins/jQuery/jQuery-2.1.4.min.js"></script>
    <!-- Bootstrap 3.3.2 JS -->
    <script src="/content/css/bootstrap/js/bootstrap.min.js"></script>
    <!-- iCheck -->
</body>
</html>
