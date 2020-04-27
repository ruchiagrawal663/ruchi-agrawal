USE ApexRestaurantDB;
CREATE TABLE Menu_items( 
    Menu_Item_Id INT PRIMARY KEY IDENTITY(1,1),
    MenuId INT  ,
    Menu_Item_Name NVARCHAR(50),
    Other_Details NVARCHAR(100),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);

INSERT INTO Menu_items
 (Menu_Item_Name
 ,Other_Details 
, CreatedBy
 ,CreatedOn 
 ,UpdatedBy ,UpdatedOn) VALUES 

 (
     'sandwich', 
     'cheese grilled sandwich',
          'sysuser',
            '2020-04-27 00:00:00.000', 
           'sysuser', 
            '2020-04-27 00:00:00.000'
);
 SELECT * FROM Menu_items;
 DROP TABLE Menu_items;