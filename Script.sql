CREATE TABLE Product (
  ID int PRIMARY KEY,
  Name TEXT,
);

INSERT INTO Product (ID,Name) VALUES 
  (1,'Google Pixel'),
  (2,'Iphone'),
  (3,'MacBook'),
  (4,'JBL Stage 4');

  
CREATE TABLE Category (
  ID int PRIMARY KEY,
  Name TEXT,
);

INSERT INTO Category (ID,Name) VALUES 
  (1,'Смартфон'),
  (2,'Ноутбук'),
  (3,'Портативная колонка');
  

CREATE TABLE ProductCategory (
  ProductID int FOREIGN KEY REFERENCES Product(ID),
  CatrgoryID int FOREIGN KEY REFERENCES Category(ID),
  PRIMARY KEY (ProductId, CatrgoryID)
);

INSERT INTO ProductCategory (ProductID, CatrgoryID) VALUES
  (1,1),
  (2,1),
  (3,2),
  (4,3);

SELECT P."Name", C."Name"
FROM Product P
LEFT JOIN ProductCategory PC
	ON P.Id = PC.ProductID
LEFT JOIN Category C
	ON PC.CatrgoryID = C.ID;