USE ApexRestaurantDB;
CREATE TABLE Meal_Dishes( 
    Meal_Dishes_Id INT PRIMARY KEY IDENTITY(1,1),
    MealId INT ,
    Menu_Item_Id Int,
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);

INSERT INTO Meal_Dishes
 ( CreatedBy
 ,CreatedOn 
 ,UpdatedBy ,
 UpdatedOn) VALUES 

 (
     
          'sysuser',
           '2020-02-23 10:00:00.000', 
           'sysuser', 
           '2020-02-23 11:00:00.000'
    

);
SELECT * FROM Meal_Dishes;
DROP TABLE Meal_Dishes;
