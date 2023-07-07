# Introduction
Sample Windows Forms application in .NET Framework that takes advantage of 
useful techniques such as 

- Dependency Injection (IOC container)
- MVP (Model-View-Presenter)

# Dependency Injection Setup
Use Nuget to install Microsoft.Extensions.DependencyInjection
Update Program.cs to include 
- Static IServiceProvider property
- Static ConfigureServices()
- Static GetService<T>()

New services, mediators, etc. are registered in ConfigureServices().

Classes consuming DI services are expected to call Program.GetService<T>() in
their constructors. As opposed to other popular DI systems where the IOC 
examines the classes and supplies dependencies through constructor args.
