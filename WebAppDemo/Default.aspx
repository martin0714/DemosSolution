<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        var point = {
            x: 0,
            y: 0,
            moveTo: function () {
                this.x = this.x + x;
                this.y = this.y + y;
            }
        };
        point.moveTo(1, 1);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>我的应用程序测试</h1>
    </div>
    </form>
</body>
</html>
