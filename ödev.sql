select p.ProductName as 'UrunAdi' ,sum(od.UnitPrice*od.Quantity) KazanilanTutar from Products p
inner join [Order Details] od
on od.ProductID=p.ProductID
inner join Orders o
on od.OrderID=o.OrderID
group by p.ProductName

