<%-- 
    Document   : indexStudentOpportunities
    Created on : Apr 16, 2021, 10:03:50 AM
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
                        </form>graduation cap
                </div>
            </div>
        </div>  
    </div>
    <%--Displays admin login with popup form--%>
    <div id="covid-info" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <p>***Due to the Covid-19 pandemic, internship positions may be limited. Ensure to apply in a timely manner or else the position you were looking to apply for, is taken.</p>
                </div>
            </div>
        </div>  
    </div>
     <%--Title Section--%>
    <div class="flex-container-title">
        <div class="flex-column-title">    
            <span class="navbar-text actions"> <a class="covid-19" href="indexAdminLogin.jsp" data-target="#covid-info" data-toggle="modal" >**Covid-19 Information</a> </span>

            <div class="career-title-stu"><h1>Student Employment</h1></div>
        </div>        
    </div>  
     <%--Section 0 containers--%>
    <div class="flex-container-section-0">    
        
        <div class="flex-container-title-0" >                                        
            <h1>Student Opportunities</h1> 
            <p>Here at K&O, we understand the importance of college students gaining experience prior to graduating. If you are currently in the
            process of obtaining an undergraduate, Bachelors, Masters, or PhD, K&O has positions available for students to gain work related experience.
            We offer a variety of interships throughout the year, targeting a students specific area of learning. Internships are available during the 
            summer only and typically last 3-4 months.</p>
        </div> 
        <%--
         Photo by <a href="https://unsplash.com/@taiscaptures?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Tai's Captures</a> on <a href="https://unsplash.com/s/photos/graduation-cap?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>
         --%>
         <div class="flex-container-0-image">    
            <form>
               
                <div><img class="image-worker"  src="assetsJSP/css/images/tai-s-captures-u4K_JOZmhCM-unsplash.jpg"></div>    
            </form>                
        </div> 
           
    </div>
    <%--Section 2 containers--%>
    <div class="flex-container-section-2"> 
         
        <div class="flex-container-1">   
            
            <form>
                <h4>Internship</h4> 
                <span class="navbar-text actions"> <a class="learn-btn-career" href="ohNo.jsp" data-target="#intern-form" data-toggle="modal" >Apply</a> </span>                           
            </form> 
        </div>  
        <div class="flex-container-2">   
            <form>
                <h4>Recent Graduates</h4> 
                <span class="navbar-text actions"> <a class="learn-btn-career" href="indexAdminLogin.jsp" data-target="#graduate-form" data-toggle="modal">Apply</a> </span>                             
            </form> 
        </div>
   
    </div>
    
    <%--Section 3 containers--%>
    <div class="flex-container-section-3">  
        <div class="flex-container-1-image">    
            <form>
                <%--Photo by <a href="https://unsplash.com/@priscilladupreez?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Priscilla Du Preez</a> on <a href="https://unsplash.com/s/photos/college-job?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>
                --%>
                <div><img class="image-worker-1-emp"  src="assetsJSP/css/images/priscilla-du-preez-XkKCui44iM0-unsplash.jpg">      </div>   
            </form>                
        </div>   
        <div class="flex-container-2-image">    
            <form>
                <%--Attributed Image Source: Photo by <a href="https://unsplash.com/@austindistel?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Austin Distel</a> on <a href="https://unsplash.com/s/photos/working?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>
                --%>
                <div><img class="image-worker-2-emp"  src="assetsJSP/css/images/jodyhongfilms-sI1mbxJFFpU-unsplash.jpg"></div>   
            </form>                
        </div>
        <div class="flex-container-3-image">    
            <form>
                <%--Attributed Image Source:Photo by <a href="https://unsplash.com/@austindistel?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Austin Distel</a> on <a href="https://unsplash.com/s/photos/working?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>
   
                --%>
                <div><img class="image-worker-3-emp"  src="assetsJSP/css/images/austin-distel-wD1LRb9OeEo-unsplash.png"></div>   
            </form>                
        </div>
    </div>
    
    <%--//////////////////////////////////////////////////////////////////////
    Displays Application/resume upload internship--%>
    
    <div id="intern-form" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <button data-dismiss="modal" class="close">&times;</button>
                         <form action=" ">
                <h2>Resume Upload</h2>
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
                        <label for="subject">Position</label>
                    </div>
                    <div class="col-75">
                        <select id="position" name="position">
                        <option value="adm-int">Administration Intern</option>
                        <option value="info-tech-int">Information Technology Intern</option>
                        <option value="sec-int">Security(Cyber)Intern</option>
                        <option value="fin-int">Finance Intern</option>
                    </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="subject">Phone Number</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="position" name="empPosition" placeholder="Enter Number"  >
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="file">Upload Resume</label>
                    </div>
                    <div class="col-75">
                        <input type="file" id="myFile" name="filename">
                    </div>
                </div>       
                <div class="submit-btn">
                    <input type="submit" value="Submit">
                </div>
            </form>
                </div>
            </div>
        </div>  
    </div>
    <%--Graduate Resume Section/////////////////////////////--%>
    <div id="graduate-form" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <button data-dismiss="modal" class="close">&times;</button>
                         <form action=" ">
                <h2>Resume Upload</h2>
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
                        <label for="subject">Position</label>
                    </div>
                    <div class="col-75">
                        <select id="position" name="position">
                        <option value="adm-grad">Administration Graduate</option>
                        <option value="info-tech-grad">Information Technology Graduate</option>
                        <option value="sec-grad">Security(Cyber)Graduate</option>
                        <option value="fin-grad">Finance Graduate</option>
                        <option value="mark-grad">Marketing Graduate</option>
                        <option value="Pro-grad">Production Graduate</option>
                        <option value="hr-grad">Human Resource Graduate</option>
                    </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="subject">Phone Number</label>
                    </div>
                    <div class="col-75">
                        <input type="text" id="position" name="empPosition" placeholder="Enter Number"  >
                    </div>
                </div>
                <div class="row">
                    <div class="col-25">
                        <label for="file">Upload Resume</label>
                    </div>
                    <div class="col-75">
                        <input type="file" id="myFile" name="filename">
                    </div>
                </div>       
                <div class="row">
                    <input type="submit" value="Submit">
                </div>
            </form>
                </div>
            </div>
        </div>  
    </div>
     
    <%--Error-Unavailable-Jobs--%>
     <div id="unavailable-job" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <button data-dismiss="modal" class="close">&times;</button>
            <form action=" ">
                <h2>Currently, all positions are filled. Feel free to contact the company with questions or concerns. </h2>
                <div class="row">
                    
                </div>            
                 
            </form>
                </div>
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
                </div>
                
            </div>
         </footer>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
</body>
</html>