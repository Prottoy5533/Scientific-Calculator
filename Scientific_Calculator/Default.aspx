<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Scientific_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <Style>
        body {
            background-color: grey;
        }
         .ButtonStyle {
             width: 53px;
             height: 28px;
             margin: 04px;
             background-color: blanchedalmond;
         }
         .st {
             text-align: center;
             margin-left: auto;
             
         }
       
    </Style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
              <h1 class="text-center display-4 mb-3 mt-2" > Calculator</h1>
              
            
        </div>
        <section id="xy">
            <div>
            <div class="st">
                <asp:TextBox ID="txtInput"  ReadOnly="True" runat="server" Height="50px" Width="250px"  OnTextChanged="txtInput_TextChanged" BackColor="White" BorderStyle="Solid" BorderWidth="5px" ForeColor="Black" MaxLength="25">0</asp:TextBox>
            </div>
            <div class="st">
                <asp:Button ID="btnPi" CssClass="ButtonStyle" runat="server" Text="π" OnClick="btnPi_Click" />
                <asp:Button ID="btnLog" CssClass="ButtonStyle" runat="server" Text="Log" OnClick="btnLog_Click" />
                <asp:Button ID="btnSqrt" CssClass="ButtonStyle" runat="server" Text="√" OnClick="btnSqrt_Click" />
                <asp:Button ID="btnSquare" CssClass="ButtonStyle" runat="server" Text="x²" OnClick="btnSquare_Click" />
            </div>
            <div class="st">
                <asp:Button ID="btnSinh" CssClass="ButtonStyle" runat="server" Text="Sinh" OnClick="btnSinh_Click" />
                <asp:Button ID="btnSin" CssClass="ButtonStyle" runat="server" Text="Sin" OnClick="btnSin_Click" />
                <asp:Button ID="btnCube" CssClass="ButtonStyle" runat="server" Text="∛" OnClick="btnCube_Click"  />
               
                <asp:Button ID="btnQuebe" CssClass="ButtonStyle" runat="server" Text="x³" OnClick="btnQuebe_Click" />
            </div>
            <div class="st">
                <asp:Button ID="btnCosh" CssClass="ButtonStyle" runat="server" Text="Cosh" OnClick="btnCosh_Click" />
                <asp:Button ID="btnCos" CssClass="ButtonStyle" runat="server" Text="Cos" OnClick="btnCos_Click" />
                <asp:Button ID="btnBin" CssClass="ButtonStyle" runat="server" Text="Bin" OnClick="btnBin_Click" />
                <asp:Button ID="btnOnebyX" CssClass="ButtonStyle" runat="server" Text="1/x" OnClick="btnOnebyX_Click" />
            </div>
            <div class="st">
                 <asp:Button ID="btnTanh" CssClass="ButtonStyle" runat="server" Text="Tanh" OnClick="btnTanh_Click" />
                <asp:Button ID="btnTan" CssClass="ButtonStyle" runat="server" Text="Tan" OnClick="btnTan_Click" />
                <asp:Button ID="btnHex" CssClass="ButtonStyle" runat="server" Text="Hex" OnClick="btnHex_Click" />
                <asp:Button ID="btnInx" CssClass="ButtonStyle" runat="server" Text="In x" OnClick="btnInx_Click" />
            </div>
            <div class="st">
                <asp:Button ID="btnExp" CssClass="ButtonStyle" runat="server" Text="Exp" OnClick="Arithmetic_Operate" />
                <asp:Button ID="btnMod" CssClass="ButtonStyle" runat="server" Text="Mod" OnClick="Arithmetic_Operate" />
                <asp:Button ID="btnOct" CssClass="ButtonStyle" runat="server" Text="Oct" OnClick="btnOct_Click" />
                <asp:Button ID="btnPercentage" CssClass="ButtonStyle" runat="server" Text="%" OnClick="btnPercentage_Click" />
            </div>
            <div class="st">
                <asp:Button ID="btnX" CssClass="ButtonStyle" runat="server" Text="X" OnClick="btnX_Click"  />
                <asp:Button ID="btnCE" CssClass="ButtonStyle" runat="server" Text="CE" OnClick="btnCE_Click"  />
                 <asp:Button ID="btnDec" CssClass="ButtonStyle" runat="server" Text="Dec" OnClick="btnDec_Click" />
                <asp:Button ID="btnPlusMinus" CssClass="ButtonStyle" runat="server" Text="+-" OnClick="Arithmetic_Operate" />
                
            </div>
            <div class="st">
                <asp:Button ID="btn7" CssClass="ButtonStyle" runat="server" Text="7" OnClick="button_click" />
                <asp:Button ID="btn8" CssClass="ButtonStyle" runat="server" Text="8" OnClick="button_click" />
                <asp:Button ID="btn9" CssClass="ButtonStyle" runat="server" Text="9" OnClick="button_click" />
                <asp:Button ID="btnAdd" CssClass="ButtonStyle" runat="server" Text="+" OnClick="Arithmetic_Operate" />
                
            </div>
            <div class="st">
                <asp:Button ID="btn4" CssClass="ButtonStyle" runat="server" Text="4" OnClick="button_click" />
                <asp:Button ID="btn5" CssClass="ButtonStyle" runat="server" Text="5" OnClick="button_click" />
                <asp:Button ID="btn6" CssClass="ButtonStyle" runat="server" Text="6" OnClick="button_click" />
                <asp:Button ID="btnSub" CssClass="ButtonStyle" runat="server" Text="-" OnClick="Arithmetic_Operate" />
                
            </div>
            <div class="st">
                <asp:Button ID="btn1" CssClass="ButtonStyle" runat="server" Text="1" OnClick="button_click" />
                <asp:Button ID="btn2" CssClass="ButtonStyle" runat="server" Text="2" OnClick="button_click" />
                <asp:Button ID="btn3" CssClass="ButtonStyle"  runat="server" Text="3" OnClick="button_click" />
                <asp:Button ID="btnMulti" CssClass="ButtonStyle" runat="server" Text="*" OnClick="Arithmetic_Operate" />
               
            </div>
            <div class="st">
                <asp:Button ID="btn0" CssClass="ButtonStyle" runat="server" Text="0" OnClick="button_click" />
                <asp:Button ID="btnD0t" CssClass="ButtonStyle" runat="server" Text="." OnClick="button_click" />
                <asp:Button ID="btnResult" CssClass="ButtonStyle" runat="server" Text="=" OnClick="btnResult_Click" />
                <asp:Button ID="btnDiv" CssClass="ButtonStyle" runat="server" Text="/" OnClick="Arithmetic_Operate"/>
                
            </div>
          
           
            <div>
               <asp:HiddenField  ID="txtTempData" runat="server" />
                <asp:HiddenField ID="operate" runat="server" />
            </div>
        </div>
            
        </section>
        
    </form>
</body>
</html>
