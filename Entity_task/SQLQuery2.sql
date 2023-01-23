/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CustomerID]
      ,[CustomerName]
      ,[Age]
      ,[Phone]
      ,[Email]
      ,[Photo]
  FROM [task22].[dbo].[Customers]
      