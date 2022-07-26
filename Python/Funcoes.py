import mysql.connector
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
