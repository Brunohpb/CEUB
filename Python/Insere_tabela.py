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
      Data_fabricacao DATE NOT NULL,
      Data_compra DATE NULL,
      PRIMARY KEY (idt)
      ) """

cursor.execute(sql)

conexao.close()
print("Conexão Fechada")