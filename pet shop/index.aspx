<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="pet_shop.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
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
      
        </div>
        <div class="row py-3 px-lg-5">
            <div class="col-lg-4">
                <a href="" class="navbar-brand d-none d-lg-block">
                    <h1 class="m-0 display-5 text-capitalize"><span class="text-primary">Pet</span>Lover</h1>
                </a>
            </div>
            <div class="col-lg-8 text-center text-lg-right">
                <div class="d-inline-flex align-items-center">
                    <div class="d-inline-flex flex-column text-center pr-3 border-right">
                        <h6>Opening Hours</h6>
                        <p class="m-0">8.00AM - 9.00PM</p>
                    </div>
                    <div class="d-inline-flex flex-column text-center px-3 border-right">
                        <h6>Email Us</h6>
                        <p class="m-0">psanyaja555@rku.ac.in</p>
                    </div>
                    <div class="d-inline-flex flex-column text-center pl-3">
                        <h6>Call Us</h6>
                        <p class="m-0">+9313165240</p>
                    </div>
                     <div class="d-inline-flex flex-column text-center pl-3">
                        <h6>Username</h6>
                       <p class="m-0"><asp:Label ID="lbl_welcome" runat="server" Text=""></asp:Label></p> 
                    </div>
                </div>
            </div>
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
                  <%--  <a href="logiiin.aspx" class="nav-item nav-link">Login</a>--%>
                    
                    <a href="Reg.aspx" class="nav-item nav-link">Registration</a>
                    <a href="index.aspx" class="nav-item nav-link active">Home</a>
                    <a href="about.aspx" class="nav-item nav-link">Pet</a>
                   <%-- <a href="service.aspx" class="nav-item nav-link">Service</a>--%>
                    <a href="price.aspx" class="nav-item nav-link">Price</a>
                      <a href="Add_to_cart.aspx" class="nav-item nav-link">Your Cart</a>
                    <a href="booking.aspx" class="nav-item nav-link">Booking</a>
                    <div class="nav-item dropdown">
                        <%--<a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown">Pages</a>
                        <div class="dropdown-menu rounded-0 m-0">
                            <a href="blog.aspx" class="dropdown-item">Blog Grid</a>
                            <a href="single.aspx" class="dropdown-item">Blog Detail</a>
                        </div>--%>
                    </div>
                    <a href="contact.aspx" class="nav-item nav-link">Contact</a>

                </div>
                <%--<a href="" class="btn btn-lg btn-primary px-3 d-none d-lg-block">Get Quote</a>--%>
            </div>
        </nav>
    </div>
    <!-- Navbar End -->


    <!-- Carousel Start -->
    <div class="container-fluid p-0">
        <div id="header-carousel" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="w-100" src="img/carousel-1.jpg" alt="Image">
                    <div class="carousel-caption d-flex flex-column align-items-center justify-content-center">
                        <div class="p-3" style="max-width: 900px;">
                            <h3 class="text-white mb-3 d-none d-sm-block">Best Pet Services</h3>
                            <h1 class="display-3 text-white mb-3">Keep Your Pet Happy</h1>
                            <h5 class="text-white mb-3 d-none d-Duo nonumy et dolor tempor no et. Diam sit diam sit diam erat"</h5>
                           <%-- <a href="" class="btn btn-lg btn-primary mt-3 mt-md-4 px-4">Book Now</a>--%>
                            <asp:Button ID="Button1" runat="server"  class="btn btn-lg btn-primary mt-3 mt-md-4 px-4" Text="Book Now"  />
                          <%--  <a href="" class="btn btn-lg btn-secondary mt-3 mt-md-4 px-4">Learn More</a>--%>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <img class="w-100" src="img/carousel-2.jpg" alt="Image">
                    <div class="carousel-caption d-flex flex-column align-items-center justify-content-center">
                        <div class="p-3" style="max-width: 900px;">
                            <h3 class="text-white mb-3 d-none d-sm-block">Best Pet Servicest Services</h3>
                            <h1 class="display-3 text-white mb-3">Pet Spa & Grooming</h1>
                            <%--<h5 class="text-white mb-3 d-none d-sm-block">Duo nonumy et dolor tempor no et. Diam sit diam sit diam erat</h5>--%>
                         <%--   <a href="" class="btn btn-lg btn-primary mt-3 mt-md-4 px-4">Book Now</a>--%>
                            <asp:Button ID="Button6" runat="server" class="btn btn-lg btn-primary mt-3 mt-md-4 px-4" Text="Book Now" />
                            <!--<a href="" class="btn btn-lg btn-secondary mt-3 mt-md-4 px-4">Learn More</a>-->
                        </div>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#header-carousel" data-slide="prev">
                <div class="btn btn-primary rounded" style="width: 45px; height: 45px;">
                    <span class="carousel-control-prev-icon mb-n2"></span>
                </div>
            </a>
            <a class="carousel-control-next" href="#header-carousel" data-slide="next">
                <div class="btn btn-primary rounded" style="width: 45px; height: 45px;">
                    <span class="carousel-control-next-icon mb-n2"></span>
                </div>
            </a>
        </div>
    </div>
    <!-- Carousel End -->


    <!-- Booking Start -->
    <div class="container-fluid bg-light">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-5">
                    <div class="bg-primary py-5 px-4 px-sm-5">
                        <form class="py-5">
                            <div class="form-group">
                               <%-- <input type="text" class="form-control border-0 p-4" placeholder="Your Name" required="required" />--%>
                                <asp:TextBox ID="name" runat="server" class="form-control border-0 p-4" placeholder="Your Name"  ></asp:TextBox>
                            </div>
                            <div class="form-group">
                               <%-- <input type="email" class="form-control border-0 p-4" placeholder="Your Email" required="required" />--%>
                                <asp:TextBox ID="email" runat="server" class="form-control border-0 p-4" placeholder="Your Email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <div class="date" id="date" data-target-input="nearest">
                                   <%-- <input type="text" class="form-control border-0 p-4 datetimepicker-input" placeholder="Reservation Date" data-target="#date" data-toggle="datetimepicker"/>--%>
                                    <asp:TextBox ID="ddate" runat="server" class="form-control border-0 p-4 datetimepicker-input" placeholder="Reservation Date" data-target="#date" data-toggle="datetimepicker"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="time" id="time" data-target-input="nearest">
                                    <%--<input type="text" class="form-control border-0 p-4 datetimepicker-input" placeholder="Reservation Time" data-target="#time" data-toggle="datetimepicker"/>--%>
                                    <asp:TextBox ID="tiime" runat="server" class="form-control border-0 p-4 datetimepicker-input" placeholder="Reservation Time" data-target="#time" data-toggle="datetimepicker"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                             <%--   <select class="custom-select border-0 px-4" style="height: 47px;">
                                    <option selected>Select A Service</option>
                                    <option value="1">Service 1</option>
                                    <option value="2">Service 1</option>
                                    <option value="3">Service 1</option>
                                </select>--%>
                                <asp:DropDownList ID="drpprice" class="custom-select border-0 px-4" style="height: 47px;" runat="server">
                                    <asp:ListItem>---Price---</asp:ListItem>
                                    <asp:ListItem>Basic</asp:ListItem>
                                    <asp:ListItem>Standred</asp:ListItem>
                                    <asp:ListItem>Premium</asp:ListItem>
                                   
                                </asp:DropDownList>
                            </div>
                            <div>
                               <%-- <button class="btn btn-dark btn-block border-0 py-3" type="submit">Book Now</button>--%>
                                <asp:Button ID="Button2" runat="server" class="btn btn-dark btn-block border-0 py-3" Text="Book Now" OnClick="Button2_Click"  />
                            </div>
                        </form>
                    </div>
                </div>
                <div class="col-lg-7 py-5 py-lg-0 px-3 px-lg-5">
                    <h4 class="text-secondary mb-3">Going for a vacation?</h4>
                    <h1 class="display-4 mb-4">Book For <span class="text-primary">Your Pet</span></h1>
                    <p>Labore vero lorem eos sed aliquy ipsum aliquy sed. Vero dolore dolore takima ipsum lorem rebum</p>
                    <div class="row py-2">
                        <div class="col-sm-6">
                            <div class="d-flex flex-column">
                                <div class="d-flex align-items-center mb-2">
                                    <h1 class="flaticon-house font-weight-normal text-secondary m-0 mr-3"></h1>
                                    <h5 class="text-truncate m-0">Pet Boarding</h5>
                                </div>
                               <%-- <p>Diam amet eos at no eos sit lorem, amet rebum ipsum clita stet</p>--%>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="d-flex flex-column">
                                <div class="d-flex align-items-center mb-2">
                                    <h1 class="flaticon-food font-weight-normal text-secondary m-0 mr-3"></h1>
                                    <h5 class="text-truncate m-0">Pet Feeding</h5>
                                </div>
                              <%--  <p>Diam amet eos at no eos sit lorem, amet rebum ipsum clita stet</p>--%>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="d-flex flex-column">
                                <div class="d-flex align-items-center mb-2">
                                    <h1 class="flaticon-grooming font-weight-normal text-secondary m-0 mr-3"></h1>
                                    <h5 class="text-truncate m-0">Pet Grooming</h5>
                                </div>
                              <%--  <p class="m-0">Diam amet eos at no eos sit lorem, amet rebum ipsum clita stet</p>--%>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="d-flex flex-column">
                                <div class="d-flex align-items-center mb-2">
                                    <h1 class="flaticon-toy font-weight-normal text-secondary m-0 mr-3"></h1>
                                    <h5 class="text-truncate m-0">Pet Tranning</h5>
                                </div>
                              <%--  <p class="m-0">Diam amet eos at no eos sit lorem, amet rebum ipsum clita stet</p>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
   
  
   
    <div class="container mt-5 pt-5 pb-3">
       <%-- <div class="d-flex flex-column text-center mb-5">
            <h4 class="text-secondary mb-3">Team Member</h4>
            <h1 class="display-4 m-0">Meet Our <span class="text-primary">Team Member</span></h1>
        </div>
        <div class="row">
            <div class="col-lg-3 col-md-6">
                <div class="team card position-relative overflow-hidden border-0 mb-4">
                    <img class="card-img-top" src="img/team-1.jpg" alt="">
                    <div class="card-body text-center p-0">
                        <div class="team-text d-flex flex-column justify-content-center bg-light">
                            <h5>Pooja sanyaja</h5>
                            <i>Founder & CEO</i>
                        </div>
                       
                    </div>
                </div>
            </div>
            <div class="col-lg-3 col-md-6">
                <div class="team card position-relative overflow-hidden border-0 mb-4">
                    <img class="card-img-top" src="img/team-2.jpg" alt="">
                    <div class="card-body text-center p-0">
                        <div class="team-text d-flex flex-column justify-content-center bg-light">
                            <h5>Keshvi dhankecha</h5>
                            <i>Chef Executive</i>
                        </div>
                        
                    </div>
                </div>
            </div>
            <div class="col-lg-3 col-md-6">
                <div class="team card position-relative overflow-hidden border-0 mb-4">
                    <img class="card-img-top" src="img/team-3.jpg" alt="">
                    <div class="card-body text-center p-0">
                        <div class="team-text d-flex flex-column justify-content-center bg-light">
                            <h5>Khushi limbasiya</h5>
                            <i>Doctor</i>
                        </div>
                      
                    </div>
                </div>
            </div>
            <div class="col-lg-3 col-md-6">
                <div class="team card position-relative overflow-hidden border-0 mb-4">
                    <img class="card-img-top" src="img/team-4.jpg" alt="">
                    <div class="card-body text-center p-0">
                        <div class="team-text d-flex flex-column justify-content-center bg-light">
                            <h5>Tanisha sagpariya</h5>
                            <i>Trainer</i>
                           
                        </div>
                        <br />
                
                        
                           
                         <br />
            <br />
            
            <br />
          
                    </div>
                </div>
            </div>
        </div>--%>
         <div class="card-body text-center p-0">
                        <div class="team-text d-flex flex-column justify-content-center bg-light">
       
                            <br />
                            <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" Height="156px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnItemCommand="DataList1_ItemCommand">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="300px" Width="300px" ImageUrl='<%# "Admin/"+Eval("Image") %>' />
                                    <br />
                                   
                                 <h5> <asp:Label ID="Label1"  runat="server" Text='<%# Eval("Emp_name") %>'></asp:Label></h5>  
                                 
                                    <br />
                                  
                                    <asp:LinkButton ID="LinkButton5" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="cmd_viewdet">View Details</asp:LinkButton>
                                 
                                    
                                </ItemTemplate>
                            </asp:DataList>
                                <div>

                            </div>
                            </div>
             <br />
             <br />
                            <asp:LinkButton ID="LinkButton3" runat="server" class="btn btn-primary py-3 px-5" OnClick="LinkButton3_Click">Previous</asp:LinkButton>  &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton4" class="btn btn-primary py-3 px-5" runat="server" OnClick="LinkButton4_Click">Next</asp:LinkButton>
                        
    
   


   



        </div>




        </div>





</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <!-- Footer Start -->
    <div class="container-fluid bg-dark text-white mt-5 py-5 px-sm-3 px-md-5">
        <div class="row pt-5">
            <div class="col-lg-4 col-md-12 mb-5">
                <h1 class="mb-3 display-5 text-capitalize text-white"><span class="text-primary">Pet</span>Lover</h1>
                <p class="m-0">Ipsum amet sed vero et lorem stet eos ut, labore sed sed stet sea est ipsum ut. Volup amet ea sanct ipsum, dolore vero lorem no duo eirmod. Eirmod amet ipsum no ipsum lorem clita ut. Ut sed sit lorem ea lorem sed, amet stet sit sea ea diam tempor kasd kasd. Diam nonumy etsit tempor ut sed diam sed et ea</p>
            </div>
            <div class="col-lg-8 col-md-12">
                <div class="row">
                    <div class="col-md-4 mb-5">
                        <h5 class="text-primary mb-4">Get In Touch</h5>
                        <p><i class="fa fa-map-marker-alt mr-2"></i>123 Street, New York, USA</p>
                        <p><i class="fa fa-phone-alt mr-2"></i>+012 345 67890</p>
                        <p><i class="fa fa-envelope mr-2"></i>info@example.com</p>
                        <div class="d-flex justify-content-start mt-4">
                            <a class="btn btn-outline-light rounded-circle text-center mr-2 px-0" style="width: 36px; height: 36px;" href="#"><i class="fab fa-twitter"></i></a>
                            <a class="btn btn-outline-light rounded-circle text-center mr-2 px-0" style="width: 36px; height: 36px;" href="#"><i class="fab fa-facebook-f"></i></a>
                            <a class="btn btn-outline-light rounded-circle text-center mr-2 px-0" style="width: 36px; height: 36px;" href="#"><i class="fab fa-linkedin-in"></i></a>
                            <a class="btn btn-outline-light rounded-circle text-center mr-2 px-0" style="width: 36px; height: 36px;" href="#"><i class="fab fa-instagram"></i></a>
                        </div>
                    </div>
                    <div class="col-md-4 mb-5">
                        <h5 class="text-primary mb-4">Popular Links</h5>
                        <div class="d-flex flex-column justify-content-start">
                            <a class="text-white mb-2" href="#"><i class="fa fa-angle-right mr-2"></i>Home</a>
                            <a class="text-white mb-2" href="#"><i class="fa fa-angle-right mr-2"></i>About Us</a>
                            <a class="text-white mb-2" href="#"><i class="fa fa-angle-right mr-2"></i>Our Services</a>
                            <a class="text-white mb-2" href="#"><i class="fa fa-angle-right mr-2"></i>Our Team</a>
                            <a class="text-white" href="#"><i class="fa fa-angle-right mr-2"></i>Contact Us</a>
                        </div>
                    </div>
                    <div class="col-md-4 mb-5">
                        <h5 class="text-primary mb-4">Newsletter</h5>
                        <form action="">
                            <div class="form-group">
                                <asp:TextBox ID="naame" runat="server" class="form-control border-0" placeholder="Your Name"></asp:TextBox>
                             
                            </div>
                            <div class="form-group">
                           
                                <asp:TextBox ID="eemail" runat="server" class="form-control border-0" placeholder="Your Email" ></asp:TextBox>
                              <%--  <input type="email" class="form-control border-0" placeholder="Your Name" required="required" />--%>
                            </div>
                            <div>
                                <asp:Button ID="btn" runat="server" Text="Submit Now" class="btn btn-lg btn-primary btn-block border-0" OnClick="btn_Click" />
                           <%--     <button class="btn btn-lg btn-primary btn-block border-0" type="submit">Submit Now</button>--%>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
   


    <!-- Back to Top -->
    <a href="#" class="btn btn-lg btn-primary back-to-top"><i class="fa fa-angle-double-up"></i></a>


    <!-- JavaScript Libraries -->
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js"></script>
    <script src="lib/easing/easing.min.js"></script>
    <script src="lib/owlcarousel/owl.carousel.min.js"></script>
    <script src="lib/tempusdominus/js/moment.min.js"></script>
    <script src="lib/tempusdominus/js/moment-timezone.min.js"></script>
    <script src="lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js"></script>

    <!-- Contact Javascript File -->
    <script src="mail/jqBootstrapValidation.min.js"></script>
    <script src="mail/contact.js"></script>

    <!-- Template Javascript -->
    <script src="js/main.js"></script>
</body>

</html>
</asp:Content>
