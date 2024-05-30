## [.NET Tutorial - Your First Microservice](https://dotnet.microsoft.com/en-us/learn/aspnet/microservice-tutorial/intro)


**Install .NET SDK**

To start building .NET apps, download and install the .NET SDK.

[Download .NET SDK (64-bit)](https://dotnet.microsoft.com/en-us/download)

**Create your service**    
In your command prompt, run the following command to create your app:

```
dotnet new webapi -o FirstMicroservice --no-https
```

**Add Docker metadata**

To run with a Docker image, you need a Dockerfile — a text file that contains instructions for how to build your app as a Docker image. A Docker image contains everything needed to run your app as a Docker container.

Return to app directory
Since you opened a new command prompt in the previous step, you'll need to return to the directory you created your service in.

```cd FirstMicroservice```

**Add a DockerFile**

Create a file called Dockerfile with this command:

```dotnetcli
fsutil file createnew Dockerfile 0
```

You can then open it in your favorite text editor manually or with this command:

```
start Dockerfile
Replace the content of the Dockerfile to the following in the text editor:
````

Dockerfile

```
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY FirstMicroservice.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "FirstMicroservice.dll"]
```

Note: Make sure to name the file as Dockerfile and not Dockerfile.txt or some other name.

Optional: Add a .dockerignore file
A .dockerignore file reduces the set of files that are used as part of `docker build`. Fewer files will result in faster builds.

Create a file called .dockerignore file (this is similar to a .gitignore file if you're familiar with those) with this command:

```
fsutil file createnew .dockerignore 0
```

You can then open it in your favorite text editor manually or with this command:

```dotnetcli
start .dockerignore
```

Replace the content of the .dockerignore to the following in the text editor:

.dockerignore

```
[b|B]in
[O|o]bj
```

### Create Docker image
Run the following command:

```dotnetcli
docker build -t firstmicroservice .
```

The docker build command uses the Dockerfile to build a Docker image.

- The -t firstmicroservice parameter tells it to tag (or name) the image as firstmicroservice.
- The final parameter tells it which directory to use to find the Dockerfile (. specifies the current directory).
- This command will download and build all dependencies to create a Docker image and may take some time.

You can run the following command to see a list of all images available on your machine, including the one you just created.

```dotnetcli
docker images
```