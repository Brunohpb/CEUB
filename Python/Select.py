import mysql.connector
conexao = mysql.connector.connect(user="root",
                                    password="Bruno1010@",
                                    host='127.0.0.1',
                                    database='prova_teste')

print('Conexão:', conexao)
cursor = conexao.cursor()
sql = '''
    select *
    from prova_teste
    '''
cursor.execute(sql)
registros = cursor.fetchall()
print("Quantidade de registros na tabela:", cursor.rowcount)
print('- Funcionários:')
for idt, nome, salario in registros:
    print("Idt:", idt)
    print("Name:", nome)
    print("Salário:", salario)
cursor.close()
conexao.close()
print('\nConexão fechada.')