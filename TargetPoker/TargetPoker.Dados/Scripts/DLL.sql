drop database if exists `TargetPoker`;
create database if not exists `TargetPoker`;

USE TargetPoker;

drop table if exists `TipoEvento`;
create table if not exists `TipoEvento` (
 `id_tipo_evento` int not null auto_increment primary key,
 `ds_evento` varchar(60) not null
 );

drop table if exists `Evento`;
create table if not exists `Evento` (
 `id_evento` int not null auto_increment primary key,
 `id_tipo_evento` int not null,
 `ds_titulo`  varchar(50) not null,
 `ds_torneio` varchar(250) not null,
 `dt_torneio` datetime not null,
 `ds_local`   varchar(70), 
 `vl_buy_in`  decimal null,
 `vl_rake` decimal null,
 `vl_total_premiacao` decimal null,
 `qt_minima_jogador` int null,
 `qt_maxima_jogador` int null,
 foreign key (id_tipo_evento) references TipoEvento(id_tipo_evento)
);

drop table if exists `Jogador`; 
create table if not exists `Jogador` (
 `id_jogador` int not null auto_increment primary key,
 `nm_jogador` varchar(50) not null,
 `nm_sobrenome_jogador` varchar(50) not null,
 `dt_nascimento` datetime not null,
 `ds_email`   varchar(70), 
 `ds_imagem` longtext collate latin1_general_ci not null,
 `ic_target_team` bit not null 
);

drop table if exists `Torneio_Jogador`;
create table if not exists `Torneio_Jogador` (
 `id_evento` int not null, 
 `id_jogador` int not null,
 `ds_posicao_torneio` int not null,
 `qt_pontos` int not null,
 foreign key (id_evento) references Evento(id_evento),
 foreign key (id_jogador) references Jogador(id_jogador)
);