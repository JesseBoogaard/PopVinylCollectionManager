SELECT ProductCollection.Product_ID, ProductCollection.Collection_ID, Product.ProductName, Product.ProductNo FROM ((ProductCollection
INNER JOIN UserCollection ON ProductCollection.Collection_ID = UserCollection.Id)
INNER JOIN Product ON ProductCollection.Product_ID = Product.Id)