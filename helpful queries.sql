--Get all Retailers with its corresponding CategoryId and Category Name
SELECT r.Id, r.Name, r.Location, r.Website, r.Details, rc.RetailerId, rc.CategoryId, c.CategoryName
FROM Retailer r
JOIN RetailerCategory rc on rc.RetailerId = r.Id
JOIN Category c on c.Id = rc.CategoryId