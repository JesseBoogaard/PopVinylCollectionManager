/* get collection from user where ID is a match */
SELECT Usr.Name, UserCollection.CollectionName, UserCollection.CollectionInfo, Product.ProductName, Product.ProductNo FROM (((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)
INNER JOIN Usr ON UserCollection.User_ID = Usr.Id)

/* get collection by collectionname and order results by their name in descending order */
SELECT Product.ProductName AS 'Product Name', Product.ProductNo AS 'Product Number', Series.SeriesName AS 'Series' FROM (((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)
INNER JOIN Series ON Product.SeriesID = Series.Id)
WHERE ProductCollection.Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = 'TestCollection')
GROUP BY Product.ProductName, Product.ProductNo, Series.SeriesName
ORDER BY ProductName DESC

/* get count of unique figures in user collection */
SELECT DISTINCT COUNT(ProductCollection.Product_ID) AS 'Unique figures' FROM ProductCollection WHERE Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = 'TestCollection')

/* add a new product to the users collection, if this product isnt present yet*/
IF NOT EXISTS(SELECT * FROM ProductCollection 
WHERE Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = 'TestCollection') AND Product_ID = (SELECT Id FROM Product WHERE ProductName = 'TestProduct'))
INSERT INTO ProductCollection (Product_ID, Collection_ID)
VALUES ((SELECT Id FROM Product WHERE ProductName = 'TestProduct'), (SELECT Id FROM UserCollection WHERE CollectionName = 'TestCollection'))

/* select the amount of products with a productnumber under 200 */
SELECT COUNT(Id) AS 'Amount of Products' FROM Product
HAVING COUNT(Id) < 200

/* select total amount of products owned by 1 user */
SELECT COUNT(Product_ID) 
FROM UserCollection
JOIN ProductCollection ON UserCollection.Id = ProductCollection.Collection_ID
WHERE UserCollection.User_ID = 2