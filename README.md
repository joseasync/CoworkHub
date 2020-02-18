# :bulb: Understanding TDD easily. ![](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)

This is a practical example of how to follow the TDD Methodology in conjunction with [.NET Core 3.0](https://github.com/dotnet/aspnetcore) and [xUnit](https://xunit.net/). :battery:


*Read this in other languages: [Portuguese](README.pt.md), [Svenska](README.se.md).*


## What is TDD in resume. :star:

If you are here, probably you are tired to read/search about TDD, many ways to use but on practice is hard to find a good example.
So here, you have your questions answered (really, it's super simple :smile:). 

### Quick draw

TDD is a Test Driven Development methodology. But more than just a way to test your code, TDD is a process, considered a good culture in the companies. TDD Works around a circle with 3 "checkpoints". 

- Red - Create a simple test describing your requirement, it cannot pass (Because you haven't the rules yet :wink:). This will help you to avoid false positives.

- Green - You will implement the business rules code, just enough for the test to pass. No fancy things, for a while.

- Refactor - The red and green checkpoints create a savepoint, ensuring that your code works fine. Now you can refactor/improve it to make it clean and performatic. :triangular_flag_on_post:


![Flow](https://i.imgur.com/lTq3Seu.png)

Simple but...


## Why do many companies request, but few use? 


Don't judge the companies, most of them are trying to change their processes, but they are caught in the middle of it.\
For example:

- Difficulty to know how to start
- Learning curve
- Employees resistance

The best way to not feel any of those examples, you need be ready when this challenge apears.
Learning and understanding not just how but why TDD is a good way to code. Helping the processes with:

- Code quality - One best way to start to code is knowing how the scenario works.
- Logic - Having a big picture, you can avoid unecessary dependencies and couplings.
- Reliability - Being comfortable to solve the problems, therefore, less stress less blocks saving time.
- Team work - Everyone knows what's happening on the code by read the tests. 
- Documentation - Reading the Tests descriptions, the code tells you how the process works.

## Ok, so let's practice.

I separated the requiriments by number on the commits (1 - 2 - 3).
Remember the focus here is't in business methodology, DAL Access, service layers or architecture. I thik It would complicate the compreension. Just focus on the Process :), you can use it with, java, python even cobol. 

### Create your Test Project

Select the xUnit Project.

![projectTDD](https://i.imgur.com/Idun2dd.jpg)

### Create your Tests

**Red Status** 

We create our test class called `SpaceBookingRequestTest.cs` class with our basic first test `ShouldReturnSpaceResultWithRequestValues`.

![red1](https://i.imgur.com/pQchDcC.jpg)

Use the Visual Studio to help you to auto generate Models `SpaceBookingRequest` and `SpaceBookingResult`.

![red1_1](https://i.imgur.com/kXieVgS.jpg)

We can also use to create the `SpaceBookingRequestExecution.cs` and the `BookSpace` function.

![red1_2](https://i.imgur.com/9C0blWC.jpg) 

```csharp
internal SpaceBookingResult BookSpace(SpaceBookingRequest userRequest)
{
        throw new NotImplementedException();
}
```

Finalizing this, we'll have our test buildable but not passed (Red Circle).





