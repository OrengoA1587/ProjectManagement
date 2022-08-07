<%-- 
    Document   : indexUserRegistrationAdminPage
    Created on : Mar 18, 2021, 6:58:07 AM
    Author     : Anthony
--%>


<%@page import="readfile.ReadSessions"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
             
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">        
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
        <meta http-equiv="Content-Security-Policy" content="default-src;  
         
        script-src 'self'  'sha256-JE0280krcqkShSI9tiB7uYMolH2Mp4kLOi+tnmU+JI4='    
        ;style-src 'report-sample' 'self' 'unsafe-inline' 
        https://cdnjs.cloudflare.com https://fonts.googleapis.com; 
        img-src 'self' data:; base-uri 'self'; object-src 'self';
        connect-src 'self'; font-src 'self' https://cdnjs.cloudflare.com https://fonts.gstatic.com; 
        frame-src 'self';
        manifest-src 'self'; media-src 'self'; 
        worker-src 'none';">
        
         
        <link rel="stylesheet" href="assetsJSP/css/registrationStyleSheet.css">        
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="assetsJSP/mainPageCSS/Navigation-with-Button.css">
        <link rel="stylesheet" href="assetsJSP/mainPageCSS/styles.css">
        <link rel="stylesheet" href="assets/css/styles.min.css">
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
        <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
        <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
        <link rel="stylesheet" href="assetsJSP/css/popupLoginStyleSheet.css"> 
        <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
        <title>User Activation</title>        
    </head>
    <body>
        <nav class="navbar navbar-light navbar-expand-md navigation-clean-button">
            <div class="container"><img src="assetsJSP/css/images/CompanyLogo.png" height="60" width="60"><a class="user-login" href="index.jsp">Home</a><button data-toggle="collapse" class="navbar-toggler" data-target="#navcol-1"><span class="sr-only">Toggle navigation</span><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navcol-1">
                    <ul class="nav navbar-nav mr-auto">                                    
                    
                    </ul> 
                </div>
            </div>
        </nav>
        <div>
        <div><img class="image-reg" src="assetsJSP/css/images/mainPageBackgroundv3.png"></div>
        <p id="random_number"></p>        
        <div class="form-container" >                          
            <h1 class="reg-form-title">Complete the User Activation</h1>
            <form onsubmit="return validationForm()" action="activateAccountAction.jsp" method="post">
                <div class="section-one">
                    <div class="form-group">
                        <input class="form-control" type="text" name="activate" placeholder="Enter Activation Code" required=""><br> 
                    </div>   
                <button type="submit" class="form-submit-button">Confirm</button>
                </div>                    
            </form>
        </div>              

        </div>

        <div class="flex-container">             
            <footer>            
                <div class = "sticky-footer">           
                    <p>&copy; KandOPersonnelManagementSystems.com | Designed by Jon King/Anthony Orengo</p>
                </div>
            </footer>              
        </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
    </body>
</html>
