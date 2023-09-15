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

![Adding Components and Services](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiR1A9O4L0_wm-PAAGsye_7sv2nn8_YFVZYcKLw0DT06HjuEFET9zs3k3cs8Asj5qUA4oQly6bZmdKuYke6WpWK7Wdd-j54m0JNe0uDY-BkbY695Y0ey6ihz6MUPCwI2EjpuUde00LpkzfPlLgLFl3M0s1Hk0e16Jw9R6B0FObLqJbFIjy0R9cYYUBou-uK/s1029/Angluar_Component_Services.png "Adding Components and Services")

-- To run the project run the below command at the root of the project.
dotnet run
