# CS Student Portal (ASP.NET 5.0 Edition)

This build of the CS portal is built on the ASP.NET 5.0 framework, using Razor Pages and the Entity Framework.

## Development Environment

To develop this project it is easiest to install the [.NET 5.0 SDK](https://dotnet.microsoft.com/download), open the project folder in [Visual Studio Code](https://code.visualstudio.com/) and use the `dotnet` terminal command (which can be used from within VS Code).

Wile this can be done on Windows, it is better to use a Linux environment as that is the production environment we are targeting.  On a Windows 10 PC you can use the [Windows Subsystem for Linux (WSL)](https://docs.microsoft.com/en-us/windows/wsl/install-win10).  This can also be used in conjunction with VS Code.

You will also need to install the entity framework toolset, which you can do from the terminal (either in VS Code or using cmd or powershell):

```
$ dotnet tool install --global dotnet-ef
```

Before running the application, you'll need to create and populate the database using the entity framework (in development we use SQLite3 as our database).  This is done with the command:

```
$ dotnet ef database update
```

To build the project, from the Portal directory:

```
$ dotnet build 
```

To build and run on localhost (default https://localhost:5000):

```
$ dotnet run 
```

## Developing Subapps 

The portal is set up with subapp development in mind.  Subapps help keep the portal organized into distinct web applications that can share data. The first step in developing a subapp should be to create a new branch for developing that specific subapp, i.e. for the "reservations" subapp:

```
$ git branch reservations 
$ git checkout reservations 
```

This ensures all changes you are making are committed to the new branch, **NOT** to the master branch.  You will merge your new branch into master once development is complete.  This helps avoid the "broken master" situation, which can result in the whole site going down.

### Database Changes 

The portal is set up to use code-first migrations using the Entity Framework.  Thus, for our reservations subapp, we might need models (ORM wrappers around database tables) to track events we can reserve a spot for, and records for those reservations.  Since we're using the code-first entity framework approach, we start by declaring two classes to represent these, `ReservationEvent` and `ReservationRecord`.  These will be declared in the _Models/ReservationEvent.cs_ and _Models/ReservationRecord.cs_ respectively:

```csharp
using System;
using System.Collections.Generic;

namespace Ksu.Cs.Portal.Models
{
    public class ReservationEvent 
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public uint AttendeeLimit { get; set; }

        public CourseOffering CourseOffering { get; set; }

        public ICollection<ReservationRecord> ReservationRecords;
    }
}
```

```csharp
namespace Ksu.Cs.Portal.Models
{
    public enum ReservationStatus 
    {
        Reserved,
        Waiting,
        Canceled
    }

    public class ReservationRecord 
    {
        public int Id { get; set; }

        public ReservationStatus ReservationStatus { get; set; }

        public ReservationEvent ReservationEvent { get; set; }

        public SiteUser SiteUser { get; set; }
    }
}
```

Note that we define columns of this table as properties (i.e. `AtendeeLimit`), including foreign keys (which are of the type of table they correspond to).  Also, primary keys should be named `ID`, and are automatically recognized as primary keys by the entity framework.

We also need to incorporate these new models into the Data Context for the Portal application, so that it knows they exist and are part of the expected database structure.  The context is defined in the `PortalContext` class in the _Data/PortalContext.cs_ file.  We'll need to add two lines referencing our new models in its `OnModelCreating()` method:

```csharp 
modelBuilder.Entity<ReservationEvent>().ToTable("ReservationEvent");
modelBuilder.Entity<ReservationRecord>().ToTable("ReservationRecord");
```

Now we can create the _migration_ that will create these tables.  We do this with the entity framework tool at the command line:

```
$ dotnet ef migrations add CreateReservations
```

The last argument should be a name for the migration, reflecting the role of the migration (in this case, adding reservation tables).  This will create several auto-generated files in the _Migrations_ folder, which in some cases may need manual tweaking.

We can then apply these changes with the entity framework update command:

```
$ dotnet ef database update 
```

Once this is done, our new tables are a part of the database, and we can access them, along with the rest of the database, through the data context.

### Adding Code 
New projects can be added as subfolders in the _Areas_ folder, i.e. a bulletin board app would have its files placed in _Areas/BulletinBoard_.  These would include the normal pages structure (for a razor app) or view/controller (for a MVC app).

### Adding Tests

Once you have code in the _Portal_ directory, unit tests can be added to the _Tests_ directory. Tests for particular areas (e.g. Maps) should be in a folder corresponding to their folder inside the _Portal/Areas_ folder. Test names should be descriptive.

When you want to run your unit tests, you can do so with the following command from the command line in the _Portal_ directory.

```
$ dotnet test
```
