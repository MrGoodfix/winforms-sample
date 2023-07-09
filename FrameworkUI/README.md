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

# MVP Notes

The presenter in this example functions like a mediator. It decouples the 
UI (form class) from the rest of the solution. To do this, the presenter must
be knowledgeable of the view (or an interface that suitable specifies it) and
the other colleagues. The other colleagues are any other part of the 
application the view might need to send requests to.

Ideally, the presenter is going to have dependencies on the abstract view and 
the abstract services (interfaces). The concrete view will be supplied to the 
presenter when its constructor runs; the view will call the presenter's constructor
and pass itself as an argument to it. This follows the mediator pattern since all
colleagues should know about their mediator. Other implementations might also have
an interface for the presenter if they want to include it in unit tests or have
some kind of DI enabled extensibility on the presenter, too. The services required
y the presenter will be supplied through the project's dependency injection. In 
this case, that means calling Program.GetService<T>().

## Setup
1. Create the concrete view (Form/UserControl/etc) along with an abstract view (interface) that it inherits.
2. Create a corresponding concrete presenter class 
1. Add a reference to abstract view in the presenter class as a readonly private datamember.
3. Initialize the private view interface in the presenter's constructor.
4. Add a readonly private datamember for the concrete presenter in the view class
5. call the presenter's constructor inside the view's constructor and pass "this" view as an argument to it.
6. The view and the presenter now have references to each other allowing two way communication.

It seems like a couple of development workflows might work with this.

### UI First...
1. Design the user experience ... controls, events, and stuff
2. I imagine that a number of things like the ErrorProvider, BackgroundWorker, etc. would still make more sense to add directly to the Form/UserControl.
3. Many other things though... like data services (DAO, repo, etc.)... should have functions added to the presenter to support the commands and queries to be supported by the view.
	a. Add controls to the view
	b. Add functions to the presenter
	c. presenter either calls existing services to perform the operation or stubs the process until appropriate service endpoints can be created.
	d. Add event handlers to the view that call the appropriate functions on the presenter.

Make a screen and then backfill the pieces it needs to connect to?

### Service First...
1. Add interfaces/classes for services in the class library
2. Create unit tests where applicable... or first in TDD
3. Specify the commands and queries the end users should have access to and add them to one or more presenters.
4. Update the abstract views (interfaces) to meet the new requirements of the presenter(s)
5. Create or update views to meet the specification of the new interfaces and call the updated presenters

Plan the core and save the concrete UI implementation to last?

## I'm not sure how either of these would work in a team environment.
