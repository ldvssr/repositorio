# biblioteca XML com API SAX
import xml.sax

# classe com os métodos para manipular ficheiro XML
class LerObrasFCA(xml.sax.ContentHandler):
   def __init__(self):
      self.dados = ""
      self.nlivros = 1
      self.subtitulo = ""
      self.descricao = ""
      self.formato = ""
      self.ano = ""
      self.isbn = ""
      
   # analisa (parser) quando o elemento (obra) XML inicia
   def startElement(self, tag, attributes):
      self.dados = tag
      if tag == "obra":
         print ("Obra FCA", self.nlivros)
         titulo = attributes["titulo"]
         print ("Titulo:", titulo)
         self.nlivros = self.nlivros + 1
         
   # analisa restantes elementos
   def endElement(self, tag):
      if self.dados == "subtitulo":
         print ("Subtitulo:", self.subtitulo)
      elif self.dados == "descricao":
         print ("Descricao:", self.descricao)
      elif self.dados  == "formato":
         print ("Formato:", self.formato)
      elif self.dados  == "ano":
         print ("ano:", self.ano)
      elif self.dados  == "ISBN":
         print ("ISBN:", self.isbn)
      self.dados = ""
      
   # leitura dos caracteres (conteúdos)
   def characters(self, content):
      if self.dados == "subtitulo":
         self.subtitulo = content
      elif self.dados == "descricao":
         self.descricao = content
      elif self.dados == "formato":
         self.formato = content
      elif self.dados == "ano":
         self.ano = content
      elif self.dados == "ISBN":
         self.isbn = content
  
if ( __name__ == "__main__"):  
   # criar instancia XMLReader
   parser = xml.sax.make_parser()
   # criar instancia e aplicar ContextHandler
   ler = LerObrasFCA()
   parser.setContentHandler(ler)
   parser.parse("livrosfca.xml")
