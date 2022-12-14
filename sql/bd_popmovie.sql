CREATE DATABASE IF NOT EXISTS bd_popmovie;
USE bd_popmovie;

CREATE TABLE IF NOT EXISTS tb_telespectador(
    id int PRIMARY KEY AUTO_INCREMENT,
    nome varchar(40) NOT NULL,
    data_cadastro date NOT NULL,
    data_nascimento date NOT NULL,
    data_ultimo_acesso date NOT NULL,
    email varchar(60) NOT NULL,
    senha varchar(65) NOT NULL,
    total_filmes int NOT NULL,
    total_minutos int NOT NULL
);
CREATE UNIQUE INDEX uidx_temail ON tb_telespectador(email);

CREATE TABLE IF NOT EXISTS tb_administrador(
    id int PRIMARY KEY AUTO_INCREMENT,
    nome varchar(40) NOT NULL,
    email varchar(60) NOT NULL,
    senha varchar(65) NOT NULL
);
CREATE UNIQUE INDEX uidx_aemail ON tb_administrador(email);

CREATE TABLE IF NOT EXISTS tb_filme(
    id int PRIMARY KEY AUTO_INCREMENT,
    nome varchar(40) NOT NULL,
    ano_lancamento int NOT NULL,
    classificacao int NOT NULL,
    duracao_min int NOT NULL,
    genero varchar(50) NOT NULL,
    nota_imdb double NOT NULL,
    sinopse varchar(250) NOT NULL,
    diretor varchar(50) NOT NULL
);


CREATE TABLE IF NOT EXISTS tb_avaliacaofilme(
    id_avaliacao int PRIMARY KEY AUTO_INCREMENT,
    id_telespectador int NOT NULL,
    id_filme int NOT NULL,
    nota_pessoal double NOT NULL,
    comentario varchar(200),
    data_avaliacao date NOT NULL,
    FOREIGN KEY (id_telespectador) REFERENCES tb_telespectador(id) ON DELETE CASCADE,
    FOREIGN KEY (id_filme) REFERENCES tb_filme(id) ON DELETE CASCADE
);

## COMANDO PARA PEGAR DADOS DE ARQUIVO CSV E INSERIR NO BANCO
LOAD DATA INFILE 'imdb_movies.csv' ## CAMINHO DE ONDE SE ENCONTRA O ARQUIVO CSV, IDEAL ESPECIFICAR POR COMPLETO, EX: C:/../../../nomeplanilha.csv || OUTRA OPÇÃO É DEIXAR A PLANILHA DENTRO DA PASTA DO BANCO (../mysql/data/bd_popmovie/planilha.csv), PASSANDO A SER NECESSÁRIO SÓ INFORMAR O ARQUIVO DA PLANILHA SEM O CAMINHO NO COMANDO
INTO TABLE tb_filme
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED BY '\n'
IGNORE 2 lines ## Pular duas primeiras linhas da planilha
(nome, ano_lancamento, classificacao, duracao_min, genero, nota_imdb, sinopse, diretor);

## BASE DE DADOS INICIAL: https://www.kaggle.com/datasets/ramjasmaurya/top-250s-in-imdb  -> Caso acharmos melhores, podemos substituir
