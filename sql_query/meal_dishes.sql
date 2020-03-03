USE ApexRestaurantDB;
CREATE TABLE Meal_Dishes( 
    Meal_Dishes_Id INT PRIMARY KEY IDENTITY(1,1),
    MealId INT FOREIGN KEY REFERENCES Meals(Meal_Id) ,
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);