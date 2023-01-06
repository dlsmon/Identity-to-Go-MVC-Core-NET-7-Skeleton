# Auth1-MVC-Core

### After cloning the project. Open Package Manager Console

##### PM> Add-Migration CreateIdentitySchema
##### PM> Update-Database

1) Run the application.
2) Click on Register button and create two users.
3) Login with one of the users.

Check Authorization
5) Click Home (Acessible to Everyone); 
6) Click Privacy (Denied) (Acessible to Users with Roles: "Coach" or "Admin"); 
7) Click Admin (Denied) (Acessible to Users with Roles: "Admin");

#### Add manually two Roles on table AspNetRoles as below
![image](https://user-images.githubusercontent.com/118259688/211037767-2bf9bb1c-c3b9-4e14-8840-855f75e3b92e.png)

#### Add Roles to Users as below on table AspNetUserRoles as below
![image](https://user-images.githubusercontent.com/118259688/211039047-c59c352a-669b-4b41-b045-b2c1e65cc0fe.png)

#### Check if the Users are on the table AspNetUsers as below
![image](https://user-images.githubusercontent.com/118259688/211039593-2ad2a287-a5d1-42f5-ab5b-3d21913c87bd.png)

