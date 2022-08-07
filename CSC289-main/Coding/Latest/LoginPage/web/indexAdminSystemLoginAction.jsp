<%-- 
    Document   : indexAdminSystemLoginAction
    Created on : Mar 17, 2021, 5:13:35 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import="java.security.NoSuchAlgorithmException"%>
<%@page import="java.security.MessageDigest"%>
<%@page import="java.math.BigInteger"%>
<%@page import="readfile.HashSHA512Encryption"%> 
<%@page import ="java.sql.*"%>

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
    String adminID=request.getParameter("adminID");
    
    String pinNum=request.getParameter("pinNum");
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
            // Create object
            ReadSQL s = new ReadSQL();
            // Create Object
            ReadTitles t = new ReadTitles();
            // Create a new clean connection to database.          
            ConnectDB dbc = new ConnectDB();
            dbc.ConnectDB();
            Connection con = dbc.getConnections();
            // String used for SQL Query
            sqlInt = 2;
            s.ReadSQL(sqlInt);
            PreparedStatement ps = con.prepareStatement(s.getSQLAll());
            ps.setString(1,adminID );
            ps.setString(2,pinNum );    
            ResultSet rs = ps.executeQuery();    
            if (rs.next()){
                t.ReadTitles(1);
                session.setAttribute(t.getSQLTitles().toString(), adminID);
                response.sendRedirect("indexMainPage.jsp");              
            }
            else{
                response.sendRedirect("errorSystemsLogin.jsp");
            }
            ps.close();
            rs.close();
            con.close();
        }
        catch(Exception e){     
            out.println(e); 
        }   
    }
%> 
</html