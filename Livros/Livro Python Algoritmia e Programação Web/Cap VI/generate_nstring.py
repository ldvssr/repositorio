import random
import string
import cherrypy

class StringGenerator(object):
    @cherrypy.expose
    def index(self):
        return "<h2>Hello World! I am Programming for the Web in Python</h2>"

    @cherrypy.expose
    def generate(self, n):
        return ''.join(random.sample(string.ascii_uppercase, int(n)))

if __name__ == '__main__':
    cherrypy.quickstart(StringGenerator())
