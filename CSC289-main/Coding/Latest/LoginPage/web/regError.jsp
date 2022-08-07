<%-- 
    Document   : regError
    Created on : Mar 5, 2021, 1:23:18 PM
    Author     : Anthony
--%>

<%@page import="readfile.ReadSessions"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
         
        <title>JSP Page</title>
    </head>
    <body>
<%
    ReadSessions r = new ReadSessions();
    r.getPost(request, response, session);
%>
        <h1>Pins must match/User Pin Not Long Enough!</h1>
        <script>
        setTimeout(function() {
      document.location = "indexUserRegistration.jsp";
        }, 3000); // <-- this is the delay in milliseconds
</script>
    </body>
</html>
