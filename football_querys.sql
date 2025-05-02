-- 1. Извличане на всички отбори (имена, имена на треньори), които играят в Лига 1. 
use football;
select t.name, c.name 
from teams t
join coaches c on t.coaches_id = c.id
join leagues l on t.league_id = l.id
where l.name = 'ligue 1';

-- 2. Изведете броя на играчите, които са с националност: England. 
use football;
select n.name,  count(p.id) as 'count football player'
from players p
join nationality n on p.nationality_id = n.id 
where p.nationality_id = 1;

-- 3. Списък на всички футболисти (имена на футболист, име на отбор, брой месеци), които са играли най-малко в текущия си отбор. 
use football;
select p.name, t.name as 'team', pt.months_active
from player_teams pt
join players p on pt.players_id = p.id
join teams t on t.id = pt.team_id
where pt.months_active = 
(select pk.months_active 
 from player_teams pk
 where p.team_id=pk.team_id
order by pk.salary limit 1);

-- 4. Имената на футболиста и отбора, в който играе, който е с най-висока заплата (да се изведат всички). 
use football;
select pt.salary, p.name, t.name as 'team'
from player_teams pt
join players p on pt.players_id = p.id
join teams t on t.id = pt.team_id
where pt.salary = (select pk.salary from player_teams pk
order by pk.salary desc limit 1);

-- 5. Извличане на топ 5 футболиста (име на футболист, име на отбор, заплата) с най-високи заплати. 

use football;
select pt.salary, p.name, t.name as 'team'
from player_teams pt
join players p on pt.players_id = p.id
join teams t on t.id = pt.team_id
order by pt.salary desc limit 5;

-- 6. Извличане данните за най-добрите играчи от всички националности и заплатата, която получават. 

use football;
select p.name, n.name as 'nationality', pt.salary
from players p 
join nationality n on n.best_player = p.id
join player_teams pt on pt.players_id = p.id;
