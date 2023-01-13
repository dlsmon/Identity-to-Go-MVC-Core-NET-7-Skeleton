# Identity-to-Go-MVC-Core-NET-7-Skeleton

###### Kickoff your website with .NET  7 Identity (authentification(register,login,logout) and authorization(roles))
###### Time to configure (5 minutes maximum)
###### Email server not configured (to update)


### Clone the project on visual studio. Open Package Manager Console
![image](https://user-images.githubusercontent.com/118259688/211290614-7daa60c8-b706-4025-9f6b-7da1cc58f0cd.png)

##### PM> Update-Database
![image](https://user-images.githubusercontent.com/118259688/211290481-819688f1-f54e-437e-a9ce-ff2e069c5bb1.png)





##### Run the application. Check Authentification

1) Click on Register button and create two users.(
2) Login with one of the users.

##### Check Authorization
3) Click Home (Acessible to Everyone); 
4) Click Privacy (Denied) (Acessible to Users with Roles: "Coach" or "Admin"); 
5) Click Admin (Denied) (Acessible to Users with Roles: "Admin");

#### Check if the Users are on the table AspNetUsers as below
![image](https://user-images.githubusercontent.com/118259688/211039593-2ad2a287-a5d1-42f5-ab5b-3d21913c87bd.png)

#### Add manually two Roles on table AspNetRoles as below
![image](https://user-images.githubusercontent.com/118259688/211037767-2bf9bb1c-c3b9-4e14-8840-855f75e3b92e.png)

#### Add Roles to Users as below on table AspNetUserRoles as below
![image](https://user-images.githubusercontent.com/118259688/211039047-c59c352a-669b-4b41-b045-b2c1e65cc0fe.png)



