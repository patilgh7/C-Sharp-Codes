<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RealTimeExampleQueue.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <table style ="font-family:Arial; border:1px solid black; text-align:center">
          <tr>
             <td>
                 <b>Counter 1</b>
             </td>
              <td></td>
              <td>
                  <b>Counter 2</b> 
              </td>
              <td></td>
              <td> 
                  <b>Counter 3</b> 

              </td>
          </tr>
          <tr>
              <td>
                  <asp:TextBox ID="txtCounter1" runat="server" BackColor="#0000CC" Width="150px" ForeColor="White"></asp:TextBox>

              </td>
              <td></td>
              <td>
                  <asp:TextBox ID="txtCounter2" runat="server" BackColor="#0000CC" Width="150px" ForeColor="White"></asp:TextBox>

              </td>
              <td></td>
              <td>
                <asp:TextBox ID="txtCounter3" runat="server" BackColor="#0000CC" Width="150px" ForeColor="White"></asp:TextBox>

              </td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="150px" OnClick="btnCounter1_Click" />

              </td>
              <td></td>
              <td>
                  <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="150px" OnClick="btnCounter2_Click1" />

              </td>
              <td></td>
              <td>
                  <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="150px" OnClick="btnCounter3_Click" />

              </td>
          </tr>
          <tr>
              <td colspan ="5">
                  <asp:TextBox ID="txtDisplay" runat="server" Width="500px" BackColor="Lime"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td colspan="5">
                  <asp:ListBox Font-Size="Large" ID="listTokens" runat="server" Width="100px"></asp:ListBox>
              </td>
          </tr>
          <tr>
              <td colspan="5">
                  <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" OnClick="btnPrintToken_Click" />
              </td>
          </tr>
          <tr>
              <td colspan="5">
                  <asp:Label ID="lblStatus" runat="server" Font-Size="Large"></asp:Label>
              </td>
          </tr>

      </table>

    </form>
</body>
</html>
