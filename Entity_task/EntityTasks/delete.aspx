<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="EntityTasks.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
   <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
             <nav class="navbar navbar-expand-lg ">
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
    <a class="navbar-brand" href="#">Hidden brand</a>
    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
      <li class="nav-item active">
        <a class="nav-link" href="#">Home </a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Link</a>
      </li>
      <li class="nav-item">
        <a class="nav-link disabled" href="#">Disabled</a>
      </li>
    </ul>
      <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search"/>
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
    
      <br />
      <br />
    
  </div>
</nav>
        <div>


             <asp:GridView ID="grd" runat="server"  CssClass="table table-striped table-dark" AutoGenerateColumns="False" >
                   <Columns>

        <asp:BoundField  DataField="CustomerID" HeaderText="CustomerID" />
         <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" />
         <asp:BoundField DataField="Age" HeaderText="Age" />
         <asp:BoundField DataField="Phone" HeaderText="Phone" />
          <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="city" HeaderText="city" />


            <asp:ImageField DataImageUrlField="Photo" HeaderText="Image" >
         
                <ControlStyle Height="150px" Width="150px" />
            </asp:ImageField>

        </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            
        </div>
    </form>
</body>
</html>
