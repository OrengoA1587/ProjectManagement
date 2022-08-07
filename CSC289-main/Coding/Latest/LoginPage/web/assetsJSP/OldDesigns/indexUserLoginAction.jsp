 
<%@page import ="java.sql.*"%>
<%@page import ="java.time.LocalDateTime"%>
<%@page import ="java.time.format.DateTimeFormatter"%>
 

<%
    //Get Current date and time   
    java.util.Date date=new java.util.Date();			
    Date sqlDate=new java.sql.Date(date.getTime());
    Timestamp timeIn =new java.sql.Timestamp(date.getTime());
    String timeOut = "00:00:00";
    //String totalTime = "00:00:00";
    //Get parameters from login form
    String userID=request.getParameter("userID");    
    String pinCode=request.getParameter("pinCode");
    //Declare and initialize status variable
    String status = "";
    
    //Display error page if input is null
    if(userID == "" || pinCode == ""){
    response.sendRedirect("error.jsp");
}
else
{
    //Make changes to the connection string(database name, user/password)
    //Make changes to the String query(change table name)
    try{
    Class.forName("com.mysql.jdbc.Driver").newInstance();
    //Connection con=DriverManager.getConnection("jdbc:mysql://sql5.freemysqlhosting.net:3306/sql5391908","sql5391908","FpyLREFiQE");
    Connection con=DriverManager.getConnection("jdbc:mysql://sql5.freemysqlhosting.net:3306/sql5391930","sql5391930","ZWDuzeTXhR");
    String query = "select * From userdatamain where userID=? && pinNum=?";
    String query2 = "update employeetimetracker set userID =?,timeIn=?,timeOut=?, pinCode=?, status=? where userID=? && pinCode=?";
    String query1 =  "select * From employeetimetracker where userID=? && pinCode=?";
    Statement st=con.createStatement();
    PreparedStatement ps = con.prepareStatement(query1);
     ps.setString(1,userID );
      ps.setString(2,pinCode );
    ResultSet rs = ps.executeQuery( );
    if(rs.next()){
        status =  rs.getString(1);
         if(status == "Out") {
         ps = con.prepareStatement(query);
         ps.setString(1,userID );
         ps.setString(2,pinCode );
         rs = ps.executeQuery(); 
   
            if (rs.next()){
        
            ps = con.prepareStatement(query2);
            ps.setString(1,userID );
            ps.setTimestamp(2,timeIn ); 
            ps.setString(3,timeOut );   
            //ps.setString(4,totalTime );   
            ps.setString(4,pinCode ); 
            ps.setString(5,status );  
            ps.setString(6,userID );  
            ps.setString(7,pinCode );        
        
            ps.executeUpdate();  
            response.sendRedirect("indexUserLogin.jsp");              
            }
            else
            {
            response.sendRedirect("error.jsp");
            }
            ps.close();
            rs.close();
            con.close();   
             
        }
        else
        {
        response.sendRedirect("error.jsp");
        }
        
    }   
    else
    {
         response.sendRedirect("error.jsp");
    }
    
    }catch(Exception e)
    {     
        out.println(e); 
    }   
}

%> 