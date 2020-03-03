USE ApexRestaurantDB;
CREATE TABLE Menu_items( 
    Menu_Item_Id INT PRIMARY KEY IDENTITY(1,1),
    MenuId INT FOREIGN KEY REFERENCES Menus(Id) ,
    Menu_Item_Name NVARCHAR(50),
    Other_Details NVARCHAR(100),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);

