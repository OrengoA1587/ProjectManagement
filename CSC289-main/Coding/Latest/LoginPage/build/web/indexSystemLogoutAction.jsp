<%-- 
    Document   : indexSystemLogoutAction
    Created on : Mar 16, 2021, 10:09:33 AM
    Author     : Anthony
--%>

<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadSessions"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import="java.security.NoSuchAlgorithmException"%>
<%@page import="java.security.MessageDigest"%>
<%@page import="java.math.BigInteger"%>
<%@page import="readfile.HashSHA512Encryption"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import ="java.sql.*"%>

<!DOCTYPE html>
<html>
<head>
    <meta charset="windows-1252">    
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">    
    <title>Dashboard - Brand</title>
    
</head>
<%
    ReadSessions r = new ReadSessions();
    r.getPost(request, response, session);
    
    HashSHA512Encryption hashText = new HashSHA512Encryption();
    
    int sqlInt = 0;    
    // Get Current date and time   
    java.util.Date date=new java.util.Date();
    // 
    String adminID=request.getParameter("adminID");    
    String pinNum=request.getParameter("pinNum");
    // Declare and initialize status variable
    String status = "Out";     
    // Display error page if input is null
    if(adminID == "" || pinNum == ""){
        response.sendRedirect("error.jsp");
    }
    else{
        //Make changes to the connection string(database name, user/password)
        //Make changes to the String query(change table name)
        hashText.hashText = "";
        hashText.setHashText(pinNum);
        pinNum = hashText.getHashText();
        try{
            // Create a new clean connection to database.          
            ConnectDB dbc = new ConnectDB();
            dbc.ConnectDB();
            Connection con = dbc.getConnections();
            // Create object
            ReadSQL s = new ReadSQL();
            // Create object
            ReadTitles t = new ReadTitles();
            // Clock-out of the system
            sqlInt = 38;
            s.ReadSQL(sqlInt);
            PreparedStatement ps = con.prepareStatement(s.getSQLAll());
            ps.setString(1,status);               
            ps.setString(2,adminID);           
            ps.executeUpdate();
            // String used for SQL Query
            sqlInt = 2;
            s.ReadSQL(sqlInt);
            PreparedStatement psp = con.prepareStatement(s.getSQLAll());
            psp.setString(1,adminID );
            psp.setString(2,pinNum );    
            ResultSet rs = psp.executeQuery();    
            if (rs.next()){
                t.ReadTitles(1);
                session.removeAttribute(t.getSQLTitles().toString());
                response.sendRedirect("index.jsp");              
            }
            else{
                response.sendRedirect("error.jsp");
            }
            ps.close();
            psp.close();
            rs.close();
            con.close();
            }
        catch(Exception e){     
            out.println(e); 
        }   
    }
%> 
</html>
