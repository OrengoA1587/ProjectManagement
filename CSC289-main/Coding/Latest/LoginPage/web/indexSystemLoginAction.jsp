<%-- 
    Document   : indexSystemLoginAction
    Created on : Mar 16, 2021, 8:17:09 AM
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
<%@page import="java.sql.*"%>
<%@page import="java.io.*,java.util.*"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="windows-1252">    
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">    
    <title>Dashboard - Brand</title>
    
</head>
<%
    
    HashSHA512Encryption hashText = new HashSHA512Encryption();
    int sqlInt = 0;
    //Get Current date and time   
    java.util.Date date=new java.util.Date();
    // Date and Time Check 
    Timestamp timeIn =new java.sql.Timestamp(date.getTime());
    // Starting Time Format
    String timeOut = "00:00:00";
    // Salary Time
    String salaryTime = "23:59:59";
    //Get parameters from login form
    String adminID=request.getParameter("adminID");    
    String pinNum=request.getParameter("pinNum");
    //Declare and initialize status variable
    String status = "In";    
    //Display error page if input is not a proper input
    
    if(adminID == "" || pinNum == ""){
        response.sendRedirect("notAdminError.jsp");
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
            sqlInt = 2;
            s.ReadSQL(sqlInt);
            PreparedStatement ps = con.prepareStatement(s.getSQLAll());
            ps.setString(1,adminID );
            ps.setString(2,pinNum );    
            ResultSet rs = ps.executeQuery();    
            if (rs.next()){
                sqlInt = 1;
                t.ReadTitles(sqlInt);
                session.setAttribute(t.getSQLTitles().toString(), adminID);
                session.setMaxInactiveInterval(30*60);
            }
            else{
                response.sendRedirect("notAdminError.jsp");
            }
            // Create a Prepared Statement to run query from database.
            sqlInt = 3;
            s.ReadSQL(sqlInt);            
            PreparedStatement p = con.prepareStatement(s.getSQLAll());
            // Set Strings to locations in the database.
            p.setString(1,adminID);
            p.setString(2,pinNum);
            // Iterate through database to set new fields
            ResultSet rlst = ps.executeQuery();
            if(rlst.next()){
                sqlInt = 37;
                s.ReadSQL(sqlInt);
                p = con.prepareStatement(s.getSQLAll());
                p.setString(1,adminID);
                p.setString(2,salaryTime);
                p.setString(3,salaryTime);
                p.setString(4,salaryTime);
                p.setString(5,pinNum); 
                p.setString(6,status);  
                p.setString(7,adminID);  
                p.setString(8,pinNum);
                p.executeUpdate();
                response.sendRedirect("indexMainPage.jsp");
            }     
            else{
                
                response.sendRedirect("errorUserLogin.jsp");
            }
            // Close all recently opened connections. 
            ps.close();
            rs.close();
            con.close();
        }
        catch(Exception e){     
            out.println(e); 
        } 
        
    }
%> 
</html>
