SELECT p.Name, c.Name 
FROM products p
JOIN productCategory pc ON p.Id = pc.ProductId
LEFT JOIN category c ON pc.CategoryId = c.Id;