# TestTask

Ответ на 2 задачу

```sql
CREATE TABLE Category (
    CategoryID int,
    CategoryName varchar(255),
);
CREATE TABLE Product (
    ProductID int,
    ProductName varchar(255),
);

CREATE TABLE Category_Product(
    ProductID int,
    CategoryID int,
);

SELECT Product.ProductName, Category.CategoryName
FROM Product
LEFT JOIN Category_Product ON Category_Product.ProductID = Product.ProductID
LEFT JOIN Category ON Category_Product.CategoryID = Category.CategoryID
