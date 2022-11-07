﻿using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopMovie
{
    public class BancoDeDados
    {
        private string dadosConexao;

        public BancoDeDados()
        {
            dadosConexao = @"server=127.0.0.1;uid=root;pwd=;database=bd_popmovie;ConnectionTimeout=1";
            //dadosConexao = @"server=127.0.0.1;uid=root;pwd=ifsp@MySql21;database=bd_lp2;ConnectionTimeout=1";
        }
        public void cadastroUsuario(Usuario usuario)
        {
            MySqlConnection connectionBD = null;
            MySqlCommand cmdInsert = null;
            try
            {

                connectionBD = new MySqlConnection(dadosConexao);

                //abre a conexão com o banco
                connectionBD.Open();

                // Executa um comando INSERT para inserir um registro na tabela 'Funcionario'
                // Como o INSERT não retorna valores, devemos executar o comando 'ExecuteNonQuery'
                cmdInsert = new MySqlCommand();

                //atribui uma conexão ao comando (obrigatório)
                cmdInsert.Connection = connectionBD;

                //seta o comando sql que será executado
                cmdInsert.CommandText = "INSERT INTO tb_usuario (nome, data_cadastro, data_nascimento, email, senha)" +
                                    "VALUES ( @nome, @dataCadastro, @dataNascimento, @email, @senha)";

                //seta os parametros que deverão ser passados para a consulta sql
                cmdInsert.Parameters.AddWithValue("nome", usuario.getNome());
                cmdInsert.Parameters.AddWithValue("dataCadastro", usuario.getDataCadastro());
                cmdInsert.Parameters.AddWithValue("dataNascimento", usuario.getDataNascimento());
                cmdInsert.Parameters.AddWithValue("email", usuario.getEmail());
                cmdInsert.Parameters.AddWithValue("senha", usuario.getSenha());

                //executa o comando / consulta sql
                cmdInsert.ExecuteNonQuery();

            }
            finally
            {
                //libera a memória utilizada pelos comandos
                if (cmdInsert != null) cmdInsert.Dispose();
                //fecha a conexão com o banco!
                if (connectionBD != null) connectionBD.Close();
            }
        }

    }
}
