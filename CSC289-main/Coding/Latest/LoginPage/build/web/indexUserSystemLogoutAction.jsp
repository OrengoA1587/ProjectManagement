<%-- 
    Document   : indexUserSystemLogoutAction
    Created on : Apr 26, 2021, 8:17:59 AM
    Author     : Anthony
--%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import ="java.sql.*"%>
<%@page import ="java.time.LocalDateTime"%>
<%@page import ="java.time.format.DateTimeFormatter"%>
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
    Timestamp timeOut =new java.sql.Timestamp(date.getTime());
    Timestamp totalTime =new java.sql.Timestamp(date.getTime());
    String userID=request.getParameter("userID");    
    String pinCode=request.getParameter("pinCode");    
    //Declare and initialize status variable
    String status = "Out";     
    //Display error page if input is null
    if(userID == "" || pinCode == ""){
        response.sendRedirect("error.jsp");
    }
    else{
        //Make changes to the connection string(database name, user/password)
        //Make changes to the String query(change table name)
        try{
            // Create a new clean connection to database.          
            ConnectDB dbc = new ConnectDB();
            dbc.ConnectDB();
            Connection con = dbc.getConnections();
            // Create object
            ReadTitles t = new ReadTitles();
            ReadSQL s = new ReadSQL();
            sqlInt = 5;
            s.ReadSQL(sqlInt);
            PreparedStatement ps = con.prepareStatement(s.getSQLAll());   
            ps.setTimestamp(1,timeOut);
            ps.setString(2,status);               
            ps.setString(3,userID);           
            ps.executeUpdate();
            
            t.ReadTitles(1);
            session.removeAttribute(t.getSQLTitles().toString());
            response.sendRedirect("index.jsp");            
            //Close connections
            ps.close();        
            con.close();
        }
        catch(Exception e){
            // Create object
            ReadTitles t = new ReadTitles();
            t.ReadTitles(1);
            session.removeAttribute(t.getSQLTitles().toString());
            out.println(e); 
        }   
    }
%> 
</html>