CREATE TABLE Products(
[Name] [VARCHAR](50) ,
[Type] [VARCHAR](20) ,
[Weight] INT ,
[Description] [VARCHAR](255) NULL,
[Picture] [VARCHAR](50) ,
[Price] FLOAT ,
);

ALTER TABLE Products ADD [ProductID] int NOT NULL IDENTITY (1,1) PRIMARY KEY;

CREATE TABLE Invoices(
UserID INT ,
CreationDate DATE ,
DueDate DATE ,
FullyPaidDate DATE ,
Stat [VARCHAR](20) ,
);
ALTER TABLE Invoices ADD InvoiceID int NOT NULL IDENTITY (1,1) PRIMARY KEY;

	
CREATE TABLE UserTypes(
Name [VARCHAR](20) ,
);

ALTER TABLE UserTypes ADD UserTypeID int NOT NULL IDENTITY (1,1) PRIMARY KEY;

CREATE TABLE Users(
UserName [VARCHAR](50) ,
Name [VARCHAR](50) ,
Surname [VARCHAR](50) ,
Email [VARCHAR](100) ,
Typ INT ,
Pass [VARCHAR](255) ,
);
ALTER TABLE Users ADD UserID int NOT NULL IDENTITY (1,1) PRIMARY KEY;


ALTER TABLE Users
ADD FOREIGN KEY (Type)
REFERENCES UserTypes(UserTypeID);


CREATE TABLE Recipes(
Name [VARCHAR](50) ,
Creator INT ,
ShortDesc [VARCHAR](128) ,
FullDesc [VARCHAR](255) ,
Picture [VARCHAR](50) ,
);
ALTER TABLE Recipes ADD RecipeID int NOT NULL IDENTITY (1,1) PRIMARY KEY;

ALTER TABLE Recipes
ADD FOREIGN KEY (Creator)
REFERENCES Users(UserID);

CREATE TABLE Ingredients(
RecipeID INT ,
ProductID INT ,
Quantity INT ,
PRIMARY KEY (RecipeID, ProductID)
);

ALTER TABLE Ingredients
ADD FOREIGN KEY (RecipeID)
REFERENCES Recipes(RecipeID);

ALTER TABLE Ingredients
ADD FOREIGN KEY (ProductID)
REFERENCES Products(ProductID);

CREATE TABLE InvoiceItems(
InvoiceID INT ,
ProductID INT ,
Quantity INT ,
Discount INT ,
Total FLOAT ,
PRIMARY KEY (InvoiceID, ProductID)
);

ALTER TABLE InvoiceItems
ADD FOREIGN KEY (InvoiceID)
REFERENCES Invoices(InvoiceID);

ALTER TABLE InvoiceItems
ADD FOREIGN KEY (ProductID)
REFERENCES Products(ProductID);
