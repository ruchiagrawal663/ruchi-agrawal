USE ApexRestaurantDB;

CREATE TABLE Menus( 
    Id INT PRIMARY KEY IDENTITY(1,1),
    Menu_Name NVARCHAR(200), 
    Available_Date_From DATETIME,
    Available_Date_To DATETIME,
    IsActive BIT,
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);

INSERT INTO Menus
 (Menu_Name 
 ,Available_Date_From 
 ,Available_Date_To 
 ,IsActive 
, CreatedBy
 ,CreatedOn 
 ,UpdatedBy ,UpdatedOn) VALUES 

 (
     'Breakfast', 
     '2020-02-24 00:00:00.000',
      '2020-02-29 00:00:00.000',
         1,
          'sysuser',
           '2020-02-24 10:00:00.000', 
           'sysuser', 
           '2020-02-24 11:00:00.000'
);
SELECT * FROM Menus;

