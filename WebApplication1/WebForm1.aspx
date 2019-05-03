<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="StyleSheet1.css" type="text/css" />
    <title></title>
    <style type="text/css">
        .nowyStyl1 {
        }

        .nowyStyl2 {
        }
    </style>
    <script runat="server">

    </script>
</head>
<body>


    <form id="form1" runat="server">

        <asp:Panel ID="Logo" runat="server" CssClass="logowanie" Visible="true">
            Podaj imię i nazwisko  <br /> <br />
            <asp:TextBox ID="text1" Text="Imie Nazwisko" runat="server"
                Width="500px" Height="100px" CssClass="text" Font-Size="64px" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="text1"
                ErrorMessage="Pole Imię jest wymagane">
                <br />Pole Imię jest wymagane
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server"
                ControlToValidate="text1"
                ErrorMessage="</br> Gościu! nie wiesz jak sie nazywasz?"
                ValidationExpression="^[A-Z ĄĘÓŚŁŻŹŃ][a-z ęóąśłżźćń][a-z ęóąśłżźćń]+\s[A-Z ĄĘÓŚŁŻŹŃ][a-z ęóąśłżźćń][a-z ęóąśłżźćń]+$">
        <br/> Gościu! nie wiesz jak sie nazywasz
            </asp:RegularExpressionValidator>
            <asp:CustomValidator  ID="CustomValidator" ControlToValidate="text1" OnServerValidate="CustomValidator1"  runat="server"><br />*Użytkownik ma już otwartą sesje</asp:CustomValidator>
            <br /><br />
            
            <asp:Button ID="Zarejestuj"
                Text="Zarejestruj"
                OnClick="Button_Click3"
                runat="server"
                AlternateText="Image text"
                ImageAlign="left"
                Visible="true"
                Width="300px"
                Height="100px" />
        </asp:Panel>

         <asp:Panel ID="Apka" runat="server" CssClass="Panel" Visible="false">
        <div id="main" runat="server">
            <div id="interfejs">
                 <h1>
        <asp:Label ID="ImieNazw" runat="server" Text-Algin="center"></asp:Label>
             </h1> 
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Timer runat="server" Interval="15000" OnTick="Unnamed1_Tick"></asp:Timer>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <br />
                        <br />
               <asp:DropDownList ID="DropDownList1" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" 
                    runat="server" cssClass="tekst">

                </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Table id="Table1" runat="server"
        CellPadding="10" 
        GridLines="Both"
        HorizontalAlign="Center" cssClass="tabela">
        <asp:TableRow>
            <asp:TableCell cssClass="tabela" >Data Uruchomienia</asp:TableCell>
            <asp:TableCell cssClass="tabela"> <asp:Label ID="DataUr" runat="server" cssClass="tekst"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell cssClass="tabela">Godzina Uruchomienia</asp:TableCell>
            <asp:TableCell cssClass="tabela"> <asp:Label ID="GodzUr" runat="server" cssClass="tekst"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell cssClass="tabela">Ile Zmian Przycisk</asp:TableCell>
            <asp:TableCell cssClass="tabela"> <asp:Label ID="LPrz" runat="server" cssClass="tekst"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell cssClass="tabela">Ile Zmian Rysunek</asp:TableCell>
            <asp:TableCell cssClass="tabela"> <asp:Label ID="LRys" runat="server" cssClass="tekst"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell cssClass="tabela">Ile Aplikacji</asp:TableCell>
            <asp:TableCell cssClass="tabela"> <asp:Label ID="Lapk" runat="server" cssClass="tekst"></asp:Label></asp:TableCell>
        </asp:TableRow>

    </asp:Table></ContentTemplate>
               
                  
                </asp:UpdatePanel> 

            </div>
            <div id="container">
                <div id="frame1">
                    <asp:ImageButton ID="ImageButton1" Text="Zmien polozenie"
                        OnClick="Button_Click2"
                        runat="server"
                        ImageUrl="kdm.jpg"
                        Visible="true"
                        cssClass="Obrazek"
                        Width="80%"
                        Height="80%"/>
                </div>
                <div id="frame2"></div>
                <div id="frame3">
                    <asp:ImageButton ID="ImageButton2"
                        Text="Zmien polozenie"
                        OnClick="Button_Click2"
                        runat="server"
                        ImageUrl="kdm.jpg"
                        Visible="false"
                       cssClass="Obrazek"
                        Width="80%"
                        Height="80%"/>
                </div>
                <div id="frame4"></div>
                <div id="frame5">
                    <asp:Button ID="Button1"
                        Text="Przełacz rysunek"
                        OnClick="Button_Click"
                        runat="server"
                        CssClass="button"
                        Width="50%"
                        Height="20%"
                        Font-size="50%"
                        />
                </div>
                <div id="frame6"></div>
                <div id="frame7">
                    <asp:ImageButton ID="ImageButton4"
                        Text="Zmien polozenie"
                        OnClick="Button_Click2"
                        runat="server"
                        ImageUrl="kdm.jpg"
                        Visible="false"
                        cssClass="Obrazek"
                        Width="80%"
                        Height="80%"

                        />
                </div>
                <div id="frame8"></div>
                <div id="frame9">
                    <asp:ImageButton ID="ImageButton3"
                        Text="Zmien polozenie"
                        OnClick="Button_Click2"
                        runat="server"
                        AlternateText="Image text"
                        ImageUrl="kdm.jpg"
                        Visible="false"
                        cssClass="Obrazek"
                        Width="80%"
                        Height="80%"/>
                </div>

            </div>
        </div>
             </asp:Panel>

    </form>
</body>
</html>

