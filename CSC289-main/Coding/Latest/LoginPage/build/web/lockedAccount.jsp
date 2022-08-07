<%@page import="java.util.Date"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="refresh" content="5;url=indexUserLogin.jsp" />
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta charset="UTF-8">
        <meta http-equiv="Content-Security-Policy" content="default-src;        
        script-src 'self';     
        style-src 'report-sample' 'self' 'unsafe-inline' 
        https://cdnjs.cloudflare.com https://fonts.googleapis.com; 
        img-src 'self' data:; base-uri 'self'; object-src 'self'; 
        connect-src 'self'; font-src 'self' https://cdnjs.cloudflare.com https://fonts.gstatic.com; 
        frame-src 'self';  
        manifest-src 'self'; media-src 'self';  
        worker-src 'none';">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="assetsJSP/css/lockAccountStyleSheet.css">
        <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
        <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
        <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
        <title>Incorrect Credentials</title>
    </head>  
    <body>  
        <nav>  
            <div>
                <a href="indexMainPage.jsp">Home</a>
            </div>
        </nav>
        <header class="error">
            <h1>Locked Account</h1>
            <%-- Set paragraph to display message--%>
            <br>
            <p><i class="fas fa-exclamation-triangle"></i>Your account is locked<i class="fas fa-exclamation-triangle"></i><br><br></p>
            
            <b><i class="fas fa-exclamation-triangle"></i>Contact your system administrator.<i class="fas fa-exclamation-triangle"></i></b>
        </header>   
    </body>
</html>

