use SpringProject;


/*----------------------------------------------------------------------------*/
/*SELECT STATEMENTS*/
/*----------------------------------------------------------------------------*/


/*-------------------------SCHEMA----------------------------------------------

Policy (policy_id, policy_type)

Branches (branchID, province, city, phone, fax)

LoginInformation (loginID, userName, password, usertype)

Employees (emp_id, fname, lname, gender, dob, phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city, province, zip, branchID, salary)

Customers (driversLicense, fname, lname, gender, dob, age,  phoneNumber, streetNumber, streetName, aptNumber, bldgNumber, city,  province, zip, creditCard, policyID)

Car Types (bodyType, normalRate, branchFees, penaltyRate)

Cars (vin, licensePlate, bodyType, model, gasType, year, branchid, rentStatus)

Rental Transactions (transId, authorizingEmpID, branchID, datePaid, datePicked, dateDropped, vin,  driversLicense)

Returning (transID, destinationBranchID, empID, returnDate)



----------------------------------------------------------------------------*/
--   QUERY 1)  ---- 
--   Branch ID With The Highest Average Employee Salaries

select B.branchID, avg(salary) as [avg emp salary]
from Branches B join Employees E on (B.branchID = E.BranchID)
group by B.branchID
order by [avg emp salary] DESC


--   QUERY 2)  ---- 
--   Customers With The Highest Rental Transactions (Regular Customer)

select C.driversLicense, count(transID) as [num transID]
from Customers C join RentalTransactions R on (C.driversLicense = R.driversLicense)
group by C.driversLicense
order by [num transID] DESC

--   QUERY 3)  ---- 
--   Branch ID With The Lowest Rental Transactions 

select branchID, count(transID) as [num transID]
from RentalTransactions
group by branchID
order by [num transID] ASC


--   QUERY 4)  ---- 
--   Which Branch Location had most cars rented between [STARTING YEAR] -> [ENDING YEAR] */




--   QUERY 5)  ---- 
--  MOST RENTED CAR BETWEEN [STARTING YEAR] -> [ENDING YEAR] */


