 
<%@page import ="java.sql.*"%>
<%
    String name=request.getParameter("name");
    String mobileNo=request.getParameter("mobileNo");
    String email=request.getParameter("email");
    String password=request.getParameter("password");

try{
    Class.forName("com.mysql.jdbc.Driver");
    Connection con=DriverManager.getConnection("jdbc:mysql://sql5.freemysqlhosting.net:3306/sql5391908","sql5391908","FpyLREFiQE");
    Statement st=con.createStatement();
    st.executeUpdate("insert into userdatamain(name,mobileNo,email,pinNum)values('"+name+"','"+mobileNo+"','"+email+"','"+password+"')");
    response.sendRedirect("save.jsp");
    
}catch(Exception e){
    
    
   out.println(e); 
}
 

%> 