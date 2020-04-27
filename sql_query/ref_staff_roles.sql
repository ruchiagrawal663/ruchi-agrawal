USE ApexRestaurantDB;
-- CREATE TABLE Ref_Staff_Roles( 
--     Staff_Roles_Code_Id INT PRIMARY KEY IDENTITY(1,1),
--     Staff_Role_Description NVARCHAR(50),
--     IsActive BIT,
--     CreatedBy NVARCHAR(200),
--     CreatedOn DATETIME, 
--     UpdatedBy NVARCHAR(200), 
--     UpdatedOn DATETIME
-- );
INSERT INTO Ref_Staff_Roles
 (Staff_Role_Description 
 ,IsActive 
, CreatedBy
 ,CreatedOn 
 ,UpdatedBy ,UpdatedOn) VALUES 

 (
    'accountant', 
         1,
          'sysuser',
           '2020-02-23 10:00:00.000', 
           'sysuser', 
           '2020-02-23 11:00:00.000'
);


SELECT * FROM  Ref_Staff_Roles;
DELETE FROM Ref_Staff_Roles;