CREATE TABLE ExportHistory(
   Id INT NOT NULL,
   Name VARCHAR (100) NOT NULL,
   Timestamp DATETIME NOT NULL,
   UserName VARCHAR (50),
   Location VARCHAR(50),
   PRIMARY KEY (ID));
