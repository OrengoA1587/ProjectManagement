
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="refresh" content="6;url=indexUserLogin.jsp" />
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
        <title>Incorrect Credentials</title>
    </head>  
    <body>
        <header class="error">
            <%-- Set paragraph to display message--%>
            <p><i class="fas fa-exclamation-triangle"></i>This is not an Admin Account.<i class="fas fa-exclamation-triangle"></i><br><br>
            <i class="fas fa-exclamation-triangle"></i>You will be redirected in 5 seconds.<i class="fas fa-exclamation-triangle"></i></p>
        </header>   
    </body>
</html>

