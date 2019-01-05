SELECT ProductCollection.Product_ID, ProductCollection.Collection_ID, Product.ProductName, Product.ProductNo FROM ((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)

/* get collection from user where ID is a match */
SELECT Usr.Name, UserCollection.CollectionName, UserCollection.CollectionInfo, Product.ProductName, Product.ProductNo FROM (((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)
INNER JOIN Usr ON UserCollection.User_ID = Usr.Id)

/* get collection by collectionname and order results by their series in descending order */
SELECT Product.ProductName AS 'Product Name', Product.ProductNo AS 'Product Number', Series.SeriesName AS 'Series' FROM (((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)
INNER JOIN Series ON Product.SeriesID = Series.Id)
WHERE ProductCollection.Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = 'TestCollection')
GROUP BY Product.ProductName, Product.ProductNo, Series.SeriesName
ORDER BY Series DESC

/* get count of unique figures in user collection */
SELECT DISTINCT COUNT(ProductCollection.Product_ID) AS 'Unique figures' FROM ProductCollection WHERE Collection_ID = (SELECT Id FROM UserCollection WHERE CollectionName = 'TestCollection')