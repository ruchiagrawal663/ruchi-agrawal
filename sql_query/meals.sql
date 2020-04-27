USE ApexRestaurantDB;
CREATE TABLE Meals( 
    Meal_Id INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT FOREIGN KEY REFERENCES Customers(Id) ,
    StaffId INT FOREIGN KEY REFERENCES Staff(Staff_Id) ,
     Date_of_Meal DATETIME,
    Cost_of_Meal NVARCHAR(50),
     CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);

INSERT INTO Meals
 ( Date_of_Meal 
 ,Cost_of_Meal  
, CreatedBy
 ,CreatedOn 
 ,UpdatedBy ,
 UpdatedOn) VALUES 

 (
     '2020-02-23 10:00:00.000',
     '800',
          'sysuser',
           '2020-02-23 10:00:00.000', 
           'sysuser', 
           '2020-02-23 11:00:00.000'
    
);

SELECT * FROM Meals;