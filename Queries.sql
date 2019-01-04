SELECT ProductCollection.Product_ID, ProductCollection.Collection_ID, Product.ProductName, Product.ProductNo FROM ((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)

/* get collection from user where ID is a match */
SELECT Usr.Name, UserCollection.CollectionName, UserCollection.CollectionInfo, Product.ProductName, Product.ProductNo FROM (((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)
INNER JOIN Usr ON UserCollection.User_ID = Usr.Id)