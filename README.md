# HelloWorldRazor

A simple ASP.NET Core (C#) Razor Pages web application.

## Features

- Home page and Hello World example page
- Contact form with basic input fields
- Uses Bootstrap for styling (installed by default)

## Project Structure

- `Pages/` - Razor Pages (e.g., Index, HelloWorld, Contact)
- `wwwroot/` - Static files (CSS, JS, libraries)
- `HelloWorldRazor.csproj` - Project file

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

I use Arch Linux them I installed these packages:

```
sudo pacman -S dotnet-sdk dotnet-runtime aspnet-runtime
```

Check your distro how to install these packages or others dependencies needded.

### Project init

Create a new Razor app with name *HelloWorldRazor* (-n option) and add the output in the folder *HelloWorldRazor* (-o option)

```
dotnet new razor -n HelloWordRazor -o HelloWorldRazor
```

### Build and Run

Enter inside the created folder
```
cd HelloWorldRazor
```

Execute the commands to build and run the project
```
dotnet build
dotnet run
```

### Execution

The app will be available in the browser at https://localhost:5080

### License

This project is under MIT license which allows downloading, execution, modification, redistribution, both for private and commercial use of the source code, as long as the author is cited.

- [MIT](LICENSE.md)
