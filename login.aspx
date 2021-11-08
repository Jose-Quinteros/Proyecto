<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Balistica.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>AdminLTE 3 | Log in</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="fontawesome-free/all.min.css">
    <!-- icheck bootstrap -->
    <link rel="stylesheet" href="css/icheck-bootstrap.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="css/adminlte.min.css">
</head>
<body class="hold-transition login-page">
    <form id="form1" runat="server">
        <div class="login-box">
            <div class="login-logo">
                <img src="img/logo.gif" alt="Cientifica">
            </div>
            <!-- /.login-logo -->
            <div class="card">
                <div class="card-body login-card-body">
                    <h3 class="card title text-center">BALISTICA FORENSE</h3>
                    <br />

                    <form action="../../index3.html" method="post">
                        <div class="input-group mb-3">
                            <asp:TextBox runat="server" ID="tbUsuario" CssClass="form-control" placeholder="Ingrese nombre de usuario..." />



                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <span class="fas fa-envelope"></span>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">

                            <asp:TextBox runat="server" ID="tbPassword" TextMode="Password" CssClass="form-control" placeholder="Contraseña" />



                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <span class="fas fa-lock"></span>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-8">
                                <div class="icheck-primary">

                                    <asp:CheckBox ID="recuerdame" runat="server"/>

                                    <asp:Label runat="server" for="remember">
                          Remember Me
                                    </asp:Label>
                                </div>
                            </div>
                            <!-- /.col -->
                            <div class="col-4">

                                <asp:Button Text="Ingresar" ID="btnLogin" CssClass="btn btn-primary btn-block" runat="server" OnClick="btnLogin_Click" />


                            </div>
                            <!-- /.col -->
                        </div>
                    </form>

                    <asp:Label Text="" ID="lblError" ForeColor="Red" Font-Bold="true" runat="server" />


                    <p class="mb-1">
                        <a href="forgot-password.html">I forgot my password</a>
                    </p>
                    <p class="mb-0">
                        <a href="register.html" class="text-center">Register a new membership</a>
                    </p>
                </div>
                <!-- /.login-card-body -->
            </div>
        </div>
        <!-- /.login-box -->

        <!-- jQuery -->
        <script src="js/jquery.min.js"></script>
        <!-- Bootstrap 4 -->
        <script src="js/bootstrap.bundle.min.js"></script>
        <!-- AdminLTE App -->
        <script src="js/adminlte.min.js"></script>
    </form>
</body>
</html>
