﻿SELECT ProductName, 
CategoryName 
FROM Products LEFT JOIN Categories 
ON Products.CategoryID = Categories.CategoryID;