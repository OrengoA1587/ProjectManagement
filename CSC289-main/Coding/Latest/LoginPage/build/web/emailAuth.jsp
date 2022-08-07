<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadEmail"%>
<%@page import="javax.mail.*"%>
<%@page import="java.util.*"%>
<%@page import="javax.mail.internet.*"%>
<%@page import="readfile.ReadSessions"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import="java.util.Random"%>
<%@page import ="java.sql.*"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%> 
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="refresh" content="1;url=save.jsp" />
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="assetsJSP/css/saveStyleSheet.css">
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
        <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
        <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css"> 
        <title>Email Authorization</title>
        <script type="text/javascript" src="jsBarcode.all.min.js"></script>
        <script type="text/javascript">
	window.history.forward();
	function noBack() { window.history.forward(); }
        </script>
    </head>  
    <body>
        <%            
            // Create objects
            ReadFile rf = new ReadFile();
            ReadEmail re = new ReadEmail();
            ReadSQL s = new ReadSQL();
            ReadTitles t = new ReadTitles();
            Properties props = new Properties();
            // Initiate Strings for email
            final String subject = "T&O Registration - Verify Email";
            String to = "";
            String userBarCode = "";
            String authCode = "";
            String greetings = "";
            // From No reply Email
            rf.ReadFile();
            String from = rf.getEmailUser().toString();
            String pass = rf.getEmailPass().toString();
            // Initiate Selection for proper SQL Statements
            int sqlInt = 0;
            // Connect to database and find the most recent ID
            try{
                // Create a new clean connection to database.          
                ConnectDB dbc = new ConnectDB();
                dbc.ConnectDB();
                Connection con = dbc.getConnections();
                // String used for SQL Query
                sqlInt = 1;
                s.ReadSQL(sqlInt);
                Statement st=con.createStatement();
                ResultSet rs = st.executeQuery(s.getSQLAll());
                // Get the info out of the database
                while(rs.next()){
                    // Authorization Number
                    sqlInt = 20;
                    t.ReadTitles(sqlInt);
                    authCode = rs.getString(t.getSQLTitles().toString());
                    // First Name
                    sqlInt = 3;
                    t.ReadTitles(sqlInt);
                    greetings = rs.getString(t.getSQLTitles().toString());
                    // User's E-Mail
                    sqlInt = 10;
                    t.ReadTitles(sqlInt);
                    to = rs.getString(t.getSQLTitles().toString());
                    // User ID
                    sqlInt = 2;
                    t.ReadTitles(sqlInt);
                    userBarCode = rs.getString(t.getSQLTitles().toString());
                }
            }
            catch(Exception e){
                out.println(e);
            }
            // Which mail server host to connect
            sqlInt = 1;
            re.ReadEmail(sqlInt);
            final String host = re.getSQLEmail().toString();
            // Simple Mail Transfer Protocol
            sqlInt = 9;
            re.ReadEmail(sqlInt);
            final String simple = re.getSQLEmail().toString();
            // Set True or False
            sqlInt = 10;
            re.ReadEmail(sqlInt);
            final String upDown = re.getSQLEmail().toString();
            // What port to connect to
            sqlInt = 11;
            re.ReadEmail(sqlInt);
            final String port = re.getSQLEmail().toString();
            // Selected user's email address stored in the database. 
            final String finalTo = to.toString();
            // No reply Email
            final String finalFrom = from;
            // No reply Email password.
            final String finalPass = pass;
            // Server host information
            sqlInt = 2;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), host);
            // Transport Protocol
            sqlInt = 3;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), simple);
            // Authorization
            sqlInt = 4;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), upDown);
            // Start TLS
            sqlInt = 5;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), upDown);
            // Email from user info
            sqlInt = 6;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), finalFrom);
            // Email from password info
            sqlInt = 7;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), finalPass);
            // Server Port
            sqlInt = 8;
            re.ReadEmail(sqlInt);
            props.put(re.getSQLEmail().toString(), port);
            // Verify the inpoutted information is accurate before sending email.
            Session mailSession = Session.getInstance(props, new javax.mail.Authenticator(){
                @Override
                protected PasswordAuthentication getPasswordAuthentication(){
                    return new PasswordAuthentication(finalFrom,finalPass);
                }
            });
            // Send confirmation email to user requesting the verification of 
            // created account so that they can start using theie account.
            try{
                // Create message to send.
                MimeMessage message = new MimeMessage(mailSession);
                // Set who the message is from.
                message.setFrom(new InternetAddress(finalFrom));
                // Add the user's email info.
                message.addRecipient(Message.RecipientType.TO,
                        new InternetAddress(finalTo));
                // Set the subject of the email. 
                message.setSubject(subject);
                // Set the message body.  
                //message.setText(finalMesseg);
                // Set the message body.
                message.setContent(""
                        + "<!DOCTYPE html>"
                        + "<html>"
                        + "<head>"
                        + "<style>"
                        + "h1   {font-size: 22px; font-family: Arial; color: #191970; text-shadow: -1px -1px 0 #000, 1px -1px 0 #000, -1px 1px 0 #000, 1px 1px 0 #000;}"
                        + "p    {font-size: 16px; font-family: Arial; color: #191970; text-shadow: -1px -1px 0 #000, 1px -1px 0 #000, -1px 1px 0 #000, 1px 1px 0 #000;}"
                        + "</style>"
                        + "</head>"
                        + "<body>"
                        + "<h1><center>K&O Personnel Management Systems - Verify Email</center></h1>"
                        + "<p>Hello "+ greetings +", <br>"
                        + "This e-mail confirms that you created your K&O Personnel Management Systems account a short time ago. "
                        + "Before you can continue any actions with your account, please click "
                        + "<a href='https://kandopersonnelmanagementsystems.com/activateAccount.jsp'>here</a> to activate your account."
                        + "The information provided below is what you will need to complete your registration.</p>"
                        + "<p>" + greetings + "'s Activation Code: <b>" + authCode + "</b></p>"
                        + "<p>If you have any issues or concerns with your registration, please contact your supervisor.</p>"
                        + "<p>Sincerely, <br> K&O Personnel Management Systems</p>"
                        + "</body>"
                        + "</html>",
                        "text/html");
                // Attempt to send email
                Transport.send(message);                
            }
            catch(MessagingException mex){
                mex.printStackTrace();
            }
            // Return to print out page. 
            response.sendRedirect("save.jsp");                        
%>
    </body>
</html>