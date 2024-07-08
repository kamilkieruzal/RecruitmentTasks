CREATE TABLE ExportHistory( 
   Id   INT              NOT NULL, 
   Name VARCHAR (100)     NOT NULL, 
   Timestamp  DATETIME   NOT NULL, 
   UserName  CHAR (50), 
   Location   CHAR(50),        
   PRIMARY KEY (ID));