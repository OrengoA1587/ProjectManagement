<%-- 
    Document   : indexUserRegistration
    Created on : Feb 7, 2021, 7:21:53 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="java.security.NoSuchAlgorithmException"%>
<%@page import="java.security.MessageDigest"%>
<%@page import="java.math.BigInteger"%>
<%@page import="readfile.HashSHA512Encryption"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import="java.util.Random"%>
<%@page import ="java.sql.*"%>
<%@page import ="com.itextpdf.text.pdf.BarcodeEAN"%>
<%@page import ="java.io.FileOutputStream"%>
<%@page import ="java.io.IOException"%>
<%@page import ="java.util.Random"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="windows-1252">    
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">    
    <title>Activate Action</title>    
</head> 
<%
    int wrong = 0;
    int sqlInt = 0;
    String resetAuth = "0";
    String authNum=request.getParameter("activate");
    try{
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        // Create object
        ReadSQL s = new ReadSQL();
        // Create object
        ReadTitles t = new ReadTitles();
        
        sqlInt = 36;
        s.ReadSQL(sqlInt);
        PreparedStatement ps = con.prepareStatement(s.getSQLAll());
        ps.setString(1,authNum);    
        ResultSet rs = ps.executeQuery();        
        if (rs.next()){
            t.ReadTitles(1);        
            //Update user database info
            sqlInt = 35;
            s.ReadSQL(sqlInt);
            PreparedStatement userPS = con.prepareStatement(s.getSQLAll() + authNum);
            userPS.setInt(1,wrong);
            userPS.setString(2,resetAuth);
            userPS.executeUpdate();
            // Reload actions
            response.sendRedirect("authSuccess.jsp");
        }
        else{
            response.sendRedirect("authFail.jsp");
        }        
    }
    // Catch
    catch(Exception e){ 
        out.println(e); 
        response.sendRedirect("authFail.jsp");
    }
%>
</html>