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


## Why do many companies request, but few use?\


Don't judge the companies, most of them are trying to change their processes, but they are caught in the middle of it.\
For example:
