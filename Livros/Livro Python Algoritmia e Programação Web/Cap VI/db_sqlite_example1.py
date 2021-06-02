import sqlite3
conn = sqlite3.connect('produtos.db')
c = conn.cursor()

# cria tabela de dados
c.execute('''create table products
             (ref text, description text, qtd integer,
              price real, iva real, date text)''')

# Inserir (SQL Insert) novos registos de dados
c.execute("""insert into products
          values ('tab1','Tablet 7',15,149.65,0.23,'2014-03-17')""")

c.execute("""insert into products
          values ('tab2','Tablet 9',23,165.14,0.23,'2014-03-19')""")

c.execute("""insert into products
          values ('sma1','Smartphone Android',18,95.10,0.23,'2014-04-10')""")

# grava (commit) as alterações
conn.commit()

# leitura da tabela através de um cursor (registo / linha da tabela)
c = conn.cursor()
c.execute('select * from products order by price')
for row in c:
    print(row)

# close (fecha) cursor
c.close()
