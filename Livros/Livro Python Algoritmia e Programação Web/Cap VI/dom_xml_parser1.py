# biblioteca XML DOM
from xml.dom.minidom import parse
import xml.dom.minidom

# abrir ficheiro XML através de um parser DOM (minidom)
DOMTree = xml.dom.minidom.parse("livrosfca.xml")
livros = DOMTree.documentElement
if livros.hasAttribute("colecao"):
   print ("Coleção : %s" % livros.getAttribute("colecao"))

# obter todos os elementos (obras/livros) da hierarquia (tree object) 
obrasfca = livros.getElementsByTagName("obra")

# Leitura e apresentacao dos detalhes dos livros 
nlivros = 1
for obr in obrasfca:
   print ("== OBRA FCA == ", nlivros)
   nlivros = nlivros + 1
   if obr.hasAttribute("titulo"):
      print ("Title: %s" % obr.getAttribute("titulo"))
   subt = obr.getElementsByTagName('subtitulo')[0]
   print ("Subtitulo: %s" % subt.childNodes[0].data)
   descr = obr.getElementsByTagName('descricao')[0]
   print ("Descrição: %s" % descr.childNodes[0].data)
   formato = obr.getElementsByTagName('formato')[0]
   print ("Formato: %s" % formato.childNodes[0].data)
   ano = obr.getElementsByTagName('ano')[0]
   print ("Ano: %s" % ano.childNodes[0].data)
   isbn = obr.getElementsByTagName('ISBN')[0]
   print ("Ano: %s" % isbn.childNodes[0].data)
