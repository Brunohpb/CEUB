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
