--Get all Retailers with its corresponding CategoryId and Category Name
SELECT r.Id, r.Name, r.Location, r.Website, r.Details, rc.RetailerId, rc.CategoryId, c.CategoryName
FROM Retailer r
JOIN RetailerCategory rc on rc.RetailerId = r.Id
JOIN Category c on c.Id = rc.CategoryId


--Get all Categories with its corresponding RetailerId and Retailer Name
SELECT c.Id, c.CategoryName, rc.CategoryId, rc.RetailerId, r.Name
FROM Category c
JOIN RetailerCategory rc on rc.CategoryId = c.Id
JOIN Retailer r on r.Id = rc.RetailerId


--Get single retailer
SELECT r.Id, r.Name, r.Location, r.Website, r.Details, rc.RetailerId, rc.CategoryId, c.CategoryName
FROM Retailer r
JOIN RetailerCategory rc on rc.RetailerId = r.Id
JOIN Category c on c.Id = rc.CategoryId
WHERE r.Id = 1



