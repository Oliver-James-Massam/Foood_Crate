CREATE DATABASE FoodCrateDB;

CREATE TABLE FoodCrateDB.Products(
[Name] [VARCHAR](50) ,
[Type] [VARCHAR](20) ,
[Weight] INT ,
[Description] [VARCHAR](255) NULL,
[Picture] [VARCHAR](50) ,
[Price] FLOAT ,
);

ALTER TABLE Products ADD [ProductID] int NOT NULL IDENTITY (1,1) PRIMARY KEY;

CREATE TABLE FoodCrateDB.Invoices(
InvoiceID AUTO  ,
UserID INT ,
CreationDate DATE ,
DueDate DATE ,
FullyPaidDate DATE ,
Stat [VARCHAR](20) ,
PRIMARY KEY (InvoiceID)
);

ALTER TABLE Invoices ADD InvoiceID int NOT NULL IDENTITY (1,1) PRIMARY KEY;

	
CREATE TABLE FoodCrateDB.UserTypes(
UserTypeID AUTO  ,
Name [VARCHAR](20) ,
PRIMARY KEY (UserTypeID)
);

CREATE TABLE FoodCrateDB.Users(
UserID AUTO  ,
UserName [VARCHAR](50) ,
Name [VARCHAR](50) ,
Surname [VARCHAR](50) ,
Email [VARCHAR](100) ,
Typ INT ,
Pass [VARCHAR](255) ,
PRIMARY KEY (UserID),
UNIQUE (UserName)
);

ALTER TABLE FoodCrateDB.Users
ADD FOREIGN KEY (Type)
REFERENCES UserTypes(UserTypeID);


CREATE TABLE FoodCrateDB.Recipes(
RecipeID AUTO  ,
Name [VARCHAR](50) ,
Creator INT ,
ShortDesc [VARCHAR](128) ,
FullDesc [VARCHAR](255) ,
Picture [VARCHAR](50) ,
PRIMARY KEY (RecipeID)
);

ALTER TABLE FoodCrateDB.Recipes
ADD FOREIGN KEY (Creator)
REFERENCES Users(UserID);

CREATE TABLE FoodCrateDB.Ingredients(
RecipeID INT ,
ProductID INT ,
Quantity INT ,
PRIMARY KEY (RecipeID, ProductID)
);

ALTER TABLE FoodCrateDB.Ingredients
ADD FOREIGN KEY (RecipeID)
REFERENCES Recipes(RecipeID);

ALTER TABLE FoodCrateDB.Ingredients
ADD FOREIGN KEY (ProductID)
REFERENCES Products(ProductID);

CREATE TABLE FoodCrateDB.InvoiceItems(
InvoiceID INT ,
ProductID INT ,
Quantity INT ,
Discount INT ,
Total FLOAT ,
PRIMARY KEY (InvoiceID, ProductID)
);

ALTER TABLE FoodCrateDB.InvoiceItems
ADD FOREIGN KEY (InvoiceID)
REFERENCES Invoices(InvoiceID);

ALTER TABLE FoodCrateDB.InvoiceItems
ADD FOREIGN KEY (ProductID)
REFERENCES Products(ProductID);
