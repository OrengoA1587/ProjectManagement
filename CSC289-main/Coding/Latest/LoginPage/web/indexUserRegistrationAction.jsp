<%-- 
    Document   : indexUserRegistration
    Created on : Feb 7, 2021, 7:21:53 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
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
    <title>Dashboard - Brand</title>    
</head> 
<%
    int wrong = 3;
    HashSHA512Encryption hashText = new HashSHA512Encryption();
    int sqlInt = 0;
    // Long Integer for 9 digit random authorization email code.
    long eCode = Math.round(Math.random() *999999);
    long eCodeTwo = Math.round(Math.random() *999);
    String idNum=request.getParameter("rand_num");    
    String fname=request.getParameter("fname");
    String lname=request.getParameter("lname");
    String address=request.getParameter("address");
    String state=request.getParameter("state");
    String city=request.getParameter("city");
    String zipcode=request.getParameter("zipcode");    
    String mobileNo=request.getParameter("mobileNo");
    String email=request.getParameter("email");
    String password=request.getParameter("password_confirm");    
    String passwordCheck=request.getParameter("password_Check");
    String image="https://drive.google.com/uc?export=view&id=1AhrTHw6xzWn-AOOxnNsPlKyZLX3l9g3i";
    String ident = "user";
    String timeBase = "00:00:00";
    String auth = Long.toString(eCode) + Long.toString(eCodeTwo);
    
    hashText.setHashText(password);
    password = hashText.getHashText();
    try{
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        // Create object
        ReadSQL s = new ReadSQL();
        
        Statement st=con.createStatement();
        // Execute SQL Code to add information to Database
        sqlInt = 10;
        s.ReadSQL(sqlInt);
        st.executeUpdate(s.getSQLAll() + "('"+idNum+"','"+fname+"','"+lname+"','"+address+"','"+city+"','"+state+"','"+zipcode+"','"+mobileNo+"','"+email+"','"+password+"','"+image+"','"+ident+"','"+wrong+"','"+auth+"')");
        // Execute SQL Code to add information to Database
        sqlInt = 11;
        s.ReadSQL(sqlInt);
        st.executeUpdate(s.getSQLAll() + "('"+idNum+"','"+timeBase+"','"+timeBase+"','"+timeBase+"','"+password+"','"+"Out"+"')");
        // Show user that the information has been saved and display some
        // of that information.
        response.sendRedirect("emailAuth.jsp");
    }
    catch(Exception e){
        out.println(e); 
    }
    //}
%>
</html>