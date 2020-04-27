USE ApexRestaurantDB;

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
     'remihsa ', 
     'maharajan',
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



