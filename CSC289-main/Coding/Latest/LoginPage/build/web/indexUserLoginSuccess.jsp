<%-- 
    Document   : indexUserLogout
    Created on : Feb 11, 2021, 6:06:26 PM
    Author     : Anthony
--%>
<%@page import="readfile.ReadSessions"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="refresh" content="5;url=indexUserLogin.jsp" />
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Logout</title>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link rel="stylesheet" href="assetsJSP/css/loginStyleSheet.css">
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link rel="stylesheet" href="assetsJSP/css/loginStyleSheet.css">
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">     
        <link rel="stylesheet" href="assetsJSP/mainPageCSS/Footer-Dark.css">
        <link rel="stylesheet" href="assetsJSP/mainPageCSS/Navigation-with-Button.css">
        <link rel="stylesheet" href="assetsJSP/mainPageCSS/styles.css">
        <link rel="stylesheet" href="assetsJSP/css/popupLoginStyleSheet.css">   
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        
    </head>
    
    <body class="body2">      
        <br>
         <div class="image">  
             
            <div><img src="assetsJSP/css/images/mainPageBackgroundv2.png" class="image " alt=”K&OLogo” ></div>              
        </div>
        
        <div class="flex-container">   
            <div class="login-clean-user-login">            
                <form action="indexUserLogin.jsp" method="post" >
                    <div class="illustration">   
                        <br><br>
                        <img src="assetsJSP/css/images/success.png" width="80" height="80">
                    </div>
                    <div class="form-group">   
                        <br>
                        <p><center><h2>Login Success</h2></center></p>                        
                    </div>  
                    <div class="form-group">
                        <button class="btn btn-primary btn-block" type="submit">Done</button>             
                    </div>                        
                </form>   
            </div>
        </div>        
        <div class="flex-container">
           <nav>
               <div  >                    
                    <a href="indexUserLogin.jsp">Home</a>             
               </div>           
           </nav>   
        </div>          
        <div class="sticky-footer">
            <footer>      
                <p>&copy; KandOPersonnelManagementSystems.com | Designed by Jon King/Anthony Orengo</p>           
            </footer>             
        </div> 
    </body>
    
</html>
