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
    String fname=request.getParameter("first_name");
    String lname=request.getParameter("last_name");
    String mobileNo=request.getParameter("phone");
    String email=request.getParameter("email");
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
        sqlInt = 27;
        s.ReadSQL(sqlInt);
        PreparedStatement userPS = con.prepareStatement(s.getSQLAll() + uid);
        userPS.setString(1,fname);
        userPS.setString(2,lname);
        userPS.setString(3,mobileNo);
        userPS.setString(4,email);
        userPS.executeUpdate();
        // Update admin database info
        sqlInt = 28;
        s.ReadSQL(sqlInt);
        PreparedStatement adminPS = con.prepareStatement(s.getSQLAll() + uid);
        adminPS.setString(1,fname);
        adminPS.setString(2,lname);
        adminPS.setString(3,mobileNo);
        adminPS.setString(4,email);
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