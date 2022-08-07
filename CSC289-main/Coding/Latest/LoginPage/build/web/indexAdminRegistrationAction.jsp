<%-- 
    Document   : indexRegistration
    Created on : Feb 2, 2021, 6:27:44 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
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
    int wrong = 3;
    int primID = 0;
    HashSHA512Encryption hashText = new HashSHA512Encryption();
    int sqlInt = 0;    
    // Long Integer for 6 digit random authorization email code.
    long eCode = Math.round(Math.random() *999999);
    // Get Parameters from previous page of user inputted information.
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
    String image="https://drive.google.com/uc?export=view&id=1dYZ2xxA1DIwNcwdEwqRypTDkc4danQos";
    String ident = "admin";
    String timeBase = "00:00:00";
    String auth = Long.toString(eCode);
    
    hashText.setHashText(password);
    password = hashText.getHashText();
    try{
        // Create object
        ReadSQL s = new ReadSQL();
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        Statement st=con.createStatement();
        // Execute SQL Code to add information to Databases
        // Run the CSV Reader Class
        sqlInt = 7;
        s.ReadSQL(sqlInt);
        st.executeUpdate(s.getSQLAll() + "('"+idNum+"','"+fname+"','"+lname+"','"+address+"','"+city+"','"+state+"','"+zipcode+"','"+mobileNo+"','"+email+"','"+password+"','"+image+"','"+ident+"','"+wrong+"','"+auth+"')");
        sqlInt = 15;
        s.ReadSQL(sqlInt);
        ResultSet rs = st.executeQuery(s.getSQLAll().toString());
        while(rs.next()){
            primID = rs.getInt("ID");
        }
        sqlInt = 8;
        s.ReadSQL(sqlInt);
        st.executeUpdate(s.getSQLAll() + "('"+idNum+"','"+fname+"','"+lname+"','"+address+"','"+city+"','"+state+"','"+zipcode+"','"+mobileNo+"','"+email+"','"+password+"','"+image+"','"+ident+"','"+primID+"')");
        sqlInt = 9;
        s.ReadSQL(sqlInt);
        st.executeUpdate(s.getSQLAll() + "('"+idNum+"','"+timeBase+"','"+timeBase+"','"+timeBase+"','"+password+"','"+"Out"+"')");
        // Show user that the information has been saved and display some
        // of that information. 
        response.sendRedirect("emailAuth.jsp");    
    }
    // Catch
    catch(Exception e){ 
        out.println(e); 
    }
    
    //,m }
%> 
</html>