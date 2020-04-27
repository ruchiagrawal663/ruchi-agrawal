USE ApexRestaurantDB;

CREATE TABLE Staff( 
    Staff_Id INT PRIMARY KEY IDENTITY(1,1),
    Staff_Role_Code INT ,
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
     
     'remisha ', 
     'maharjan',
      'Dhalku', 
       '98686781234',
       '2020-04-27 00:00:00.000',
         1,
          'sysuser',
           '2020-04-27 10:00:00.000', 
           'sysuser', 
            '2020-04-27 10:00:00.000'
    
);

SELECT * FROM Staff;
DROP TABLE Staff;

