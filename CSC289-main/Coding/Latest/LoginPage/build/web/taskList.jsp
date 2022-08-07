<%-- 
    Document   : taskList
    Created on : Mar 24, 2021, 8:02:20 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadSessions"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<%@page import ="java.sql.*"%>
<!DOCTYPE html>

<html>

<head>
    <%@page import ="java.sql.*"%>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Table - Brand</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assetsJSP/css/adminControl.css">
    <link rel="stylesheet" href="assetsJSP/css/todoListStyleSheet.css">  
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
</head>
<body>
<%
    ReadSessions r = new ReadSessions();
    r.getPost(request, response, session);
     
%>
 <!DOCTYPE html>
 
<div class="container"> 
    <div id="myDIV" class="header">
        <h2 >My To Do List</h2>
            <form action="taskAction.jsp" method="post">
                <%--Get Task from user--%>
                <input class="task-input" type="text" name="task" placeholder="Enter Task..."maxlength="100"> 
                
                <%--Add task to database--%>
                <button class="add-button" type="submit">Add</button>  
            </form>
                <h5>Max char (100)</h5>
    </div>
   
   <%    
    try{
        String uid = (String)session.getAttribute("adminID");
        int count = 0;
        int sqlInt = 0;
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        Statement st=con.createStatement();
        ResultSet rs=st.executeQuery("select * From admintask where adminID= ('"+uid+"')");         
    %>
     <%while(rs.next())
        {
    
            %> 
<ul id="myUL" class="list-list">   
    <form action="deleteTaskAction.jsp" method="post">   
        <table>
            <tr>
                <td>
                     <div class="form-group">
                        <%--Add task to table --%>
                        
                        <input type="text" name="task" id="admin-task-name" value="<%=rs.getString("task")%>" readonly="readonly">    
                        <button class="button-delete" type="submit" value="delete" name="delete-task">X</button>      
                    </div>                         
                </td> 
            </tr> 
        </table>
    </form>
</ul>  
<%}
}
    catch(Exception e){
        out.print(e.getMessage());%><br><%
    }
    finally{         
    }
    %>
 </div>
 <div id="wrapper">
    <nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-1">
            
            <div class="container-fluid d-flex flex-column p-0"><a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="indexAdminControl.jsp">
                    <div><img src="assetsJSP/css/images/CompanyLogo.png" height="60" width="60"></div>                    
                </a>
                <div class="sidebar-brand-text mx-2" style="color: white"><span><b>Personnel Management</b></span></div>
                <hr class="sidebar-divider my-0">
                <ul class="nav navbar-nav text-light" id="accordionSidebar">
                    <a class="nav-link active" href="indexAdminControl.jsp"><i class="fas fa-tachometer-alt"></i><span>&nbsp;&nbsp;Dashboard</span></a>
                    <a class="nav-link active" href="profile.jsp"><i class="fas fa-user"></i><span>&nbsp;&nbsp;Profile</span></a>                 
                    <a class="nav-link active" href="tableAdmin.jsp"><i class="fas fa-table"></i><span>&nbsp;&nbsp;Admin Table</span></a>
                    <a class="nav-link active" href="tableUser.jsp"><i class="fas fa-table"></i><span>&nbsp;&nbsp;Employee Table</span></a>
                    <a class="nav-link active" href="workTable.jsp"><i class="fas fa-table"></i><span>&nbsp;&nbsp;Work Table</span></a>
                    <a class="nav-link active" href="timeWorkedTable.jsp"><i class="fas fa-table"></i><span>&nbsp;&nbsp;Time Worked Table</span></a>
                    <a class="nav-link active" href="resetLockedAccount.jsp"><i class="fas fa-lock-open"></i><span>&nbsp;&nbsp;Reset Locked Account</span></a>
                    <a class="nav-link active" href="indexMainPage.jsp"><i class="far fa-user-circle"></i><span>&nbsp;&nbsp;Log out</span></a>                  
                </ul> 
            </div>
    </nav>
       <div class="d-flex flex-column" id="content-wrapper">
            <div id="content">
                <nav class="navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top">
                    <div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle mr-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button>
                        <form class="form-inline d-none d-sm-inline-block mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search">
                            <div class="input-group"><input class="bg-light form-control border-0 small" type="text" placeholder="Search for ...">
                                <div class="input-group-append"><button class="btn btn-primary py-0" type="button"><i class="fas fa-search"></i></button></div>
                            </div>
                        </form>
                        <ul class="nav navbar-nav flex-nowrap ml-auto">
                            <li class="nav-item dropdown d-sm-none no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><i class="fas fa-search"></i></a>
                                <div class="dropdown-menu dropdown-menu-right p-3 animated--grow-in" aria-labelledby="searchDropdown">
                                    <form class="form-inline mr-auto navbar-search w-100">
                                        <div class="input-group"><input class="bg-light form-control border-0 small" type="text" placeholder="Search for ...">
                                            <div class="input-group-append"><button class="btn btn-primary py-0" type="button"><i class="fas fa-search"></i></button></div>
                                        </div>
                                    </form>
                                </div>
                            </li>
                             
                             
                            <div class="d-none d-sm-block topbar-divider"></div>
                             
                        </ul>
                    </div>
                </nav>
                 
            </div>    
        </div>
 </div>

<script>
// Create a "close" button and append it to each list item
var myNodelist = document.getElementsByTagName("LI");
var i;
for (i = 0; i < myNodelist.length; i++) {
  var span = document.createElement("SPAN");
  var txt = document.createTextNode("\u00D7");
  span.className = "close";
  span.appendChild(txt);
  myNodelist[i].appendChild(span);
}

// Click on a close button to hide the current list item
var close = document.getElementsByClassName("close");
var i;
for (i = 0; i < close.length; i++) {
  close[i].onclick = function() {
    var div = this.parentElement;
    div.style.display = "none";
     
  }
}

// Add a "checked" symbol when clicking on a list item
var list = document.querySelector('ul');
list.addEventListener('click', function(ev) {
  if (ev.target.tagName === 'LI') {
    ev.target.classList.toggle('checked');
  }
}, false);
 
</script>
 
</body>
</html>
