USE ApexRestaurantDB;
CREATE TABLE Staff( 
    Staff_Id INT PRIMARY KEY IDENTITY(1,1),
    Staff_Role_Code INT FOREIGN KEY REFERENCES Ref_Staff_Roles(Staff_Roles_Code_Id) ,
    FirstName NVARCHAR(200), 
    LastName NVARCHAR(200), 
    Address NVARCHAR(500), 
    PhoneMob NVARCHAR(50), 
    EnrollDate DATETIME,
    IsActive BIT,
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME, 
    UpdatedBy NVARCHAR(200), 
    UpdatedOn DATETIME
);
INSERT INTO Staff
 (FirstName 
 ,LastName 
 ,Address 
 ,PhoneMob 
 ,EnrollDate 
 ,IsActive 
, CreatedBy
 ,CreatedOn 
 ,UpdatedBy ,
 UpdatedOn) VALUES 

 (
     'Megna ', 
     'Thapa',
      'Dhalku', 
       '9868135678',
       '2020-02-23 00:00:00.000',
         1,
          'sysuser',
           '2020-02-23 10:00:00.000', 
           'sysuser', 
           '2020-02-23 11:00:00.000'
    
);

SELECT * FROM Staff;



