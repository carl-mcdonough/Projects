# Projects
Car Sales Application

Run API
1. Clone Project
2. Select your directory and run this command using bash shell
   - git clone https://github.com/carl-mcdonough/Projects.git
3. Open API project in Visual Studio 2017
4. Open Package Manager Console and run this command to populate initial database data
   - dotnet ef database update
5. Run project via IIS Express (https://localhost:44357/api/vehicles/vehicletypes)
	Update port if needed be

Run Angular App
1. Open Project in Visual Studio 2017 
	- > File> Open > Folder >
2. make sure node.js is installed in your computer
3. install Angular cli inside the project directory and run these commands using bash shell
	-	npm install -g @angular/cli
	-	npm install --save-dev @angular-devkit/build-angular
	- ng serve
4. Open this link in browser http://localhost:4200
5. make sure the API is running

There you have it, the Vehicle Management System for carsales take home project.

Project
1. Go to Vehicles dropdown menu > Create Car
2. Fill out all fields and until the form is valid, you'll be able to save a record.
3. Check if the car record is successfully added
	- https://localhost:44357/api/vehicles
	
For any questions, feel free to email me @ carllouisemcdonough08@gmail.com
