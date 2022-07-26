# QUESTÃO 1

import mysql.connector
conexao = mysql.connector.connect(user="root",
                                  password='Bruno1010@',
                                  host="127.0.0.1",
                                  database='')

print('Conexão:', conexao)

cursor = conexao.cursor()
sql = "CREATE DATABASE if not exists prova"
cursor.execute(sql)

conexao.close()
print("Conexão Fechada")

import mysql.connector

conexao = mysql.connector.connect(user="root",
                                    password="Bruno1010@",
                                    host='127.0.0.1',
                                    database='prova')

print('Conexão:', conexao)
cursor = conexao.cursor()

sql = """
    CREATE TABLE if not exists veiculo(
      idt INT NOT NULL,
      placa VARCHAR(45) NOT NULL,
      Preço FLOAT NOT NULL,
      Quilometragem FLOAT NOT NULL,
      Data_compra VARCHAR(45) NULL,
      PRIMARY KEY (idt)
      ) """

cursor.execute(sql)

conexao.close()
print("Conexão Fechada")

#FUNÇÕES QUE UTILIZEI

""" import mysql.connector
def cria_conexao():
    conexao = mysql.connector.connect(user='root',
                                      password='Bruno1010@',
                                      host='127.0.0.1',
                                      database='prova')
    print('Conexão:', conexao)
    return conexao


def fecha_conexao(con):
    con.close()
    print('\nConexão fechada.')


def qtd_registros(con):
    cursor = con.cursor()
    sql = ''' select * from veiculo '''
    cursor.execute(sql)
    registos = cursor.fetchall()
    print("Registros na tabela:", cursor.rowcount)


def mostra_registros(con):
    cursor = con.cursor()
    sql = ''' select * from veiculo   '''
    cursor.execute(sql)
    registros = cursor.fetchall()
    print('- Registros:')
 """

# QUESTÃO 2

from Funcoes import cria_conexao, fecha_conexao, qtd_registros

conexao = cria_conexao()

cursor = conexao.cursor()

qtd_registros(conexao)


sql = """
    insert into veiculo
    (idt, placa, preço, quilometragem, data_compra)
    values (%s, %s, %s, %s, %s)
    """
idt = int(input('ID: '))
placa = input("Placa: ")
preço = float(input('Preço: '))
quilometragem = float(input('KM: '))
data_compra = input("Data (xxxx-yy-zz):")

cursor.execute(sql, (idt, placa, preço, quilometragem,data_compra))

print('Registros inseridos:', cursor.rowcount)
conexao.commit()
cursor.close()
fecha_conexao(conexao)

# QUESTÃO 3

import mysql.connector
conexao = mysql.connector.connect(user="root",
                                    password="Bruno1010@",
                                    host='127.0.0.1',
                                    database='prova')

print('Conexão:', conexao)
cursor = conexao.cursor()
sql = '''
    select *
    from veiculo
    '''
cursor.execute(sql)
registros = cursor.fetchall()
print("Quantidade de registros na tabela:", cursor.rowcount)
print('- Carros:')
for idt, placa, preço, quilometragem, data_compra in registros:
    print("Idt:", idt)
    print("Placa:", placa)
    print("Preço:", preço)
    print("KM:", quilometragem)
    print("Data de Compra:", data_compra)
cursor.close()
conexao.close()
print('\nConexão fechada.')

# QUESTÃO 4

from Funcoes import cria_conexao, fecha_conexao, qtd_registros

conexao = cria_conexao()

cursor = conexao.cursor()

qtd_registros(conexao)


sql = '''
    update veiculo
    set preço = %s
    where placa = %s
    '''
preço = float(input('Preço que deseja alterar: '))
placa = input("Placa que deseja alterar: ")
cursor.execute(sql, (preço, placa))
print("- Registros atualizados:", cursor.rowcount)
conexao.commit()
cursor.close()
fecha_conexao(conexao)

# QUESTÃO 5

from Funcoes import cria_conexao, fecha_conexao, qtd_registros

conexao = cria_conexao()

cursor = conexao.cursor()

qtd_registros(conexao)


sql = '''
    DELETE FROM veiculo
    where placa = %s
    '''
placa= input("Placa para deletar: ")
cursor.execute(sql, (placa,))
print("- Registros apagados:", cursor.rowcount)
conexao.commit()
cursor.close()
fecha_conexao(conexao)


