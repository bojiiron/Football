-- Въвеждане на примерни данни за таблиците в базата данни "football"
use football;
-- leagues

INSERT INTO leagues (id, name) VALUES
(1, 'Premier League'),
(2, 'La Liga'),
(3, 'Serie A'),
(4, 'Bundesliga'),
(5, 'Ligue 1'),
(6, 'Eredivisie'),
(7, 'Primeira Liga'),
(8, 'Russian Premier League'),
(9, 'Turkish Super Lig'),
(10, 'Belgian Pro League'),
(11, 'Scottish Premiership'),
(12, 'Swiss Super League'),
(13, 'Austrian Bundesliga'),
(14, 'Greek Super League'),
(15, 'Ukrainian Premier League');

-- nationality
INSERT INTO nationality (id, name, best_player) VALUES
(1, 'England', 23),
(2, 'Spain', 28),
(3, 'Italy', 3),
(4, 'Germany', 17),
(5, 'France', 5),
(6, 'Netherlands', 20),
(7, 'Portugal', 7),
(8, 'Russia', 8),
(9, 'Turkey', 9),
(10, 'Belgium', 16),
(11, 'Scotland', 11),
(12, 'Switzerland', 26),
(13, 'Austria', 13),
(14, 'Greece', 14),
(15, 'Ukraine', 15);

-- coaches
INSERT INTO coaches (id, name) VALUES
(1, 'Pep Guardiola'),
(2, 'Zinedine Zidane'),
(3, 'Antonio Conte'),
(4, 'Jurgen Klopp'),
(5, 'Thomas Tuchel'),
(6, 'Diego Simeone'),
(7, 'Jose Mourinho'),
(8, 'Carlo Ancelotti'),
(9, 'Julian Nagelsmann'),
(10, 'Mauricio Pochettino'),
(11, 'Brendan Rodgers'),
(12, 'Marcelo Bielsa'),
(13, 'Unai Emery'),
(14, 'Ralph Hasenhüttl'),
(15, 'Roberto Mancini'),
(16, 'Erik ten Hag'),
(17, 'Graham Potter'),
(18, 'Massimiliano Allegri'),
(19, 'Luciano Spalletti'),
(20, 'Hansi Flick');

-- teams
INSERT INTO teams (id, name, league_id, coaches_id, trophies) VALUES
(1, 'Manchester City', 1, 1, 10),
(2, 'Real Madrid', 2, 2, 20),
(3, 'Inter Milan', 3, 3, 15),
(4, 'Bayern Munich', 4, 4, 30),
(5, 'Paris Saint-Germain', 5, 5, 25),
(6, 'Ajax', 6, 6, 35),
(7, 'FC Porto', 7, 7, 29),
(8, 'Zenit St. Petersburg', 8, 8, 18),
(9, 'Galatasaray', 9, 9, 22),
(10, 'Club Brugge', 10, 10, 16),
(11, 'Celtic', 11, 11, 51),
(12, 'Basel', 12, 12, 20),
(13, 'Red Bull Salzburg', 13, 13, 15),
(14, 'Olympiacos', 14, 14, 47),
(15, 'Shakhtar Donetsk', 15, 15, 23),
(16, 'Sevilla', 2, 2, 17),
(17, 'Borussia Dortmund', 4, 4, 25),
(18, 'Lyon', 5, 5, 18),
(19, 'Benfica', 7, 7, 37),
(20, 'Barcelona', 2, 2, 26);

-- players
INSERT INTO players (id, name, team_id, nationality_id) VALUES
(1, 'Kevin De Bruyne', 1, 1),
(2, 'Karim Benzema', 2, 2),
(3, 'Lautaro Martinez', 3, 3),
(4, 'Robert Lewandowski', 4, 4),
(5, 'Neymar Jr.', 5, 5),
(6, 'Dusan Tadic', 6, 6),
(7, 'Pepe', 7, 7),
(8, 'Malcom', 8, 8),
(9, 'Arda Turan', 9, 9),
(10, 'Simon Mignolet', 10, 10),
(11, 'Callum McGregor', 11, 11),
(12, 'Xherdan Shaqiri', 12, 12),
(13, 'Patson Daka', 13, 13),
(14, 'Kostas Fortounis', 14, 14),
(15, 'Mykola Matvienko', 15, 15),
(16, 'Eden Hazard', 2, 10),
(17, 'Marco Reus', 17, 4),
(18, 'Mauro Icardi', 5, 3),
(19, 'Joao Felix', 7, 7),
(20, 'Hakim Ziyech', 6, 6),
(21, 'Thiago Silva', 5, 5),
(22, 'Timo Werner', 4, 4),
(23, 'Raheem Sterling', 1, 1),
(24, 'Sadio Mané', 4, 4),
(25, 'James Maddison', 11, 1),
(26, 'Wilfried Zaha', 11, 12),
(27, 'Frenkie de Jong', 20, 6),
(28, 'Pedri', 20, 2),
(29, 'Ansu Fati', 20, 2),
(30, 'Gavi', 20, 2);

-- player_teams 

INSERT INTO player_teams (id, players_id, team_id, salary, months_active) VALUES
(1, 1, 2, 250000.00, 60),
(2, 1, 1, 200000.00, 36),  -- Kevin De Bruyne първо е играл в отбор 2, а после в отбор 1
(3, 2, 2, 300000.00, 120),
(4, 3, 3, 200000.00, 48),
(5, 4, 4, 350000.00, 96),
(6, 5, 5, 450000.00, 84),
(7, 6, 6, 180000.00, 72),
(8, 7, 7, 100000.00, 36),
(9, 8, 8, 120000.00, 40),
(10, 9, 9, 110000.00, 30),
(11, 10, 10, 90000.00, 50),
(12, 11, 11, 85000.00, 60),
(13, 12, 12, 95000.00, 54),
(14, 13, 13, 80000.00, 42),
(15, 14, 14, 105000.00, 55),
(16, 15, 15, 95000.00, 70),
(17, 16, 16, 250000.00, 110),
(18, 16, 2, 200000.00, 40),  -- Eden Hazard първо е играл в отбор 16, а после в отбор 2
(19, 17, 17, 240000.00, 100),
(20, 18, 5, 220000.00, 90),
(21, 19, 7, 300000.00, 85),
(22, 20, 6, 180000.00, 75),
(23, 21, 5, 400000.00, 100),
(24, 22, 4, 230000.00, 80),
(25, 23, 1, 270000.00, 95),
(26, 24, 4, 300000.00, 100),
(27, 25, 11, 150000.00, 60),
(28, 26, 11, 120000.00, 55),
(29, 27, 20, 250000.00, 70),
(30, 28, 20, 300000.00, 65),
(31, 29, 20, 210000.00, 60),
(32, 30, 20, 200000.00, 55);

