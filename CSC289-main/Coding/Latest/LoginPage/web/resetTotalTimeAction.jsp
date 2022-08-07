<%-- 
    Document   : resetTotalTimeAction
    Created on : Feb 13, 2021, 8:02:32 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import ="java.sql.*"%>
<%@page import ="java.time.LocalDateTime"%>
<%@page import ="java.time.format.DateTimeFormatter"%>
<%@page import ="javax.swing.*"%>
<%@page import ="javax.swing.JOptionPane"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="windows-1252">    
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">    
    <title>Dashboard - Brand</title>    
</head>
<%
    int sqlInt = 0;
    //Get Current date and time   
    java.util.Date date=new java.util.Date();			
    Date sqlDate=new java.sql.Date(date.getTime());    
    String totalTime = "00:00:00";  

    //Make changes to the connection string(database name, user/password)
    //Make changes to the String query(change table name)
    try{
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        // Create object
        ReadSQL s = new ReadSQL();
        // Create a Statement to run query from database.
        sqlInt = 18;
        s.ReadSQL(sqlInt);
        PreparedStatement ps = con.prepareStatement(s.getSQLAll().toString());
        // Execute & Update Current SQL Statement
        ps.executeUpdate();
        
        response.sendRedirect("indexAdminControl.jsp");
        ps.close();     
        con.close();
    
    }
    catch(Exception e){     
        out.println(e); 
    } 
%>
</html>