CREATE DATABASE TargetPoker;

USE TargetPoker;

drop table if exists `Torneio`;
create table if not exists `Torneio` (
 `id_torneio` int not null auto_increment primary key,
 `ds_torneio` varchar(50) not null,
 `dt_torneio` datetime not null,
 `ds_local`   varchar(70), 
 `vl_buy_in`  decimal not null,
 `vl_rake` decimal not null,
 `vl_total_premiacao` decimal null
);

drop table if exists `Jogador`;
create table if not exists `Jogador` (
 `id_jogador` int not null auto_increment primary key,
 `ds_nome` varchar(50) not null,
 `ds_sobrenome` varchar(50) not null,
 `dt_nascimento` datetime not null,
 `ds_email`   varchar(70), 
 `ds_imagem` longtext collate latin1_general_ci not null,
 `ic_target_team` bit null 
);

drop table if exists `Torneio_Jogadores`;
create table if not exists `Torneio_Jogadores` (
 `id_torneio` int not null, 
 `id_jogador` int not null,
 `ds_posicao_torneio` int null,
 `qt_pontos` int null,
 foreign key (id_torneio) references Torneio(id_torneio),
 foreign key (id_jogador) references Jogador(id_jogador)
);