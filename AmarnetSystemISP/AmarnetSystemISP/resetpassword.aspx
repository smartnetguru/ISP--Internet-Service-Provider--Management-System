<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resetpassword.aspx.cs" Inherits="StartNetwork.resetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="UTF-8" />
    <title>Star Network | Reset Password</title>
    <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport' />
    <!-- Bootstrap 3.3.4 -->
    <link href="/sitecontent/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Font Awesome Icons -->
    <link href="/sitecontent/css/font-awesome-4.3.0/css/font-awesome.css" rel="stylesheet" type="text/css" />
    <!-- Theme style -->
    <link href="/content/dist/css/AdminLTE.min.css" rel="stylesheet" type="text/css" />
    <!-- iCheck -->
    <link href="/content/plugins/iCheck/square/blue.css" rel="stylesheet" type="text/css" />
</head>
<body class="login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="/index.aspx"><b>Star</b>Network</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Reset Password Here</p>
            <form id="form1" runat="server">
                <div class="form-group has-feedback">
                    <asp:TextBox ID="NewPassTxtBx" runat="server" class="form-control" placeholder="Enter New Password" TextMode="Password" ></asp:TextBox>

                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="ReTypePasswordTxtBX" runat="server" class="form-control" TextMode="Password" placeholder="Re-Type New Password"></asp:TextBox>

                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                       
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <asp:Button ID="resetPassBtn" runat="server" Text="Reset Password" class="btn btn-primary btn-block btn-flat" OnClick="resetPassBtn_Click" />

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
