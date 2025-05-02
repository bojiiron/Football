use football;
create table leagues
(id int primary key,
 name varchar(50) not null);
 
 create table nationality
 (id int primary key,
 name varchar(50),
 best_player int);
 
 create table coaches
 (id int primary key, 
 name varchar(50));
 
 create table teams
 (id int primary key,
 name varchar(50) not null,
 league_id int,
 foreign key(league_id) references leagues(id),
 coaches_id int,
 foreign key(coaches_id) references coaches(id),
 trophies int not null
 );
 
 create table players
 (id int primary key,
 name varchar(50) not null,
 team_id int not null,
 foreign key(team_id) references teams(id),
 nationality_id int not null,
 foreign key(nationality_id) references nationality(id));
 
 create table player_teams
 (id int primary key,
 players_id int not null,
 foreign key(players_id) references players(id),
 team_id int not null,
 foreign key(team_id) references teams (id),
 salary int not null,
 months_active int not null
 )
 
 
 
 
 