
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="pet_shop.Admin.category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <html>

<head>
    <meta charset="utf-8">
    <title>PetLover - Pet Care Website Template</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <meta content="Free HTML Templates" name="keywords">
    <meta content="Free HTML Templates" name="description">

    <!-- Favicon -->
    <link href="img/favicon.ico" rel="icon">

    <!-- Google Web Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Nunito+Sans&family=Nunito:wght@600;700;800&display=swap" rel="stylesheet"> 

    <!-- Font Awesome -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">

    <!-- Flaticon Font -->
    <link href="lib/flaticon/font/flaticon.css" rel="stylesheet">

    <!-- Libraries Stylesheet -->
    <link href="lib/owlcarousel/assets/owl.carousel.min.css" rel="stylesheet">
    <link href="lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css" rel="stylesheet" />

    <!-- Customized Bootstrap Stylesheet -->
    <link href="css/style.css" rel="stylesheet">
</head>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <body>
    <!-- Topbar Start -->
    <div class="container-fluid">
     
        <div class="row py-3 px-lg-5">
              
           
            <div class="col-lg-4">
                <a href="" class="navbar-brand d-none d-lg-block">
                    <h1 class="m-0 display-5 text-capitalize"><span class="text-primary">Pet</span>Lover</h1>
                </a>
               
                <asp:Label ID="lbl_welcome" runat="server" Text=""></asp:Label>
        
            </div>
            <br />
            
           
        
        </div>
    </div>
    <!-- Topbar End -->


    <!-- Navbar Start -->
    <div class="container-fluid p-0">
        <nav class="navbar navbar-expand-lg bg-dark navbar-dark py-3 py-lg-0 px-lg-5">
            <a href="" class="navbar-brand d-block d-lg-none">
                <h1 class="m-0 display-5 text-capitalize font-italic text-white"><span class="text-primary">Safety</span>First</h1>
            </a>
            <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbarCollapse">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse justify-content-between px-3" id="navbarCollapse">
                <div class="navbar-nav mr-auto py-0">
                  
                       <div><a href="regs.aspx" class="nav-item nav-link ">Register</a></div>
                     <div><a href="category.aspx" class="nav-item nav-link ">Category</a></div>
                    <div><a href="employee.aspx" class="nav-item nav-link ">Employee</a></div>
                    <div><a href="servicee.aspx" class="nav-item nav-link ">Our services</a></div>
                     <div><a href="contacts.aspx" class="nav-item nav-link ">Contact Details</a></div>
                       <div><a href="registration.aspx" class="nav-item nav-link ">Registration</a></div>
                    <div><a href="aprice.aspx" class="nav-item nav-link ">PriceChart</a></div>
                    <div><a href="aservice.aspx" class="nav-item nav-link ">Booking</a></div>
                    
                   
                    
                </div>
                <%-- <a href="" class="btn btn-lg btn-primary px-3 d-none d-lg-block">Get Quote</a>--%>
            </div>
        </nav>
    </div>
    <!-- Navbar End -->


    <!-- Contact Start -->
    <div class="container-fluid pt-5">
         
        <div class="d-flex flex-column text-center mb-5 pt-5">
            <%--   <h4 class="text-secondary mb-3">Register Page</h4>--%>
            <h1 class="display-4 m-0">Category page <span class="textAny Query"></span></h1>
        </div>

         <div class="row justify-content-center">
            <div class="col-12 col-sm-8 mb-5">
                <div class="contact-form">
                    <div id="success"></div>
                 
                    <form name="sentMessage" id="contactForm" novalidate="novalidate">
                       
                        <div class="control-group">
                           
                            <asp:Label ID="Label1" runat="server" Text="Pet Id"></asp:Label>
                            <asp:TextBox ID="pid" runat="server" class="form-control p-4"   ></asp:TextBox>
                       
                        </div>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Pet Type"></asp:Label>
                        <div class="control-group">
                      
                            <asp:DropDownList ID="drptype"  runat="server">
                                <asp:ListItem>---Select---</asp:ListItem>
                                <asp:ListItem>Dog</asp:ListItem>
                                <asp:ListItem>Cat</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <br />
                         <div class="control-group">
                             <asp:Label ID="Label3" runat="server" Text="Pet Name"></asp:Label>
                             <asp:TextBox ID="pname" runat="server" class="form-control p-4"></asp:TextBox>
                           
                        </div>
                        <br />
                         <div class="control-group">
                             <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
                             <asp:TextBox ID="pprice" runat="server" class="form-control p-4"></asp:TextBox>
                           
                        </div>
                    <br />
                     <div class="control-group">
                          
                         <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
                         <asp:TextBox ID="desc" runat="server"  TextMode="MultiLine" class="form-control p-8"></asp:TextBox>
                        </div>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Pet image"></asp:Label>
                    <div  class="control-group">
                        <asp:FileUpload ID="fldimg" class="form-control p-2" runat="server" />
                    </div>
                        <br />
                  
                      <div>
                          <asp:Button ID="btn" class="btn btn-primary py-3 px-5" runat="server" Text="Done" OnClick="btn_Click" />
                      </div>
                            
                   <br />
                        <br />
                        <br />
    <!-- Contact End -->
        
        </span>
         </div>

         </div>


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="#FF9900" BorderWidth="8px" Width="892px" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="P_id">
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("P_id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="P_type">
                <ItemTemplate>
                    <asp:Label ID="Label10" runat="server" Text='<%# Eval("P_type") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="P_name">
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<%# Eval("P_name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="P_Price">
                <ItemTemplate>
                    <asp:Label ID="Label12" runat="server" Text='<%# Eval("Price_p") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Description">
                <ItemTemplate>
                    <asp:Label ID="Label13" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="image">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="50px" Width="50px" ImageUrl='<%# Eval("image") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="cmd_edt">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="cmd_dlt">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
     </form>

                 
                </div>
            </div>
        
        </div>
    </div>
</asp:Content>
