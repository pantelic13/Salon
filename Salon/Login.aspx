<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Salon.Login" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/bootstrap.js"></script>

     <title></title>
     <style>
        .pozadina {
             background-image: url("lepo.jpg"); 
        }
    </style>

</head>
<body class ="pozadina">
    <div class="container shadow">
        <div class ="row">
            <div class="col-6 justify-content-center">
                 <h1 class="text-light">Ulogujte se</h1>
                    <form class="form-gropu" id="form1" runat="server">
        <div>
            <asp:Label class="text-light" ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" style="margin-left: 27px"></asp:TextBox>
            <br />
            <br />
            <asp:Label class="text-light" ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" TextMode="Password" style="margin-left: 29px"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1"  />
        </div>
         
    </form>

              </div>

         </div>


    </div>

</body>
</html>
