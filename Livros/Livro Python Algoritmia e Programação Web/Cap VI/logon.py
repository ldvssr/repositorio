import cherrypy
import urllib.parse

def checkauth(logonurl="/", returntopage=False):
    returnpage=''
    if returntopage:
        returnpage='?returnpage='
        + cherrypy.request.script_name
        + cherrypy.request.path_info
    auth = cherrypy.session.get('authenticated',None)
    if auth == None :
        raise cherrypy.HTTPRedirect(logonurl+returnpage)
    return auth

# classe para a manipulação da pagina HTML de autenticacao (logon)
class Logon:
    base_page = '''
    <html>
       <head>
          <script type="text/javascript" src="/jquery.js" ></script>
          <script type="text/javascript" src="/jquery-ui.js" ></script>
          <style type="text/css" title="currentStyle">
             @import "/jquerytheme.css";
             @import "/static/css/logon.css";
          </style>
       </head>
       <body id="logonscreen">
          <div id="content">
             %s
          </div>
          <script type="text/javascript">$("button").button({icons: {primary:'ui-icon-power'}})
          </script>
       </body>
    </html>
    '''
    logon_screen = base_page % '''
    <form class="login" action="%s/logon" method="GET">
       <table border = "1">
       <tr>
          <td> <label for="username">Username: </label> </td>
          <td> <input id="username" type="text" name="username" /> </td>
          <script type="text/javascript">$("#username").focus()</script>
       </tr>
       <tr>
          <td> <label for="password">Password: </label> </td>
          <td> <input id="password" type="password" name="password" /> </td>
          <input type="hidden" name="returnpage" value="%s" />
       </tr>
       </table>
       <br/>
       <button type="submit" class="login-button" value="Log in">
          Log in
       </button>
    </form>
    '''
    not_authenticated = base_page % '''<h1>Login or password not correct</h1>'''
    def __init__(self, path="/logon", authenticated="/", not_authenticated="/"):
        self.path=path
        self.authenticated=authenticated
        self.not_authenticated=not_authenticated

    # verifica user e password
    @staticmethod
    def checkpass(username,password):
        if username=='user' and password=='secret': return True
        return False

    # página inicial - localhost (/)
    @cherrypy.expose
    def index(self,returnpage=''):
        return Logon.logon_screen % (self.path,urllib.parse.quote(returnpage))
    
    @cherrypy.expose
    def logon(self,username,password,returnpage=''):
        returnpage = urllib.parse.unquote(returnpage)
        if Logon.checkpass(username,password):
            cherrypy.session['authenticated']=username
            if returnpage != '':
                raise cherrypy.InternalRedirect(returnpage)
            else:
                raise cherrypy.InternalRedirect(self.authenticated)
        raise cherrypy.InternalRedirect(self.not_authenticated)

    @cherrypy.expose
    def logoff(self,logoff):
        cherrypy.lib.sessions.expire()
        cherrypy.session['authenticated']=None
        raise cherrypy.InternalRedirect(self.not_authenticated)
