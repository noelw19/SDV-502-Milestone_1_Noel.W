# SDV-502-Milestone_1_Noel.W

You are required to
-develop a web app server side for a medium sized company by using client-side and server side using nodeJs, expressJs and reactJs and other req technologies.

-Implements online store concepts.

- [] Admin to add new categories and add, read, edit, delete products view orders
- [] Customers can register and login, browse & search for products, purchase checkout and view order status.

### ADMINISTRATOR
- [] Add products
- [] View products
- [] Update products
- [] Delete products
'Orders for the business i am guessing ?'
- [] View orders
- [] Fulfill orders

### CUSTOMER
- [] Register
- [] Login
- [] Browse / Search products
- [] Purchase must be done with registered user
- [] Checkout to complete order
- [] View order Status
- [] Cart

Web app should support basic crud operations to the database table.

UsersTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|CustomerId | int| Y | Y | N
|Name	 | VARCHAR(255) | Y| N | N |
|Password | VARCHAR(255) | Y | N | N|
|AdminId | BOOL | N | N | Y |
|Email | VARCHAR(255) | Y | N| N

Hoping for when an admin is minted a admin password is requested and will be required for changes depending on scale

AdminId is used as a foreign key in the users table to for refferencing, will check if the adminid is equal to a not null value and then check the validity by cross referencing within the admin table for some value that validates this customer is infact the owner of this space.

AdminTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|AdminId | int| Y | Y | N
|AdminPassword | VARCHAR(255) | Y| N | N |

ProductTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|ProductId | int| Y | Y | N
|ProductName | VARCHAR(255) | Y| N | N |
|ProductPrice | int | Y| N | N |
|ProductDesc | VARCHAR(255) | Y| N | N |
|ProductSize | int | Y| N | N |

CategoryTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|CategoryId | int| Y | Y | N
|CategoryName | VARCHAR(255) | Y| N | N |
|CategoryDesc | int | Y| N | N |
|CategoryType | VARCHAR(255) | Y | N |N |

CustomerOrderTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|OrderId | int| Y | Y | N
|CustomerId | VARCHAR(255) | Y| N | N |

OrderTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|OrderId | int| Y | Y | N
|OrderAmount | int | Y| N | N |
- Status 0.1 - 1 = purchased - received
|OrderStatus | int | Y| N | N |

ProductOrderTable
| fieldName | Type | Required | PK | FK |
| ----      | ---- |  ----    | ----|----|
|OrderId | int| Y | Y | N
|ProductId | int | Y| N | N |
|ProductAmount | int | Y| N | N |













