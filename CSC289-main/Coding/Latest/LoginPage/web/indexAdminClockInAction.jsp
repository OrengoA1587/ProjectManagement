<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import ="java.sql.*"%>
<%@page import ="java.time.LocalDateTime"%>
<%@page import ="java.time.format.DateTimeFormatter"%>
<%@page import="java.security.NoSuchAlgorithmException"%>
<%@page import="java.security.MessageDigest"%>
<%@page import="java.math.BigInteger"%>
<%@page import="readfile.HashSHA512Encryption"%>
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
    int locked = 3;
    int reset = 0;
    
    //Get Current date and time   
    java.util.Date date = new java.util.Date();
    // Date and Time Check 
    Timestamp timeIn = new java.sql.Timestamp(date.getTime());
    // Starting Time Format
    String timeOut = "00:00:00";
    //
    String adminTime = "23:59:59";
    // User
    String user = "";
    //Get parameters from login form
    String adminID=request.getParameter("adminID");    
    String pinCode=request.getParameter("pinNum");
    //Declare and initialize status variable
    String status = "In";    
    //Display error page if input is not a proper input
    if(adminID == "" || pinCode == ""){
        // Go to error page
        response.sendRedirect("error.jsp");
    }
    else{
        //Reset hashText
        hashText.hashText = "";
        //Set hashText to pinCode input
        hashText.setHashText(pinCode);
        //Return hashText and set pinCode to hash
        pinCode = hashText.getHashText();
        try{
            // Create a new clean connection to database.          
            ConnectDB dbc = new ConnectDB();
            dbc.ConnectDB();
            Connection con = dbc.getConnections();
            // Create object
            ReadSQL s = new ReadSQL();
            // Create Object 
            ReadTitles t = new ReadTitles();
            // Create a Statement to run query from database.
            sqlInt = 15;
            s.ReadSQL(sqlInt);
            Statement st = con.createStatement();
            ResultSet r = st.executeQuery(s.getSQLAll().toString());
            // Read through database for user's currently inputted info
            while(r.next()){
                // User Name
                sqlInt = 2;
                t.ReadTitles(sqlInt);
                // Check for current user input info
                if(r.getString(t.getSQLTitles().toString()).equals(adminID)){
                    // Check for locked account and count.
                    sqlInt = 19;
                    t.ReadTitles(sqlInt);
                    int check = Integer.parseInt(r.getString(t.getSQLTitles().toString()));
                    if(check == locked){
                        // Alert User it is locked return to index.
                        response.sendRedirect("lockedAccount.jsp");
                    }
                    else{
                        // Check for correct pin
                        sqlInt = 11;
                        t.ReadTitles(sqlInt);
                        if(r.getString(t.getSQLTitles().toString()).equals(pinCode)){
                            // Good PIN Check
                            // Continue with clock-in process
                            sqlInt = 22;
                            s.ReadSQL(sqlInt);
                            Statement psps = con.createStatement();
                            psps.executeUpdate(s.getSQLAll().toString() + adminID);
                        }
                        else{
                            // --Bad PIN check--
                            sqlInt = 21;
                            s.ReadSQL(sqlInt);
                            Statement psps = con.createStatement();
                            psps.executeUpdate(s.getSQLAll().toString() + adminID);
                            response.sendRedirect("unacceptable.jsp");                                                
                        }
                    }
                    
                }
            }
            // Create a Prepared Statement to run query from database.
            dbc.ConnectDB();
            con = dbc.getConnections();
            sqlInt = 3;
            s.ReadSQL(sqlInt);            
            PreparedStatement p = con.prepareStatement(s.getSQLAll());
            // Set Strings to locations in the database.
            p.setString(1,adminID);
            p.setString(2,pinCode);
            // Iterate through database to set new fields
            ResultSet rlst = p.executeQuery();
            if(rlst.next()){
                t.ReadTitles(13);
                user = rlst.getString((t.getSQLTitles()));
                t.ReadTitles(22);
                if(user.contains(t.getSQLTitles().toString())){
                    sqlInt = 4;
                    s.ReadSQL(sqlInt);
                    p = con.prepareStatement(s.getSQLAll());
                    p.setString(1,adminID);
                    p.setString(2,adminTime); 
                    p.setString(3,adminTime); 
                    p.setString(4,pinCode); 
                    p.setString(5,status);  
                    p.setString(6,adminID);  
                    p.setString(7,pinCode);      
                    p.executeUpdate();
                response.sendRedirect("indexAdminLoginSuccess.jsp");              
                }
                else{
                    sqlInt = 4;
                    s.ReadSQL(sqlInt);
                    p = con.prepareStatement(s.getSQLAll());
                    p.setString(1,adminID);
                    p.setTimestamp(2,timeIn); 
                    p.setString(3,timeOut); 
                    p.setString(4,pinCode); 
                    p.setString(5,status);  
                    p.setString(6,adminID);  
                    p.setString(7,pinCode);      
                    p.executeUpdate();
                    response.sendRedirect("indexAdminLoginSuccess.jsp"); 
                }
                
            }     
            else{
                
                response.sendRedirect("errorUserLogin.jsp");
            }
            // Close all recently opened connections. 
            p.close();
            rlst.close();
            con.close();        
        }        
        catch(Exception e){
            out.println(e);
        }   
    }
%>
</html>