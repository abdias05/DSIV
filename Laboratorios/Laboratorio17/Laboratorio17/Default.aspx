<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="row">

            <div>
            <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
AllowSorting="True" AllowPaging="True"
DataKeyNames="ProductID"
AutoGenerateEditButton="True"
Runat="Server"/>

<asp:SqlDataSource ID="MyDataSource1" runat="server"
ConnectionString="data source=ADMINIS-E1FE361;initial catalog=northwind;persist security info=True;Integrated Security=SSPI;"
ProviderName="System.Data.SqlClient"
SelectCommand="SELECT ProductId, ProductName, UnitPrice From Products"
UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductID]=@ProductID">
</asp:SqlDataSource>
      </div>
               
        </div>
    

</asp:Content>
