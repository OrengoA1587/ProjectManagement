<%-- 
    Document   : error
    Created on : Feb 2, 2021, 7:07:57 PM
    Author     : Anthony
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="refresh" content="5;url=index.jsp" />
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
        <link rel="stylesheet" href="assetsJSP/css/errorPageStyleSheet.css">
        <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
        <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
        <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
        <title>404! Page Error</title><%-- Webpage tab title--%>
    </head>  
    <body>  
        <nav>
             <%-- Creates an active link home button in the nav section--%>   
            <div>                    
                <a href="index.jsp">Home</a>         
            </div>           
        </nav> 
        <header class="error"> 
            <%-- Displays page title using heading style one --%>
            <h1>404</h1>
            <%-- Set paragraph to display message--%>
            <p>Oops! The page you requested was not found. <i class="fas fa-exclamation-triangle"></i></p>                      
        </header>
            
    </body>
</html>

