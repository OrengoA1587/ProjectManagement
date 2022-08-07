<%-- 
    Document   : indexContact
    Created on : Apr 3, 2021, 8:34:03 PM
    Author     : Anthony
--%>

<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <meta http-equiv="Content-Security-Policy" content="default-src;        
        script-src 'self' 'sha256-OzqmAO+SFutn2tx7ipegj2ASyYCgLzk+60O8Tb/3fkE=';     
        style-src 'report-sample' 'self' 'unsafe-inline' 
        https://cdnjs.cloudflare.com https://fonts.googleapis.com; 
        img-src 'self' data:; base-uri 'self'; object-src 'self'; 
        connect-src 'self'; font-src 'self' https://cdnjs.cloudflare.com https://fonts.gstatic.com; 
        frame-src 'self';  
        manifest-src 'self'; media-src 'self';  
        worker-src 'none';">
    <title>K&O Personnel Management Systems</title>     
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">     
    <link rel="stylesheet" href="assetsJSP/mainPageCSS/Footer-Dark.css">
    <link rel="stylesheet" href="assetsJSP/mainPageCSS/Navigation-with-Button.css">
    <link rel="stylesheet" href="assetsJSP/mainPageCSS/styles.css">
    <link rel="stylesheet" href="assetsJSP/css/contactStyleSheet.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">  
   
    <link rel="stylesheet" href="assetsJSP/css/popupLoginStyleSheet.css">
</head> 
<body>
    <nav class="navbar navbar-light navbar-expand-md navigation-clean-button">
        <div class="container"><img class="item-co-logo" src="assetsJSP/css/images/CompanyLogo.png" height="60" width="60">&nbsp;&nbsp;&nbsp;<a class="home-main" href="indexMainPage.jsp">Home</a><button data-toggle="collapse" class="navbar-toggler" data-target="#navcol-1"><span class="sr-only">Toggle navigation</span><span class="navbar-toggler-icon"></span></button>
            <div class="collapse navbar-collapse" id="navcol-1">
                <ul class="nav navbar-nav mr-auto">                    
                    <li class="nav-item dropdown"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#">Access </a>
                        <div class="dropdown-menu"> <a class="dropdown-item" href="indexAdminLogin.jsp" data-target="#admin-login" data-toggle="modal">Admin Portal</a><a class="dropdown-item" href="indexAdminClockInAction.jsp" data-target="#clock-in" data-toggle="modal" >Clock-In</a><a class="dropdown-item" href="indexSystemLogoutAction.jsp" data-target="#clock-out" data-toggle="modal" >Clock-Out</a></div>
                    </li>
                    <li class="nav-item dropdown"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#">Create Account </a>
                        <div class="dropdown-menu"><a class="dropdown-item" href="indexAdminRegistration.jsp" data-target="#login" data-toggle="modal">Create Admin Account</a><a class="dropdown-item" href="indexUserRegistration.jsp">Create User Account</a></div>
                    </li>
                    <li class="nav-item dropdown"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#">Info </a>
                        <div class="dropdown-menu"><a class="dropdown-item" href="indexAboutCompany.jsp">About</a><a class="dropdown-item" href="indexCompanyMission.jsp">Mission</a><a class="dropdown-item" href="indexContact.jsp">Contact</a></div>
                    </li>                    
                </ul><span class="navbar-text actions"> <a class="home-admin-login" href="indexAdminLogin.jsp" data-target="#admin-login" data-toggle="modal" >Admin Log In</a> </span>
            </div>
        </div>
    </nav>  
 
    <div ><img class="image-phone"  src="assetsJSP/css/images/contactpageimage1.png"></div>
    
    <div class="container-fluid">
        <div class="flex-container-about">
            <div class="flex-column-about">                
                <form class="ceo-contact-form">
                    <h4>Company Leadership: </h4>
                        <p>                                
                            CEO Jon King: 907-7554                                
                        </p>
                        <p>
                            CEO Anthony Orengo: 907-7555 
                        </p> 
                        <p>
                            Executive Oficer: Tim Corey: 907-7555 
                        </p>     
                        <p>
                            Executive Assistant: Robert Sanderson: 907-7555 
                        </p> 
                        
                </form>
            </div>         
        </div>        
    </div>      
    <div class="container-fluid">
        <div class="flex-container-about">
            <div class="flex-column-about">                
                <form class="security-contact-form">
                    <h4>Security Section: </h4>
                        <p>                                
                            Senior Security Manager: Jason Duphrene: 907-6554                                
                        </p>
                        <p>
                            Section Security Manager: Kiona Johnson: 907-6555 
                        </p>      
                        <p>                                
                            Security Tech: Kimberly Sampson: 907-6556                                
                        </p>
                        <p>
                            Security Tech: Jimmy Beam: 907-6557 
                        </p>  
                </form>
            </div>         
        </div>        
    </div> 
     
    <div class="container-fluid">
        <div class="flex-container-about">
            <div class="flex-column-about">                
                <form class="admin-contact-form">
                    <h4>Administrative Section: </h4>
                        <p>                                
                            Senior Manager: Maria De Santos: 907-7554                                
                        </p>
                        <p>
                            Section Manager: Jonathan Smith: 907-7555 
                        </p>      
                        <p>                                
                            S-1 Admin: Bob Carter: 907-7556                                
                        </p>
                        <p>
                            S-1 Admin: Jane Perry: 907-7557 
                        </p>  
                </form>
             </div>         
        </div>        
    </div>   
    <div class="container-fluid">
        <div class="flex-container-about">
            <div class="flex-column-about">                
                <form class="Operations-contact-form">
                    <h4>Operation Section: </h4>
                        <p>                                
                            Chief Marketing Officer: Cameron Francisco: 907-8554                                
                        </p>
                        <p>
                            Production Manager: Henry Smith: 907-8555 
                        </p>      
                        <p>                                
                            Project Manager: Michael Carson: 907-8556                                
                        </p>
                        <p>
                            Product Manager: Jimmy Beam: 907-8557 
                        </p>  
                </form>
            </div>         
        </div>        
    </div> 
     <div class="container-fluid">
        <div class="flex-container-about">
            <div class="flex-column-about">                
                <form class="finance-contact-form">
                    <h4>Finance Section: </h4>
                        <p>                                
                            Chief Financial Officer: Cameron Francisco: 907-8554                                
                        </p>
                        <p>
                            Production Manager: Henry Smith: 907-8555 
                        </p>      
                        <p>                                
                            Project Manager: Michael Carson: 907-8556                                
                        </p>
                        <p>
                            Product Manager: Jimmy Beam: 907-8557 
                        </p>  
                </form>
            </div>         
        </div>        
    </div> 
      <div class="container-fluid">
        <div class="flex-container-about">
            <div class="flex-column-about">                
                <form class="human-resource-contact-form">
                    <h4>Human Resource: </h4>
                        <p>                                
                            Chief Financial Officer: Cameron Francisco: 907-8554                                
                        </p>
                        <p>
                            Production Manager: Henry Smith: 907-8555 
                        </p>      
                        <p>                                
                            Project Manager: Michael Carson: 907-8556                                
                        </p>
                        <p>
                            Product Manager: Jimmy Beam: 907-8557 
                        </p>  
                </form>
            </div>         
        </div>        
    </div> 
     
    <div class="footer-dark">
        <footer>
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-md-3 item">
                        <h3>About</h3>
                        <ul>
                            <li><a href="indexAboutCompany.jsp">Company</a></li>
                            <li><a href="indexTeam.jsp">Team</a></li>
                            <li><a href="indexCompanyCareer.jsp">Careers</a></li>
                        </ul>
                    </div>
                    <div class="col-sm-6 col-md-3 item">
                        <h3>Help</h3>
                        <ul>
                             
                            <li><a href="https://drive.google.com/uc?export=downloads&id=1apJITNAdvz2fENDHv_0nAczogpJ6hXhC" download="k&omanual">K&O Manual(Download Doc.)</a></li>
                        </ul>
                    </div>                    
                    <div class="col item social">
                        <h3>Connect With Us</h3>
                        <a  href="https://www.facebook.com/" target="blank"><i class="fa  fa-facebook"></i></a>
                        <a href="https://twitter.com/?lang=en" target="blank"><i class="fa  fa-twitter"></i></a>
                        <a href="https://myaccount.google.com/intro/profile" target="blank"><i class="fa  fa-google-plus"></i></a>
                        <a href="https://www.youtube.com/" target="blank"><i class="fa  fa-youtube"></i></a>
                    </div>
                </div>
                <p class="copyright">&nbsp;� 2021 KandOPersonnelManagementSystems.com | Designed by Jon King/Anthony Orengo</p>
            </div>
        </footer>
    </div>
    <%--Modal Controllers----------------------------------------------------------------///////--%>
     <div id="admin-login" class="modal fade" role="dialog">
        <div class="modal-dialog">
    
        <div class="modal-content">
            <div class="modal-body">
                <button data-dismiss="modal" class="close">&times;</button>
            
                <form action="indexAdminLoginAction.jsp" method="post" >
                    <div ><h2>Admin Login</h2></div>              
                
                    <div class="form-group" >                  
                        <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                    </div>   
                    <div class="form-group">
                        <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                    </div>  
                    <div class="form-group">
                        <button class="home-popup-login" type="submit">Login</button>             
                    </div> 
             
                </form>
            </div>
        </div>
    </div>  
    </div>
    <div id="login" class="modal fade" role="dialog">
        <div class="modal-dialog">
    
        <div class="modal-content">
            <div class="modal-body">
                <button data-dismiss="modal" class="close">&times;</button>
            
                <form action="indexAdminLoginRegistrationAction.jsp" method="post" >
                    <div ><h2>Admin Login Required</h2></div>              
                
                    <div class="form-group" >                  
                        <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                    </div>   
                    <div class="form-group">
                        <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                    </div>  
                    <div class="form-group">
                        <button class="home-popup-login" type="submit">Login</button>             
                    </div> 
             
                </form>
            </div>
        </div>
    </div>  
    </div>
     <div id="logout" class="modal fade" role="dialog">
        <div class="modal-dialog">
    
        <div class="modal-content">
            <div class="modal-body">
                <button data-dismiss="modal" class="close">&times;</button>
            
                <form action="indexSystemLogoutAction.jsp" method="post" >
                    <div ><h2>System Logout</h2></div>              
                
                    <div class="form-group" >                  
                        <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                    </div>   
                    <div class="form-group">
                        <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                    </div>  
                    <div class="form-group">
                        <button class="home-popup-login" type="submit">Logout</button>             
                    </div> 
                    <div ><h3>Admin Required!</h3></div> 
             
                </form>
            </div>
        </div>
    </div>  
    </div> 
    <div id="clock-in" class="modal fade" role="dialog">
        <div class="modal-dialog">
    
        <div class="modal-content">
            <div class="modal-body">
                <button data-dismiss="modal" class="close">&times;</button>
            
                <form action="indexAdminClockInAction.jsp" method="post" >
                    <div ><h2>Clock-In</h2></div>              
                
                    <div class="form-group" >                  
                        <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                    </div>   
                    <div class="form-group">
                        <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                    </div>  
                    <div class="form-group">
                        <button class="home-popup-login" type="submit">Logout</button>             
                    </div> 
                    <div ><h3>Admin Required!</h3></div> 
             
                </form>
            </div>
        </div>
    </div>  
    </div> 
     <div id="clock-out" class="modal fade" role="dialog">
        <div class="modal-dialog">
    
        <div class="modal-content">
            <div class="modal-body">
                <button data-dismiss="modal" class="close">&times;</button>
            
                <form action="indexSystemLogoutAction.jsp" method="post" >
                    <div ><h2>Clock-Out</h2></div>              
                
                    <div class="form-group" >                  
                        <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                    </div>   
                    <div class="form-group">
                        <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                    </div>  
                    <div class="form-group">
                        <button class="home-popup-login" type="submit">Logout</button>             
                    </div> 
                    <div ><h3>Admin Required!</h3></div> 
             
                </form>
            </div>
        </div>
    </div>  
    </div>  
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
</body>
</html>