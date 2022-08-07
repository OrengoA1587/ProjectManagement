<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="java.security.NoSuchAlgorithmException"%>
<%@page import="java.security.MessageDigest"%>
<%@page import="java.math.BigInteger"%>
<%@page import="java.util.Random"%>
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
    int sqlInt = 0;
    // Get Parameters from previous page of user inputted information.
    String address=request.getParameter("address");
    String city=request.getParameter("city");
    String state=request.getParameter("state");
    try{
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        // Create object
        ReadSQL s = new ReadSQL();
        // Create object
        ReadTitles t = new ReadTitles();
        // Current Admin session ID#
        t.ReadTitles(1);
        String uid = (String)session.getAttribute(t.getSQLTitles().toString());
        //Update user database info
        sqlInt = 29;
        s.ReadSQL(sqlInt);
        PreparedStatement userPS = con.prepareStatement(s.getSQLAll() + uid);
        userPS.setString(1,address);
        userPS.setString(2,city);
        userPS.setString(3,state);
        userPS.executeUpdate();
        // Update admin database info
        sqlInt = 30;
        s.ReadSQL(sqlInt);
        PreparedStatement adminPS = con.prepareStatement(s.getSQLAll() + uid);
        adminPS.setString(1,address);
        adminPS.setString(2,city);
        adminPS.setString(3,state);
        adminPS.executeUpdate();
        // Reload actions
        response.sendRedirect("profile.jsp");    
    }
    // Catch
    catch(Exception e){ 
        out.println(e); 
    }
%> 
</html>