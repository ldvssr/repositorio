import smtplib
my_email = '3345068@formacao.iefp.pt'
password = 'iEFP27021987'
with smtplib.SMTP('smtp.office365.com') as connection:
    connection.starttls()
    connection.login(user=my_email, password=password)
    connection.sendmail(from_addr=my_email,
                        to_addrs='ldvssr@icloud.com',
                        msg='Subject: Email de teste\n\nTestando!')
