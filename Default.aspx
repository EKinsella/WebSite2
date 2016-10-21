<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Toucan Tech</h1>
        <p class="lead">Toucan Tech assessment using ASP.NET, C# and SQL.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>New Member</h2>
            <p>
                <asp:Label ID="NameLbl" runat="server" Text="Name">Name:   &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp</asp:Label><asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>   
            </p>
            <p>
                <asp:Label ID="EmailAddrLbl" runat="server" Text="Email">Email Address: &nbsp </asp:Label><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="SchoolLbl" runat="server" Text="School">School: &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp </asp:Label><asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                                                                                                                        <asp:ListItem>St. Trinians</asp:ListItem>
                                                                                                                                        <asp:ListItem>Kettering Community College</asp:ListItem>
                                                                                                                                        <asp:ListItem>St George's</asp:ListItem>
                                                                                                                                        <asp:ListItem>St. Matthews</asp:ListItem>
                                                                                                                                        <asp:ListItem>Coventry Community College</asp:ListItem>
                                                                                                                                        <asp:ListItem>St Mary's</asp:ListItem>
                                                                                                                                     </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
            </p>
        </div>
    </div>
</asp:Content>
