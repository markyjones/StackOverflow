<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FormsAuthAndWebApi.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
        Testing Login - you have been redirected via forms auth

        </p>
        <p>
            Goto http://server/api/secured and you should get a 401 not a redirect
        </p>
    </div>
    </form>
</body>
</html>
