import os
import smtplib
from email.message import EmailMessage
import ntpath
EMAIL_PASSWORD = '127ht25x'
EMAIL_ADDRESS = 'jm.formacaoiefp@gmail.com'
contacts = ['ldvssr@outlook.pt','ldvssr@icloud.com']
msg = EmailMessage()
msg ['Subject'] = 'Teste!'
msg ['From'] = EMAIL_ADDRESS
msg ['To'] = ', '.join(contacts)
msg.set_content('Olá como estás?')
msg.add_alternative('''
<!DOCKTYPE html>
<html>
    <body>
        <h1 style = "color:SlateGray;">Isto é HTML!\nTudo bem?\n\n</h1?
    </body>
</html>
''', subtype = 'html'    
)
caminho = ['c:\\ola_mundo\\ola_mundo.zip','c:\\ola_mundo\\ola_mundo.txt']
for cam in caminho:
    with open(cam, 'rb') as f:
        file_data = f.read()
        file_name = f.name
        head, tail = ntpath.split(cam)
    msg.add_attachment(file_data, maintype = 'application', subtype = 'octet-stream', filename = tail)
with smtplib.SMTP_SSL('smtp.gmail.com', 465) as smtp:
    smtp.login(EMAIL_ADDRESS, EMAIL_PASSWORD)
    smtp.send_message(msg)
