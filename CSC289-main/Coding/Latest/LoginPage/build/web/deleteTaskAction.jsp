<%-- 
    Document   : deleteTaskAction
    Created on : Mar 29, 2021, 7:44:41 AM
    Author     : Anthony
--%>

<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadSessions"%>
<%@page import="java.sql.*"%>
<%@page import="com.itextpdf.text.pdf.BarcodeEAN"%>
<%@page import="java.io.FileOutputStream"%>
<%@page import="java.io.IOException"%>
<%@page import="java.util.Random"%>
<%@page import="readfile.HashSHA512Encryption"%>
<%@page import="readfile.ReadFile"%>
<%@page import="readfile.ReadSQL"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="windows-1252">    
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">    
    <title>K & O Tracks</title>    
</head>
<%
    ReadSessions r = new ReadSessions();
    r.getPost(request, response, session);
    HashSHA512Encryption hashText = new HashSHA512Encryption();
    int sqlInt = 0;
    // Get Parameters from previous page of user inputted information.
    String task=request.getParameter("task"); 
    
    String uid = (String)session.getAttribute("adminID");
 
    try{
        PreparedStatement pst = null;
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        //Statement st=con.createStatement();
        
        String query = "DELETE FROM admintask WHERE adminID = ? && task = ?";      
        pst = con.prepareStatement(query);        
        pst.setString(1,uid);
        pst.setString(2,task);
        pst.executeUpdate();              
        response.sendRedirect("taskList.jsp");  
    }    
    // Catch
    catch(Exception e){ 
        out.println(e); 
    } 
%> 
</html>