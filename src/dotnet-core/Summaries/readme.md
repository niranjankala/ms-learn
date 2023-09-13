-- Check available templates of .NET core, use below commmand
dotnet new
-- Create new .NET Core project with Angular
dotnet new angular

--- Run the program by using below command
npm install --save-dev @angular-devkit/build-angular

-- Add components
cd ClientApp\src\app\components
then run the below command to create a component and register it to the module
ng g c books -m app

ng g c delete-book -m app

ng g c new-book -m app

ng g c show-book -m app

ng g c update-book -m app

-- Create Services
cd..
cd .\services\
Run below command to create a service
ng g s book
