import smtplib
my_email = 'email'
password = 'password'
with smtplib.SMTP('smtp.office365.com') as connection:
    connection.starttls()
    connection.login(user=my_email, password=password)
    connection.sendmail(from_addr=my_email,
                        to_addrs='email',
                        msg='Subject: Email de teste\n\nTestando!')
