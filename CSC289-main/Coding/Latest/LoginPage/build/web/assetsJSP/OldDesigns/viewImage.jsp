<%@ page import="java.sql.*"%>
<%@ page import="java.io.*"%>
 
<%
String im=request.getParameter("imgID");
Blob image = null;
Connection con = null;
byte[ ] imgData = null ;
Statement stmt = null;
ResultSet rs = null;
try {
Class.forName("com.mysql.jdbc.Driver");
 con = DriverManager.getConnection("jdbc:mysql://sql5.freemysqlhosting.net:3306/sql5391908","sql5391908","FpyLREFiQE");
stmt = con.createStatement();
rs = stmt.executeQuery("select imageID from userdatamain where userID = '11111'");
if (rs.next()) {
image = rs.getBlob(1);
imgData = image.getBytes(1,(int)image.length());
}
else {
out.println("Display Blob Example");
out.println("image not found for given id>");
return;
}
// display the image
response.setContentType("image/jpg");
OutputStream o = response.getOutputStream();
o.write(imgData);

o.flush();
o.close();
} catch (Exception e) {
out.println("Unable To Display image");
out.println("Image Display Error=" + e.getMessage());
return;
} finally {
try {
 rs.close();
 stmt.close();
con.close();
} catch (SQLException e) {
e.printStackTrace();
}
}


%>    
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Account Created</title>
        <link rel="stylesheet" href="saveStyleSheet.css">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
    </head>
    <body>
        <form action="viewImage.jsp" method="post">
            <img src="image" name="imgData" width=60px height=60px>
            <input  type="submit" name="" value="Continue">   
     
        </form>  
    </body>
</html>

 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
<!--Blob image = null;
Connection con = null;
byte[ ] imgData = null ;
Statement stmt = null;
ResultSet rs = null;
try {
Class.forName("com.mysql.jdbc.Driver");
con = DriverManager.getConnection("jdbc:mysql://localhost:3306/practiceLogin","root","Javakings21##");
stmt = con.createStatement();
rs = stmt.executeQuery("select imageID from userdatamain where userID = '1'");
if (rs.next()) {
image = rs.getBlob(1);
imgData = image.getBytes(1,(int)image.length());
}
else {
out.println("Display Blob Example");
out.println("image not found for given id>");
return;
}
// display the image
response.setContentType("image/png");
OutputStream o = response.getOutputStream();
o.write(imgData);
o.flush();
o.close();
} catch (Exception e) {
out.println("Unable To Display image");
out.println("Image Display Error=" + e.getMessage());
return;
} finally {
try {
 
stmt.close();
con.close();
} catch (SQLException e) {
e.printStackTrace();
}
}
%>-->