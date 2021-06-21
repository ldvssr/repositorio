
import cherrypy

class HelloWorld(object):
    @cherrypy.expose
    def index(self):
        return  "Hello world! I am programming in Python for the Web"

if __name__ == '__main__':
   cherrypy.quickstart(HelloWorld())
