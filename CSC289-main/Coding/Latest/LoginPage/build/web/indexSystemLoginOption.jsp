<%-- 
    Document   : indexSystemLoginOption
    Created on : Mar 17, 2021, 4:38:04 PM
    Author     : Anthony
--%>

<%@page import="readfile.ReadSessions"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
 
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta http-equiv="Content-Security-Policy" content="default-src;        
        script-src 'self' 'sha256-OzqmAO+SFutn2tx7ipegj2ASyYCgLzk+60O8Tb/3fkE=';     
        style-src 'report-sample' 'self' 'unsafe-inline' 
        https://cdnjs.cloudflare.com https://fonts.googleapis.com; 
        img-src 'self' data:; base-uri 'self'; object-src 'self'; 
        connect-src 'self'; font-src 'self' https://cdnjs.cloudflare.com https://fonts.gstatic.com; 
        frame-src 'self';  
        manifest-src 'self'; media-src 'self';  
        worker-src 'none';">
        <title>Admin Login</title>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link rel="stylesheet" href="assetsJSP/css/loginStyleSheet.css">
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="assetsJSP/css/popupLoginStyleSheet.css"> 
        <link rel="stylesheet" href="assetsJSP/mainPageCSS/styles.css">
        <link rel="stylesheet" href="assetsJSP/Navigation-with-Button/styles.css">
    </head>
    <body>
        
        <div class="flex-container">
        <div class="login-clean-admin">          
            <form action="indexAdminSystemLoginAction.jsp" method="post" >  
                <div ><h1>Admin System</h1></div>              
                <div class="illustration">                       
                    <img src="assetsJSP/css/images/iconfinder_Account_1891016.png" alt="accountIcon" width= "60"  height="60" >
                </div>
                <div class="form-group" >                  
                    <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                </div>   
                <div class="form-group">
                    <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                </div>  
                <div class="form-group">
                    <button class=" btn-primary" type="submit">Login</button>             
                </div>                        
                     
            </form>        
        </div> 
        </div >
        <div class="flex-container">
        <div class="login-clean-user ">          
            <form action="indexUserSystemLoginAction.jsp" method="post" >  
                <div ><h1>User System</h1></div>              
                <div class="illustration">                       
                    <img src="assetsJSP/css/images/iconfinder_Account_1891016.png" alt="accountIcon" width= "60"  height="60" >
                </div>
                <div class="form-group" >                  
                    <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                </div>   
                <div class="form-group">
                    <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                </div>  
                <div class="form-group">
                    <button class=" btn-primary" type="submit">Login</button>             
                </div>                        
                     
            </form>        
        </div> 
        </div >
        <nav class="navbar navbar-light navbar-expand-md navigation-clean-button">
            <div class="container"><img class="item-co-logo" src="assetsJSP/css/images/CompanyLogo.png" height="60" width="60">&nbsp;&nbsp;&nbsp;<a class="home-main" href="index.jsp">Home</a><button data-toggle="collapse" class="navbar-toggler" data-target="#navcol-1"><span class="sr-only">Toggle navigation</span><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navcol-1">                
                     
                </div>
            </div>
        </nav> 
        <div id="admin-login" class="modal fade" role="dialog">
        <div class="modal-dialog">
    
        <div class="modal-content">
            <div class="modal-body">
                <button data-dismiss="modal" class="close">&times;</button>
            
                <form action="indexSystemMainLogoutAction.jsp" method="post" >
                    <div ><h2>Admin Logout</h2></div>              
                
                    <div class="form-group" >                  
                        <input class="form-control" type="text" name="adminID" placeholder="Scan Admin ID"><br>
                    </div>   
                    <div class="form-group">
                        <input class="form-control"  type="password" name="pinNum" placeholder="Enter pin"  required=""><br>                    
                    </div>  
                    <div class="form-group">
                        <button class="home-popup-login" type="submit">Logout</button>             
                    </div> 
             
                </form>
            </div>
        </div>
    </div>  
    </div>
            <div><img class="image-main"  src="assetsJSP/css/images/mainPageBackgroundv2.png"</div>

        <div class="sticky-footer">
         <footer>      
                <p>&copy; KandOPersonnelManagementSystems.com | Designed by Jon King/Anthony Orengo</p>           
        </footer>             
        </div>        
    </body>
       <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
</html>
