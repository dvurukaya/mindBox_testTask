CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
	"ProductName" TEXT
);
	
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
	"CategoryName" TEXT
);

CREATE TABLE ProductCategories (
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
	CategoryID INT FOREIGN KEY REFERENCES Categoris(CategoryID),
	PRIMARY KEY (ProductID, CategoryID)
);

SELECT P."ProductName", C."CategoryName"
FROM Products P
LEFT JOIN ProductCategories PC
       ON p.ProductID = PC.ProductID
LEFT JOIN Categories C
       ON PC.CategoryID = C.CategoryID;