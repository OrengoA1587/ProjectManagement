<%-- 
    Document   : timeWorked
    Created on : Feb 13, 2021, 8:05:37 PM
    Author     : Anthony
--%>
<%@page import="readfile.ConnectDB"%>
<%@page import="readfile.ReadSessions"%>
<%@page import="readfile.HashSHA512Encryption"%>
<%@page import="readfile.ReadTitles"%>
<%@page import="readfile.ReadSQL"%>
<%@page import="readfile.ReadFile"%>
<!DOCTYPE html>
<html>
<head>
    <%@page import ="java.sql.*"%>
    <%@page import ="java.time.LocalDateTime"%> 
    <%@page import ="java.time.format.DateTimeFormatter"%>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">        
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <meta http-equiv="Content-Security-Policy" content="default-src;  

        script-src 'self'  'sha256-JE0280krcqkShSI9tiB7uYMolH2Mp4kLOi+tnmU+JI4='    
        ;style-src 'report-sample' 'self' 'unsafe-inline' 
        https://cdnjs.cloudflare.com https://fonts.googleapis.com; 
        img-src 'self' data:; base-uri 'self'; object-src 'self';
        connect-src 'self'; font-src 'self' https://cdnjs.cloudflare.com https://fonts.gstatic.com; 
        frame-src 'self';
        manifest-src 'self'; media-src 'self'; 
        worker-src 'none';">
    <title>Table - Brand</title>
     
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assetsJSP/css/adminControl.css">
    <link rel="stylesheet" href="assetsJSP/css/timeWorkedTableStyleSheet.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">   
     
</head>

<body id="page-top">
<%
    ReadSessions r = new ReadSessions();
    r.getPost(request, response, session);
    int count = 0;
%>
    <div id="wrapper">
        <nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0">
            <div class="container-fluid d-flex flex-column p-0"><a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="#">
                   <div><img src="assetsJSP/css/images/CompanyLogo.png" height="60" width="60"></div>
                    
                </a>
                <div class="sidebar-brand-text mx-3" style="color: white"><span><b>Personnel Management</b></span></div>
                <hr class="sidebar-divider my-0">
                <ul class="nav navbar-nav text-light" id="accordionSidebar">
                    <li class="nav-item"><a class="nav-link active" href="indexAdminControl.jsp"><i class="fas fa-tachometer-alt"></i><span>Dashboard</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="profile.jsp"><i class="fas fa-user"></i><span>Profile</span></a></li>        
                    <li class="nav-item"><a class="nav-link active" href="taskList.jsp"><i class="fas fa-tasks"></i><span>Task</span></a></li> 
                    <li class="nav-item"><a class="nav-link active" href="tableAdmin.jsp"><i class="fas fa-table"></i><span>Admin Table</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="tableUser.jsp"><i class="fas fa-table"></i><span>Employee Table</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="workTable.jsp"><i class="fas fa-table"></i><span>Work Table</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="timeWorkedTable.jsp"><i class="fas fa-table"></i><span>Time Worked Table</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="resetLockedAccount.jsp"><i class="fas fa-lock-open"></i><span>Reset Locked Account</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="indexMainPage.jsp"><i class="far fa-user-circle"></i><span>Log out</span></a></li>                   
                     
                </ul>
                <div class="text-center d-none d-md-inline"><button class="btn rounded-circle border-0" id="sidebarToggle" type="button"></button></div>
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
                            <li class="nav-item dropdown no-arrow mx-1">
                                <div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><span class="badge badge-danger badge-counter">3+</span><i class="fas fa-bell fa-fw"></i></a>
                                    <div class="dropdown-menu dropdown-menu-right dropdown-list dropdown-menu-right animated--grow-in">
                                        <h6 class="dropdown-header">alerts center</h6><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="mr-3">
                                                <div class="bg-primary icon-circle"><i class="fas fa-file-alt text-white"></i></div>
                                            </div>
                                            <div><span class="small text-gray-500">December 12, 2019</span>
                                                <p>A new monthly report is ready to download!</p>
                                            </div>
                                        </a><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="mr-3">
                                                <div class="bg-success icon-circle"><i class="fas fa-donate text-white"></i></div>
                                            </div>
                                            <div><span class="small text-gray-500">December 7, 2019</span>
                                                <p>$290.29 has been deposited into your account!</p>
                                            </div>
                                        </a><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="mr-3">
                                                <div class="bg-warning icon-circle"><i class="fas fa-exclamation-triangle text-white"></i></div>
                                            </div>
                                            <div><span class="small text-gray-500">December 2, 2019</span>
                                                <p>Spending Alert: We've noticed unusually high spending for your account.</p>
                                            </div>
                                        </a><a class="text-center dropdown-item small text-gray-500" href="#">Show All Alerts</a>
                                    </div>
                                </div>
                            </li>
                            <li class="nav-item dropdown no-arrow mx-1">
                                <div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><i class="fas fa-envelope fa-fw"></i><span class="badge badge-danger badge-counter">7</span></a>
                                    <div class="dropdown-menu dropdown-menu-right dropdown-list dropdown-menu-right animated--grow-in">
                                        <h6 class="dropdown-header">alerts center</h6><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar4.jpeg">
                                                <div class="bg-success status-indicator"></div>
                                            </div>
                                            <div class="font-weight-bold">
                                                <div class="text-truncate"><span>Hi there! I am wondering if you can help me with a problem I've been having.</span></div>
                                                <p class="small text-gray-500 mb-0">Emily Fowler - 58m</p>
                                            </div>
                                        </a><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar2.jpeg">
                                                <div class="status-indicator"></div>
                                            </div>
                                            <div class="font-weight-bold">
                                                <div class="text-truncate"><span>I have the photos that you ordered last month!</span></div>
                                                <p class="small text-gray-500 mb-0">Jae Chun - 1d</p>
                                            </div>
                                        </a><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar3.jpeg">
                                                <div class="bg-warning status-indicator"></div>
                                            </div>
                                            <div class="font-weight-bold">
                                                <div class="text-truncate"><span>Last month's report looks great, I am very happy with the progress so far, keep up the good work!</span></div>
                                                <p class="small text-gray-500 mb-0">Morgan Alvarez - 2d</p>
                                            </div>
                                        </a><a class="d-flex align-items-center dropdown-item" href="#">
                                            <div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar5.jpeg">
                                                <div class="bg-success status-indicator"></div>
                                            </div>
                                            <div class="font-weight-bold">
                                                <div class="text-truncate"><span>Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</span></div>
                                                <p class="small text-gray-500 mb-0">Chicken the Dog � 2w</p>
                                            </div>
                                        </a><a class="text-center dropdown-item small text-gray-500" href="#">Show All Alerts</a>
                                    </div>
                                </div>
                                <div class="shadow dropdown-list dropdown-menu dropdown-menu-right" aria-labelledby="alertsDropdown"></div>
                            </li>
                            <div class="d-none d-sm-block topbar-divider"></div>
                            <li class="nav-item dropdown no-arrow">
                                <div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><span class="d-none d-lg-inline mr-2 text-gray-600 small">Administrator</span><img class="border rounded-circle img-profile" src="assetsJSP/css/images/iconfinder_Account_1891016.png"></a>
                                    <div class="dropdown-menu shadow dropdown-menu-right animated--grow-in"><a class="dropdown-item" href="profile.jsp"><i class="fas fa-user fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Profile</a><a class="dropdown-item" href="#"><i class="fas fa-cogs fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Settings</a><a class="dropdown-item" href="#"><i class="fas fa-list fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Activity log</a>
                                        <div class="dropdown-divider"></div><a class="dropdown-item" href="indexMainPage.jsp"><i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Logout</a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </nav>
                <div class="container-fluid">
                    <h3 class="text-dark mb-4">Locked Accounts</h3>
                    <div class="card shadow">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 font-weight-bold">Reset Employee Account</p>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6 text-nowrap">
                                    <div id="dataTable_length" class="dataTables_length" aria-controls="dataTable"><label>Show&nbsp;<select class="form-control form-control-sm custom-select custom-select-sm">
                                                <option value="10" selected="">10</option>
                                                <option value="25">25</option>
                                                <option value="50">50</option>
                                                <option value="100">100</option>
                                            </select>&nbsp;</label></div>
                                    
                                </div>
                                <div class="col-md-6">
                                    <div class="text-md-right dataTables_filter" id="dataTable_filter"><label><input type="search" class="form-control form-control-sm" aria-controls="dataTable" placeholder="Search"></label></div>
                                </div>
                            </div>
                             <%    
    try{
        HashSHA512Encryption hashText = new HashSHA512Encryption();
        int sqlInt = 0;
        java.util.Date date=new java.util.Date();			
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        // Create object
        ReadSQL s = new ReadSQL();
        // Create object
        ReadTitles t = new ReadTitles();
        
        Statement st=con.createStatement();
        sqlInt = 23;
        s.ReadSQL(sqlInt);
        ResultSet rs=st.executeQuery(s.getSQLAll());        
%>
                            <div class="table-responsive table mt-2" id="dataTable" role="grid" aria-describedby="dataTable_info">
                                <table class="table my-0" id="dataTable">
                                    <thead>
                                        <tr>
                                            <th>First Name</th>
                                            <th>Last Name</th>
                                            <th>User ID</th>                                             
                                            <th>Identifier</th>
                                            <th>Authorized</th>
                                            <th>Enter New PIN</th>  
                                            <th>Pin Reset</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tbody>
        <%while(rs.next()){
            count++;              
            %>               
            <tr>
                <form  action="resetLockedAccountAction.jsp" method="post">    
                <!--First Name-->
                <%t.ReadTitles(3);%>
                <td><input class="form-control" type="text" name="fname" value="<%out.print(rs.getString(t.getSQLTitles()));%>" readonly="readonly"></td>
                <!--Last Name-->
                <%t.ReadTitles(4);%>
                <td><input class="form-control" type="text" name="lname" value="<%out.print(rs.getString(t.getSQLTitles()));%>" readonly="readonly"></td>
                <!--User ID-->
                <%t.ReadTitles(2);%>                
                <td><input class="form-control" type="text" name="user_id" value="<%out.print(rs.getString(t.getSQLTitles()));%>" readonly="readonly"></td>
                <!--Identifier-->
                <%t.ReadTitles(13);%>
                <td><input class="form-control" type="text" name="identifier" value="<%out.print(rs.getString(t.getSQLTitles()));%>" readonly="readonly"></td>
                <!--Activated Account-->
                <%t.ReadTitles(20);
                if(rs.getInt(t.getSQLTitles()) != 0){
                    %><td><input class="form-control" type="text" name="authorized" value="Unauthorized" readonly="readonly"></td><%
                }
                else{
                    %><td><input class="form-control" type="text" name="authorized" value="Authorized" readonly="readonly"></td><%
                }
                %>
                <!--PIN RESET-->
                <td><div class="form-group">
                        <div class="pass-inst "><p>
                  <input class="form-stand" name="password" type="password" placeholder="Enter pin" id="plainText1"/>
                            </p></div>
                </td>
                <!--Reset-->
                <td>
                    <div class="form-group">                        
                        <input  onclick="return getConfirmation();" type="submit" value="Reset" name="Reset Time" class="btn">
                        <script type = "text/javascript">
                            function getConfirmation(){
                                var retVal = confirm("You are about to reset a PIN.\nDo you wish to continue?");
                                
                                if( retVal === true ){
                                    return true;
                                } 
                                else{
                                    return false;
                                }
                            }
                        </script>                            
                </td>
                 
            </tr>
    <%}
}
    catch(Exception e){
        out.print(e.getMessage());%><br><%
    }
    finally{         
    }
    %>
                                         
                                    </tbody>
                                </table>
                            </div>
                            <div class="row">
                                <div class="col-md-6 align-self-center">
                                    <%
                                        if(count < 10){
                                            %><p id="dataTable_info" class="dataTables_info" role="status" aria-live="polite">Showing 1 to <%out.print(count);%> of <%out.print(count);%></p><%
                                        }
                                        else{
                                            %><p id="dataTable_info" class="dataTables_info" role="status" aria-live="polite">Showing 1 to <%out.print(count);%></p><%
                                        }
                                    %>
                                </div>
                                <div class="col-md-6">
                                    <nav class="d-lg-flex justify-content-lg-end dataTables_paginate paging_simple_numbers">
                                        <ul class="pagination">
                                            <li class="page-item disabled"><a class="page-link" href="#" aria-label="Previous"><span aria-hidden="true">�</span></a></li>
                                            <li class="page-item active"><a class="page-link" href="#">1</a></li>
                                            <li class="page-item"><a class="page-link" href="#">2</a></li>
                                            <li class="page-item"><a class="page-link" href="#">3</a></li>
                                            <li class="page-item"><a class="page-link" href="#" aria-label="Next"><span aria-hidden="true">�</span></a></li>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
             <footer class="bg-white sticky-footer">
                <div class="container my-auto">
                    <div class="text-center my-auto copyright"><span>Copyright � Brand 2021</span></div>
                </div>
            </footer>
        </div><a class="border rounded d-inline scroll-to-top" href="#page-top"><i class="fas fa-angle-up"></i></a>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/chart.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
    <script src="assets/js/theme.js"></script>
</body>

</html>