# sw-developer-assignment
## Welcome!
Hello!  We hope your interview process with SofterWare has been smooth so far.  This exercise is a way for you to show SofterWare your unique approach to writing software.

Please read this README in its entirety and complete this assignment per the instructions below.  We hope you have fun and we look forward to reviewing your work.

## Introduction
In this git repository you will find a Visual Studio solution for an ASP.NET Core Web Application that is meant to allow a user to shorten a URL.  In its current state it allows a user to enter a URL and submit this URL for shortening.  As you will see when running this application initially, the URL is not shortened and instead you will get a TODO message.  The actual shortening of the URL is left to you as an exercise.

## Instructions
1. Please update the application to succesfully shorten a URL.  You may update the application in any way you see fit as long as you adhere to the following requirements:
   * You must use git for source control.
   * You must use cleanuri.com to generate the shortened URL.  This API is free to use.  Documentation can be found here https://cleanuri.com/docs.
   * The application might use a different URL shortening service in the future (eg. Decide to use bitly instead of cleanuri).  Keep this in mind while implementing your solution.
   * Add a button to the UI that will copy the shortened URL to the clipboard.
2. When you are ready to submit your work to SofterWare be sure all changes are committed to your git repository and please do one of the following:
   * Zip up your git repository, host it in cloud storage (eg. Google Drive), and share a public link with your recruiter or SofterWare.
   * Push your code to your own private github repository and invite the contributor(s) of this repository to be collaborators on your private github repository.  DO NOT fork this repository as this would make your work visible to other prospective candidates.

## Considerations
Please keep things like reuseability in mind when creating your project. Perhaps in the future we would want to use a different provider so how would you handle that. Use the latest best practices with ASP.NET core. Some day this could become an enterprise piece of software so what would you do for an enterprise application. This could be deployed to multiple environments like Dev, QA, and Prod so how would you help your DevOps group manage different configurations for different environments. Remember this is a way to show off your development skills and we want to see your best coding.
