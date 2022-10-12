CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';


--STUB Bug's 

CREATE TABLE IF NOT EXISTS bugs(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  creatorId VARCHAR(255) NOT NULL,
  name VARCHAR(255) NOT NULL,
  description TEXT NOT NULL,
  priority VARCHAR(255) NOT NULL,
  following TINYINT NOT NULL DEFAULT 0,

  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';

DROP TABLE bugs;

INSERT INTO bugs
(creatorId, name, description, priority)
VALUES
('6307add455eeec07370f20c3', 'Get Items', 'Getting a 404 on get all items', 'High');

INSERT INTO bugs
(creatorId, name, description, priority)
VALUES
('6307add455eeec07370f20c3', 'Get Accounts', 'Getting a 400 when trying to get accounts', 'Mediumn');

INSERT INTO bugs
(creatorId, name, description, priority)
VALUES
('6307add455eeec07370f20c3', 'Get Items by Account id', 'Getting a 400 when trying to items on the account page', 'Low');

CREATE TABLE IF NOT EXISTS projects(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  creatorId VARCHAR(255) NOT NULL,
  name VARCHAR(255) NOT NULL,
  description TEXT NOT NULL,

  FOREIGN KEY (creatorId) REFERENCES accounts(id)
) default charset utf8 COMMENT '';

INSERT INTO projects
(creatorId, name, description )
VALUES
('6307add455eeec07370f20c3', 'Items', 'This project logs different Items');