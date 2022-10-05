
use Northwind

CREATE PROC spCustomerSelectALL
AS
BEGIN
SELECT * FROM Customers

END

GO

  CREATE PROC spCustomerSelectById
  (
  @CustomerID INT
  )
  AS
  BEGIN
  SELECT * FROM Customers WHERE CustomerID =@CustomerID
  END
  GO

  CREATE PROC spCustomerInser
(
    @CompanyName VARCHAR(80),
	@ContactName VARCHAR(80),
	@ContactTitle VARCHAR(80),
	@Address VARCHAR(80),
	@City VARCHAR(80),
	@Region VARCHAR(80),
	@PostalCode VARCHAR(80),
	@Country VARCHAR(80),
    @Phone VARCHAR(80),
	@Fax VARCHAR(80)

)
AS
BEGIN
INSERT INTO Customers(CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) VALUES(@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country, @Phone,@Fax)
END
GO





 CREATE PROC spCustomerUpdate
 (
    @CustomerID INT,
	@CompanyName VARCHAR(80),
	@ContactName VARCHAR(80),
	@ContactTitle VARCHAR(80),
	@Address VARCHAR(80),
	@City VARCHAR(80),
	@Region VARCHAR(80),
	@PostalCode VARCHAR(80),
	@Country VARCHAR(80),
    @Phone VARCHAR(80),
	@Fax VARCHAR(80)
)
AS
BEGIN
	UPDATE Customers SET CompanyName=@CompanyName, ContactName=@ContactName, ContactTitle=@ContactTitle, Address=@Address, City=@City, Region=@Region, PostalCode=@PostalCode, Country=@Country,  Phone= @Phone, Fax=@Fax  WHERE CustomerID=@CustomerID
END
GO

create proc spCustomerDelete
(
	@CustomerID INT
)
AS
BEGIN
	DELETE FROM Customers WHERE CustomerID=@CustomerID
END
GO

