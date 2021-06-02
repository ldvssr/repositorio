import random
import string
import cherrypy

class StringGenerator(object):
    @cherrypy.expose
    def index(self):
        return """<html>
          <head></head>
          <body>
            <p><b>Cria string aleatoriamente</b></p>
            <form method="get" action="generate">
              <input type="text" value="16" size = "6" name="length" />
              <button type="submit">Caracteres</button>
            </form>
          </body>
        </html>"""

    @cherrypy.expose
    def generate(self, length=8):
        return ''.join(random.sample(string.hexdigits, int(length)))

if __name__ == '__main__':
    cherrypy.quickstart(StringGenerator())
