package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import readfile.ConnectDB;
import readfile.ReadSessions;
import readfile.ReadSQL;
import readfile.ReadFile;
import java.sql.*;

public final class indexAdminControl_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("\n");
      out.write("<html>\n");
      out.write("\n");
      out.write("<head>\n");
      out.write("    <meta charset=\"utf-8\">\n");
      out.write("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, shrink-to-fit=no\">\n");
      out.write("    <meta http-equiv=\"Content-Security-Policy\" content=\"default-src;        \n");
      out.write("        script-src 'self' https://cdnjs.cloudflare.com https://fonts.gstatic.com;  ;     \n");
      out.write("        style-src 'report-sample' 'self' 'sha256-47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU='\n");
      out.write("        'sha256-z7zcnw/4WalZqx+PrNaRnoeLz/G9WXuFqV1WCJ129sg=' https://cdnjs.cloudflare.com https://fonts.googleapis.com; \n");
      out.write("        img-src 'self' data:; base-uri 'self'; object-src 'self'; \n");
      out.write("        connect-src 'self'; font-src 'self'  https://cdnjs.cloudflare.com https://fonts.gstatic.com; \n");
      out.write("        frame-src 'self';  \n");
      out.write("        manifest-src 'self'; media-src 'self';  \n");
      out.write("        worker-src 'none';\">\n");
      out.write("    <title>Admin Dashboard</title>\n");
      out.write("    <link rel=\"stylesheet\" href=\"assets/bootstrap/css/bootstrap.min.css\">\n");
      out.write("     <link rel=\"stylesheet\" href=\"assetsJSP/css/adminControl.css\">\n");
      out.write("    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\">\n");
      out.write("    <link rel=\"stylesheet\" href=\"assets/fonts/fontawesome-all.min.css\">\n");
      out.write("    <link rel=\"stylesheet\" href=\"assets/fonts/font-awesome.min.css\">\n");
      out.write("    <link rel=\"stylesheet\" href=\"assets/fonts/fontawesome5-overrides.min.css\">\n");
      out.write("    \n");
      out.write("</head>\n");
      out.write("\n");
      out.write("<body id=\"page-top\">\n");
      out.write(" \n");
      out.write("    <div id=\"wrapper\">\n");
      out.write("        <nav class=\"navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0\">\n");
      out.write("            <div class=\"container-fluid d-flex flex-column p-0\"><a class=\"navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0\" href=\"#\">\n");
      out.write("                    <div><img src=\"assetsJSP/css/images/CompanyLogo.png\" height=\"60\" width=\"60\"></div>\n");
      out.write("                    \n");
      out.write("                </a>\n");
      out.write("                <div class=\"text\"><span><b>Personnel Management</b></span></div>\n");
      out.write("                <hr class=\"sidebar-divider my-0\">\n");
      out.write("                <ul class=\"nav navbar-nav text-light\" id=\"accordionSidebar\">\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"indexAdminControl.jsp\"><i class=\"fas fa-tachometer-alt\"></i><span>Dashboard</span></a></li>\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"profile.jsp\"><i class=\"fas fa-user\"></i><span>Profile</span></a></li>     \n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"taskList.jsp\"><i class=\"fas fa-user\"></i><span>Task</span></a></li>  \n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"tableAdmin.jsp\"><i class=\"fas fa-table\"></i><span>Admin Table</span></a></li>\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"tableUser.jsp\"><i class=\"fas fa-table\"></i><span>Employee Table</span></a></li>\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"workTable.jsp\"><i class=\"fas fa-table\"></i><span>Work Table</span></a></li>\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"timeWorkedTable.jsp\"><i class=\"fas fa-table\"></i><span>Time Worked Table</span></a></li>\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"resetLockedAccount.jsp\"><i class=\"fas fa-lock-open\"></i><span>Reset Locked Account</span></a></li>\n");
      out.write("                    <li class=\"nav-item\"><a class=\"nav-link active\" href=\"indexMainPage.jsp\"><i class=\"far fa-user-circle\"></i><span>Log out</span></a></li>\n");
      out.write("                     \n");
      out.write("                </ul>\n");
      out.write("                <div class=\"text-center d-none d-md-inline\"><button class=\"btn rounded-circle border-0\" id=\"sidebarToggle\" type=\"button\"></button></div>\n");
      out.write("            </div>\n");
      out.write("            \n");
      out.write("        </nav>\n");
      out.write("        <div class=\"d-flex flex-column\" id=\"content-wrapper\">\n");
      out.write("            <div id=\"content\">\n");
      out.write("                <nav class=\"navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top\">\n");
      out.write("                    <div class=\"container-fluid\"><button class=\"btn btn-link d-md-none rounded-circle mr-3\" id=\"sidebarToggleTop\" type=\"button\"><i class=\"fas fa-bars\"></i></button>\n");
      out.write("                        <form class=\"form-inline d-none d-sm-inline-block mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search\">\n");
      out.write("                            <div class=\"input-group\"><input class=\"bg-light form-control border-0 small\" type=\"text\" placeholder=\"Search for ...\">\n");
      out.write("                                <div class=\"input-group-append\"><button class=\"btn btn-primary py-0\" type=\"button\"><i class=\"fas fa-search\"></i></button></div>\n");
      out.write("                            </div>\n");
      out.write("                        </form>\n");
      out.write("                        <ul class=\"nav navbar-nav flex-nowrap ml-auto\">\n");
      out.write("                            <li class=\"nav-item dropdown d-sm-none no-arrow\"><a class=\"dropdown-toggle nav-link\" data-toggle=\"dropdown\" aria-expanded=\"false\" href=\"#\"><i class=\"fas fa-search\"></i></a>\n");
      out.write("                                <div class=\"dropdown-menu dropdown-menu-right p-3 animated--grow-in\" aria-labelledby=\"searchDropdown\">\n");
      out.write("                                    <form class=\"form-inline mr-auto navbar-search w-100\">\n");
      out.write("                                        <div class=\"input-group\"><input class=\"bg-light form-control border-0 small\" type=\"text\" placeholder=\"Search for ...\">\n");
      out.write("                                            <div class=\"input-group-append\"><button class=\"btn btn-primary py-0\" type=\"button\"><i class=\"fas fa-search\"></i></button></div>\n");
      out.write("                                        </div>\n");
      out.write("                                    </form>\n");
      out.write("                                </div>\n");
      out.write("                            </li>\n");
      out.write("                            <li class=\"nav-item dropdown no-arrow mx-1\">\n");
      out.write("                                <div class=\"nav-item dropdown no-arrow\"><a class=\"dropdown-toggle nav-link\" data-toggle=\"dropdown\" aria-expanded=\"false\" href=\"#\"><span class=\"badge badge-danger badge-counter\">3+</span><i class=\"fas fa-bell fa-fw\"></i></a>\n");
      out.write("                                    <div class=\"dropdown-menu dropdown-menu-right dropdown-list dropdown-menu-right animated--grow-in\">\n");
      out.write("                                        <h6 class=\"dropdown-header\">alerts center</h6><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"mr-3\">\n");
      out.write("                                                <div class=\"bg-primary icon-circle\"><i class=\"fas fa-file-alt text-white\"></i></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div><span class=\"small text-gray-500\">December 12, 2019</span>\n");
      out.write("                                                <p>A new monthly report is ready to download!</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"mr-3\">\n");
      out.write("                                                <div class=\"bg-success icon-circle\"><i class=\"fas fa-donate text-white\"></i></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div><span class=\"small text-gray-500\">December 7, 2019</span>\n");
      out.write("                                                <p>$290.29 has been deposited into your account!</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"mr-3\">\n");
      out.write("                                                <div class=\"bg-warning icon-circle\"><i class=\"fas fa-exclamation-triangle text-white\"></i></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div><span class=\"small text-gray-500\">December 2, 2019</span>\n");
      out.write("                                                <p>Spending Alert: We've noticed unusually high spending for your account.</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"text-center dropdown-item small text-gray-500\" href=\"#\">Show All Alerts</a>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </li>\n");
      out.write("                            <li class=\"nav-item dropdown no-arrow mx-1\">\n");
      out.write("                                <div class=\"nav-item dropdown no-arrow\"><a class=\"dropdown-toggle nav-link\" data-toggle=\"dropdown\" aria-expanded=\"false\" href=\"#\"><i class=\"fas fa-envelope fa-fw\"></i><span class=\"badge badge-danger badge-counter\">7</span></a>\n");
      out.write("                                    <div class=\"dropdown-menu dropdown-menu-right dropdown-list dropdown-menu-right animated--grow-in\">\n");
      out.write("                                        <h6 class=\"dropdown-header\">alerts center</h6><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"dropdown-list-image mr-3\"><img class=\"rounded-circle\" src=\"assets/img/avatars/avatar4.jpeg\">\n");
      out.write("                                                <div class=\"bg-success status-indicator\"></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div class=\"font-weight-bold\">\n");
      out.write("                                                <div class=\"text-truncate\"><span>Hi there! I am wondering if you can help me with a problem I've been having.</span></div>\n");
      out.write("                                                <p class=\"small text-gray-500 mb-0\">Emily Fowler - 58m</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"dropdown-list-image mr-3\"><img class=\"rounded-circle\" src=\"assets/img/avatars/avatar2.jpeg\">\n");
      out.write("                                                <div class=\"status-indicator\"></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div class=\"font-weight-bold\">\n");
      out.write("                                                <div class=\"text-truncate\"><span>I have the photos that you ordered last month!</span></div>\n");
      out.write("                                                <p class=\"small text-gray-500 mb-0\">Jae Chun - 1d</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"dropdown-list-image mr-3\"><img class=\"rounded-circle\" src=\"assets/img/avatars/avatar3.jpeg\">\n");
      out.write("                                                <div class=\"bg-warning status-indicator\"></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div class=\"font-weight-bold\">\n");
      out.write("                                                <div class=\"text-truncate\"><span>Last month's report looks great, I am very happy with the progress so far, keep up the good work!</span></div>\n");
      out.write("                                                <p class=\"small text-gray-500 mb-0\">Morgan Alvarez - 2d</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"d-flex align-items-center dropdown-item\" href=\"#\">\n");
      out.write("                                            <div class=\"dropdown-list-image mr-3\"><img class=\"rounded-circle\" src=\"assets/img/avatars/avatar5.jpeg\">\n");
      out.write("                                                <div class=\"bg-success status-indicator\"></div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div class=\"font-weight-bold\">\n");
      out.write("                                                <div class=\"text-truncate\"><span>Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</span></div>\n");
      out.write("                                                <p class=\"small text-gray-500 mb-0\">Chicken the Dog · 2w</p>\n");
      out.write("                                            </div>\n");
      out.write("                                        </a><a class=\"text-center dropdown-item small text-gray-500\" href=\"#\">Show All Alerts</a>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                                <div class=\"shadow dropdown-list dropdown-menu dropdown-menu-right\" aria-labelledby=\"alertsDropdown\"></div>\n");
      out.write("                            </li>\n");
      out.write("                            <div class=\"d-none d-sm-block topbar-divider\"></div>\n");
      out.write("                            <li class=\"nav-item dropdown no-arrow\">\n");
      out.write("                                <div class=\"nav-item dropdown no-arrow\"><a class=\"dropdown-toggle nav-link\" data-toggle=\"dropdown\" aria-expanded=\"false\" href=\"#\"><span class=\"d-none d-lg-inline mr-2 text-gray-600 small\">Administrator</span><img class=\"border rounded-circle img-profile\" src=\"assetsJSP/css/images/iconfinder_Account_1891016.png\"></a>\n");
      out.write("                                    <div class=\"dropdown-menu shadow dropdown-menu-right animated--grow-in\"><a class=\"dropdown-item\" href=\"profile.jsp\"><i class=\"fas fa-user fa-sm fa-fw mr-2 text-gray-400\"></i>&nbsp;Profile</a><a class=\"dropdown-item\" href=\"#\"><i class=\"fas fa-cogs fa-sm fa-fw mr-2 text-gray-400\"></i>&nbsp;Settings</a><a class=\"dropdown-item\" href=\"index.jsp\"><i class=\"fas fa-list fa-sm fa-fw mr-2 text-gray-400\"></i>&nbsp;Activity log</a>\n");
      out.write("                                        <div class=\"dropdown-divider\"></div><a class=\"dropdown-item\" href=\"indexMainPage.jsp\"><i class=\"fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400\"></i>&nbsp;Logout</a>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </li>\n");
      out.write("                        </ul>\n");
      out.write("                    </div>\n");
      out.write("                </nav>\n");
      out.write("                <div class=\"container-fluid\">\n");
      out.write("                    <div class=\"d-sm-flex justify-content-between align-items-center mb-4\">\n");
      out.write("                        <h3 class=\"text-dark mb-0\">Dashboard</h3><a class=\"btn btn-primary btn-sm d-none d-sm-inline-block\" role=\"button\" href=\"#\"><i class=\"fas fa-download fa-sm text-white-50\"></i>&nbsp;Generate Report</a>\n");
      out.write("                    </div>\n");
      out.write("                    <div class=\"row\">\n");
      out.write("                        <div class=\"col-md-6 col-xl-3 mb-4\">\n");
      out.write("                            <div class=\"card shadow border-left-primary py-2\">\n");
      out.write("                                <div class=\"card-body\">\n");
      out.write("                                    <div class=\"row align-items-center no-gutters\">\n");
      out.write("                                        <div class=\"col mr-2\">\n");
      out.write("                                            <div class=\"text-uppercase text-primary font-weight-bold text-xs mb-1\"><span>Total Number of Employees</span></div>\n");
      out.write("                                            <div class=\"text-dark font-weight-bold h5 mb-0\"> \n");
      out.write("                                                ");
    
    try{
        // Create object
        ReadSQL s = new ReadSQL();
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        Statement st=con.createStatement();
        s.ReadSQL(19);
        ResultSet rs=st.executeQuery(s.getSQLAll().toString());
   
        String Countrow="";                     
        while(rs.next()){
            Countrow = rs.getString(1);
        }
              
            
      out.write("               \n");
      out.write("             <span>");
out.println("Employee Total: " +Countrow);
      out.write(" </span>      \n");
      out.write("           \n");
      out.write("    ");

    }
    
    catch(Exception e){
        out.print(e.getMessage());
    }
    finally{         
    }
    
      out.write(" </div>\n");
      out.write("                                        </div>\n");
      out.write("                                        <div class=\"col-auto\"><i class=\"fas fa-users fa-2x text-blue-300\"></i></div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div class=\"col-md-6 col-xl-3 mb-4\">\n");
      out.write("                            <div class=\"card shadow border-left-success py-2\">\n");
      out.write("                                <div class=\"card-body\">\n");
      out.write("                                    <div class=\"row align-items-center no-gutters\">\n");
      out.write("                                        <div class=\"col mr-2\">\n");
      out.write("                                            <div class=\"text-uppercase text-success font-weight-bold text-xs mb-1\"><span>Number of Employees Working</span></div>\n");
      out.write("                                            <div class=\"text-dark font-weight-bold h5 mb-0\">                                            ");
    
    try{
        
        // Create object
        ReadSQL s = new ReadSQL();
        // Create a new clean connection to database.          
        ConnectDB dbc = new ConnectDB();
        dbc.ConnectDB();
        Connection con = dbc.getConnections();
        Statement st=con.createStatement();
        // Run the SQL Reader Class
        s.ReadSQL(20);
        ResultSet rs=st.executeQuery(s.getSQLAll().toString());   
        String Countrow="";                     
        while(rs.next()){
            Countrow = rs.getString(1);        
        }
              
            
      out.write("               \n");
      out.write("             <span>");
out.println("Employee Total: " +Countrow);
      out.write(" </span>      \n");
      out.write("           \n");
      out.write("    ");

    }
    
    catch(Exception e){
        out.print(e.getMessage());
    }
    finally{         
    }
    
      out.write("<span> </span></div>\n");
      out.write("                                        </div>\n");
      out.write("                                        <div class=\"col-auto\"><i class=\"fas fa-users fa-2x text-blue-300\"></i></div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div class=\"col-md-6 col-xl-3 mb-4\">\n");
      out.write("                            <div class=\"card shadow border-left-info py-2\">\n");
      out.write("                                <div class=\"card-body\">\n");
      out.write("                                    <div class=\"row align-items-center no-gutters\">\n");
      out.write("                                        <div class=\"col mr-2\">\n");
      out.write("                                            <div class=\"text-uppercase text-info font-weight-bold text-xs mb-1\"><span>Tasks</span></div>\n");
      out.write("                                            <div class=\"row no-gutters align-items-center\">\n");
      out.write("                                                <div class=\"col-auto\">\n");
      out.write("                                                    <div class=\"text-dark font-weight-bold h5 mb-0 mr-3\"><span>50%</span></div>\n");
      out.write("                                                </div>\n");
      out.write("                                                <div class=\"col\">\n");
      out.write("                                                    <div class=\"progress progress-sm\">\n");
      out.write("                                                        <div class=\"progress-bar bg-info\" aria-valuenow=\"50\" aria-valuemin=\"0\" aria-valuemax=\"100\"><span class=\"sr-only\">50%</span></div>\n");
      out.write("                                                    </div>\n");
      out.write("                                                </div>\n");
      out.write("                                            </div>\n");
      out.write("                                        </div>\n");
      out.write("                                        <div class=\"col-auto\"><i class=\"fas fa-clipboard-list fa-2x text-blue-300\"></i></div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div class=\"col-md-6 col-xl-3 mb-4\">\n");
      out.write("                            <div class=\"card shadow border-left-warning py-2\">\n");
      out.write("                                <div class=\"card-body\">\n");
      out.write("                                    <div class=\"row align-items-center no-gutters\">\n");
      out.write("                                        <div class=\"col mr-2\">\n");
      out.write("                                            <div class=\"text-uppercase text-warning font-weight-bold text-xs mb-1\"><span>Pending Registration Requests</span></div>\n");
      out.write("                                            <div class=\"text-dark font-weight-bold h5 mb-0\"><span>18</span></div>\n");
      out.write("                                        </div>\n");
      out.write("                                        <div class=\"col-auto\"><i class=\"fas fa-comments fa-2x text-blue-300\"></i></div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
      out.write("                    <div class=\"row\">\n");
      out.write("                        <div class=\"col-lg-7 col-xl-8\">\n");
      out.write("                            <div class=\"card shadow mb-4\">\n");
      out.write("                                <div class=\"card-header d-flex justify-content-between align-items-center\">\n");
      out.write("                                    <h6 class=\"text-primary font-weight-bold m-0\">Earnings Overview</h6>\n");
      out.write("                                    <div class=\"dropdown no-arrow\"><button class=\"btn btn-link btn-sm dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\" type=\"button\"><i class=\"fas fa-ellipsis-v text-gray-400\"></i></button>\n");
      out.write("                                        <div class=\"dropdown-menu shadow dropdown-menu-right animated--fade-in\">\n");
      out.write("                                            <p class=\"text-center dropdown-header\">dropdown header:</p><a class=\"dropdown-item\" href=\"#\">&nbsp;Action</a><a class=\"dropdown-item\" href=\"#\">&nbsp;Another action</a>\n");
      out.write("                                            <div class=\"dropdown-divider\"></div><a class=\"dropdown-item\" href=\"#\">&nbsp;Something else here</a>\n");
      out.write("                                        </div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                                <div class=\"card-body\">\n");
      out.write("                                    <div class=\"chart-area\"><canvas data-bs-chart=\"{&quot;type&quot;:&quot;line&quot;,&quot;data&quot;:{&quot;labels&quot;:[&quot;Jan&quot;,&quot;Feb&quot;,&quot;Mar&quot;,&quot;Apr&quot;,&quot;May&quot;,&quot;Jun&quot;,&quot;Jul&quot;,&quot;Aug&quot;],&quot;datasets&quot;:[{&quot;label&quot;:&quot;Earnings&quot;,&quot;fill&quot;:true,&quot;data&quot;:[&quot;0&quot;,&quot;10000&quot;,&quot;5000&quot;,&quot;15000&quot;,&quot;10000&quot;,&quot;20000&quot;,&quot;15000&quot;,&quot;25000&quot;],&quot;backgroundColor&quot;:&quot;rgba(78, 115, 223, 0.05)&quot;,&quot;borderColor&quot;:&quot;rgba(78, 115, 223, 1)&quot;}]},&quot;options&quot;:{&quot;maintainAspectRatio&quot;:false,&quot;legend&quot;:{&quot;display&quot;:false},&quot;title&quot;:{},&quot;scales&quot;:{&quot;xAxes&quot;:[{&quot;gridLines&quot;:{&quot;color&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;zeroLineColor&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;drawBorder&quot;:false,&quot;drawTicks&quot;:false,&quot;borderDash&quot;:[&quot;2&quot;],&quot;zeroLineBorderDash&quot;:[&quot;2&quot;],&quot;drawOnChartArea&quot;:false},&quot;ticks&quot;:{&quot;fontColor&quot;:&quot;#858796&quot;,&quot;padding&quot;:20}}],&quot;yAxes&quot;:[{&quot;gridLines&quot;:{&quot;color&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;zeroLineColor&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;drawBorder&quot;:false,&quot;drawTicks&quot;:false,&quot;borderDash&quot;:[&quot;2&quot;],&quot;zeroLineBorderDash&quot;:[&quot;2&quot;]},&quot;ticks&quot;:{&quot;fontColor&quot;:&quot;#858796&quot;,&quot;padding&quot;:20}}]}}}\"></canvas></div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div class=\"col-lg-5 col-xl-4\">\n");
      out.write("                            <div class=\"card shadow mb-4\">\n");
      out.write("                                <div class=\"card-header d-flex justify-content-between align-items-center\">\n");
      out.write("                                    <h6 class=\"text-primary font-weight-bold m-0\">Revenue Sources</h6>\n");
      out.write("                                    <div class=\"dropdown no-arrow\"><button class=\"btn btn-link btn-sm dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\" type=\"button\"><i class=\"fas fa-ellipsis-v text-gray-400\"></i></button>\n");
      out.write("                                        <div class=\"dropdown-menu shadow dropdown-menu-right animated--fade-in\">\n");
      out.write("                                            <p class=\"text-center dropdown-header\">dropdown header:</p><a class=\"dropdown-item\" href=\"#\">&nbsp;Action</a><a class=\"dropdown-item\" href=\"#\">&nbsp;Another action</a>\n");
      out.write("                                            <div class=\"dropdown-divider\"></div><a class=\"dropdown-item\" href=\"#\">&nbsp;Something else here</a>\n");
      out.write("                                        </div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                                <div class=\"card-body\">\n");
      out.write("                                    <div class=\"chart-area\"><canvas data-bs-chart=\"{&quot;type&quot;:&quot;doughnut&quot;,&quot;data&quot;:{&quot;labels&quot;:[&quot;Direct&quot;,&quot;Social&quot;,&quot;Referral&quot;],&quot;datasets&quot;:[{&quot;label&quot;:&quot;&quot;,&quot;backgroundColor&quot;:[&quot;#4e73df&quot;,&quot;#1cc88a&quot;,&quot;#36b9cc&quot;],&quot;borderColor&quot;:[&quot;#ffffff&quot;,&quot;#ffffff&quot;,&quot;#ffffff&quot;],&quot;data&quot;:[&quot;50&quot;,&quot;30&quot;,&quot;15&quot;]}]},&quot;options&quot;:{&quot;maintainAspectRatio&quot;:false,&quot;legend&quot;:{&quot;display&quot;:false},&quot;title&quot;:{}}}\"></canvas></div>\n");
      out.write("                                    <div class=\"text-center small mt-4\"><span class=\"mr-2\"><i class=\"fas fa-circle text-primary\"></i>&nbsp;Direct</span><span class=\"mr-2\"><i class=\"fas fa-circle text-success\"></i>&nbsp;Social</span><span class=\"mr-2\"><i class=\"fas fa-circle text-info\"></i>&nbsp;Refferal</span></div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
      out.write("                                        \n");
      out.write("                    <div class=\"row\">\n");
      out.write("                        <div class=\"col-lg-6 mb-4\">                  \n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("             </div>\n");
      out.write("            <footer class=\"bg-white sticky-footer\">\n");
      out.write("                <div class=\"container my-auto\">\n");
      out.write("                <div class=\"text-center my-auto copyright\"><span>Copyright © KandOPersonnelManagementSystems.com | Designed by Jon King/Anthony Orengo</span></div>\n");
      out.write("\n");
      out.write("                </div>\n");
      out.write("            </footer>\n");
      out.write("        </div><a class=\"border rounded d-inline scroll-to-top\" href=\"#page-top\"><i class=\"fas fa-angle-up\"></i></a>\n");
      out.write("    </div>\n");
      out.write("    <script src=\"assets/js/jquery.min.js\"></script>\n");
      out.write("    <script src=\"assets/bootstrap/js/bootstrap.min.js\"></script>\n");
      out.write("    <script src=\"assets/js/chart.min.js\"></script>\n");
      out.write("    <script src=\"assets/js/bs-init.js\"></script>\n");
      out.write("    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js\"></script>\n");
      out.write("    <script src=\"assets/js/theme.js\"></script>\n");
      out.write("</body>\n");
      out.write("\n");
      out.write("</html>");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
