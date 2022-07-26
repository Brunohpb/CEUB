''' QUESTÃO 1
import mysql.connector
conexao = mysql.connector.connect(user="root",
                                  password='Bruno1010@',
                                  host="127.0.0.1",
                                  database='')

print('Conexão:', conexao)

cursor = conexao.cursor()
sql = "CREATE DATABASE if not exists prova_teste"
cursor.execute(sql)

conexao.close()
print("Conexão Fechada")
'''





