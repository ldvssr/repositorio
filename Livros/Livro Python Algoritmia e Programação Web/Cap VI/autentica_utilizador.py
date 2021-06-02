import cherrypy
import logon
class Root(object):
    logon = logon.Logon(path="/logon", authenticated="/",
            not_authenticated="/erroant")
    @cherrypy.expose
    def index(self):
        username=logon.checkauth('/logon')
        return '''
               <html>
                 <body>
                      <p><h2>Utilizador autenticado: </h2><h2>%s</h2></p>
                 </body>
               </html>'''%username
    
    @cherrypy.expose
    def erroant(self):
        return '''
               <html>
                  <body>
                    <h1>Conta não autenticada, volte mais tarde !!!.</h1>
                  </body>
               </html>'''
    
    @cherrypy.expose
    def somepage(self):
        username=logon.checkauth('/logon',returntopage=True)
        return '''
               <html>
                 <body>
                    <h1>Conta autenticada.</h1>
                 </body>
               </html>'''

if __name__ == "__main__":
    import os.path 
    current_dir = os.path.dirname(os.path.abspath(__file__))
    
    cherrypy.quickstart(Root(),config={'/': {'tools.sessions.on': True }})
