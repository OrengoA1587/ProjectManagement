<%-- 
    Document   : indexCompanyCareer
    Created on : Apr 6, 2021, 3:07:42 PM
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
    <link rel="stylesheet" href="assetsJSP/css/careersStyleSheet.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">  
   
    <link rel="stylesheet" href="assetsJSP/css/popupLoginStyleSheet.css">
</head> 
<body>
    <%--Navigation bar items--%>
    <nav class="navbar navbar-light navbar-expand-md navigation-clean-button">
        <div class="container"><img class="item-co-logo" src="assetsJSP/css/images/CompanyLogo.png" height="60" width="60">&nbsp;&nbsp;&nbsp;<a class="home-main" href="indexMainPage.jsp">Home</a><button data-toggle="collapse" class="navbar-toggler" data-target="#navcol-1"><span class="sr-only">Toggle navigation</span><span class="navbar-toggler-icon"></span></button>
            <div class="collapse navbar-collapse" id="navcol-1">
                <ul class="nav navbar-nav mr-auto">                    
                    <li class="nav-item dropdown"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#">Access </a>
                        <div class="dropdown-menu"> <a class="dropdown-item" href="indexAdminLogin.jsp" data-target="#admin-login" data-toggle="modal">Admin Login</a></div>
                    </li>
                         
                    <li class="nav-item dropdown"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#">Info </a>
                        <div class="dropdown-menu"><a class="dropdown-item" href="indexAboutCompany.jsp">About</a><a class="dropdown-item" href="indexCompanyMission.jsp">Mission</a><a class="dropdown-item" href="indexContact.jsp">Contact</a></div>
                    </li>  
                </ul><span class="navbar-text actions"> <a class="home-admin-login" href="indexAdminLogin.jsp" data-target="#admin-login" data-toggle="modal" >Admin Log In</a> </span>
            </div>
        </div>
    </nav> 
     <%--Displays admin login with popup form--%>
    <div id="admin-login" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <button data-dismiss="modal" class="close">&times;</button>
                        <form action="indexAdminLoginAction.jsp" method="post" >
                            <div ><h2>Admin Login</h2></div>              
                
                            <div class="form-group" >                  
                                <input class="form-control" type="text" name="adminID" placeholder="Scan ID"><br>
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
     <%--Displays admin login with popup form--%>
    <div id="login" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <button data-dismiss="modal" class="close">&times;</button>
                        <form action="indexAdminLoginRegistrationAction.jsp" method="post" >
                            <div ><h1>Admin Login Required</h1></div>              
                            <div class="form-group" >                  
                                <input class="form-control" type="text" name="adminID" placeholder="Scan ID"><br>
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
    <div class="flex-container-section-1">
        <div>                
            <div class="career-title"><h1>Company Careers</h1></div>
        </div>        
    </div>   
    <div class="flex-container-section-0">    
        
        <div class="flex-container-title-0" >                                        
            <h1>K&O Career Opportunities</h1>
             <p>The K&O Personnel Management Systems Company, offers many career opportunities for anyone interested in working for our 
             company. Opportunities include, management, Information Technology, Administration, Physical/Cyber,
             Human Resources, Finance, Marketing, and products and services. We also offer interships for students, 
             Remote/work from home, and Apprentice opportunities. Here at K&O we value our employees and welcome anyone who is willing
             to be part of our team.</p>
        </div> 
         <%--Attributed Image Source:Photo by <a href="https://unsplash.com/@austindistel?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Austin Distel</a> on <a href="https://unsplash.com/s/photos/working?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>
         --%>
         <div class="flex-container-0-image">    
            <form>               
                <div><img class="image-worker"  src="assetsJSP/css/images/austin-distel-wD1LRb9OeEo-unsplash.png"></div>    
            </form>                
        </div>  
           
    </div>
    <div class="flex-container-section-2">            
        <div class="flex-container-1">   
            <form>
                <h4>Employment Opportunities</h4> 
                <span class="navbar-text actions"> <a class="learn-btn-career" href="indexEmploymentOpportunities.jsp">Learn</a> </span>                           
            </form> 
        </div>  
        <div class="flex-container-2">   
            <form>
                <h4>Student/Intern Opportunities</h4> 
                <span class="navbar-text actions"> <a class="learn-btn-career" href="indexStudentOpportunities.jsp">Learn</a> </span>                             
            </form> 
        </div>
        <div class="flex-container-3">   
            <form>
                <h4>Remote Opportunities</h4> 
                <span class="navbar-text actions"> <a class="learn-btn-career" href="ohNo.jsp">Learn</a> </span>
            </form> 
        </div>
        <div class="flex-container-4">   
            <form>
                <h4>Apprentice Opportunities</h4> 
                <span class="navbar-text actions"> <a class="learn-btn-career" href="ohNo.jsp" >Learn</a> </span>
            </form> 
        </div>       
    </div>                    
        
    <div class="flex-container-section-3">    
        <div class="flex-container-1-image">    
            <form>
                <div><img class="image-worker4"  src="assetsJSP/css/images/worker-image.png">      </div>   
                 
            </form>           
        </div>
         
    </div>
         
        <div id="contact-us-form" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <button data-dismiss="modal" class="close">&times;</button>
            <form class="contact-form" action=" ">
                <h2>Contact Us</h2>
                <div class="row">
                    <div class="col-25">
                        <label for="fname">First Name</label>
                    </div>
                     <div class="col-75">
                        <input type="text" id="fname" name="firstname" placeholder="Your name..">
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="lname">Last Name</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="lname" name="lastname" placeholder="Your last name..">
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="lname">Email</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="email" name="Email" placeholder="Enter Email..">
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="country">Country</label>
                    </div>
                <div class="col-75">
                    <select id="country" name="country">
                        <option value="australia">Australia</option>
                        <option value="canada">Canada</option>
                        <option value="usa">USA</option>
                    </select>
                </div>
                </div>
                 <div class="row">
                    <div class="col-25">
                        <label for="subject">Subject</label>
                    </div>
                    <div class="col-75">
                        <textarea id="subject" name="subject" placeholder="Write something.." ></textarea>
                    </div>
                </div>
                     
                <div class="row">
                    <input type = "button" class = "res-sub-btn"  value="Submit"> 
                </div>
            </form>
                </div>
            </div>
        </div>  
           
    </div>      
    <%--Displays conatct form--%>         
     
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
                            <li><a href="indexReferAdmin.jsp">Account Help</a></li>
                         </ul>
                    </div>
                    <div class="col item social">
                        <h3>Connect With Us</h3>
                        <a  href="https://www.facebook.com/" target="blank"><i class="fa  fa-facebook"></i></a>
                        <a href="https://twitter.com/?lang=en" target="blank"><i class="fa  fa-twitter"></i></a>
                        <a href="https://myaccount.google.com/intro/profile" target="blank"><i class="fa  fa-google-plus"></i></a>
                        <a href="https://www.youtube.com/" target="blank"><i class="fa  fa-youtube"></i></a>
                    </div>
                    <div class="flex-container-contact">    
                    <div><a class="contact-us-btn" href="indexAdminLogin.jsp" data-target="#contact-us-form" data-toggle="modal" >Contact us</a></div>     
                    </div> 
                </div>
                 
            </div>
        </footer>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
</body>
</html>