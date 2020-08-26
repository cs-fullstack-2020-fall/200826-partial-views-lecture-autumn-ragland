# 200826 Partial Views Lecture

### Set Up
- Create a .NET MVC app using the .NET CLI called `ResidentDirectory`
- Create a controller called `Resident`
- Create an Index() method to display an h1 with the text `Welcome to the Residents Landing Page`
- Run in browser
- Create a postman collection and one request for the landing page

### End Product
Create a Resident Directory that allows users to view all residents, view residents with children, and view a resident by apartment number. 

### Code Together
#### Models
- Resident Model : name, apartment number, has children
- Resident List View Model : list of residents populated in constructor 

#### View All Residents
- Action : Pass public list of residents to associated view
- View : Use partial to render details of each resident

#### View One Resident
- Action : Accept one query param `apartmentID`, find the resident from the public list of residents with the matching ID, and pass to associate view. If no resident matches pass to NotFoundView
- View : Use partial to render details of matching resident
- Not Found : Display an h1 with the text `This resident is not in our records`

#### View Residents that Have Children
- Action : Pass public list of residents to associated view
- View : Use partial to render details of each resident that does have children
