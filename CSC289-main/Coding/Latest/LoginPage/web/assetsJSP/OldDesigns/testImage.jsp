
	
<%@page import="java.sql.Blob"%>
<%@page import="java.io.OutputStream"%>
<%@page import="java.io.InputStream"%>
<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.PreparedStatement"%>
<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.Connection"%>
<%
String id = request.getParameter("id");
 

String user = "root";
String pass = "root";
 
Connection conn = null;
 
try{
    Class.forName("com.mysql.jdbc.Driver");
    conn = DriverManager.getConnection("jdbc:mysql://sql5.freemysqlhosting.net:3306/sql5391908","sql5391908","FpyLREFiQE");
   
     PreparedStatement pst = conn.prepareStatement("select * from userdatamain where userID=?");
        pst.setString(1, id);
        ResultSet rs = pst.executeQuery();
        if(rs.next()) {     
              byte[] bytearray = new byte[4096];
              int size=0;
              InputStream sImage;
              sImage = rs.getBinaryStream(1);
              response.reset();
             
              while((size=sImage.read(bytearray))!= -1 )
                {
                    response.getOutputStream().write(bytearray,0,size);
                }
              response.flushBuffer();
              sImage.close();
              rs.close();
           }
}  
catch(Exception e){
    e.printStackTrace();
}   
finally{
    if(conn != null){
        try{
            conn.close();
        }
        catch(Exception e){
            e.printStackTrace();
        }
    }
}
%>
	
<html>
    <head>
        <title>View Image</title>
    </head>
    
    <body>
    
        <b>View | <a href="viewImage.jsp">Upload</a></b><br/><br/>
        
		<%
		id = request.getParameter("userID");
		%>
		<img src="testImage.jsp?userID=<%=id%>" width="400px"/>
 
    </body>
</html>