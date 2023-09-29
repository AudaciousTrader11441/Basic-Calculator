# Calculator Application

This project demonstrates the step-by-step approach to building a Calculator Application that integrates a .NET Core backend with an Angular frontend.

## Table of Contents

1. [Introduction](#introduction)
2. [Approach](#approach)
    - [Step 1: Create a .NET Core Application with Angular Linkage](#step-1-create-a-net-core-application-with-angular-linkage)
    - [Step 2: Establish Connectivity with Angular and .NET Core API](#step-2-establish-connectivity-with-angular-and-net-core-api)
    - [Step 3: Create API for Calculator](#step-3-create-api-for-calculator)
    - [Step 4: Create UI for Calculator API](#step-4-create-ui-for-calculator-api)
3. [Running the Project](#running-the-project)


## Introduction

The Calculator Application is designed to provide a user-friendly interface for performing basic mathematical operations like addition and subtraction. It demonstrates the integration of a .NET Core backend with an Angular frontend to create a fully functional calculator.

## Approach

### Step 1: Create a .NET Core Application with Angular Linkage (15 mins)

In this step, set up the project by creating a .NET Core application that has Angular integrated into it. This linkage allows the Angular frontend to communicate with the .NET Core backend and use the single solution on visual studio to operate on both the solutions.

Prefered method is to use Visual studio for backend API related code and Viscual studio code for Angular,HTML and CSS realted changes.

### Step 2: Establish Connectivity with Angular and .NET Core API (15 mins)

Next, establish connectivity between the Angular frontend and the .NET Core API. This includes setting up routes and endpoints for data exchange between the two parts of the application.

Using a sample WeatherForecast Get api to spit out random data to make sure everything is connected and working.

### Step 3: Create API for Calculator (10 mins)

In this step, create an API for the calculator functionality. The API should include endpoints for performing addition and subtraction operations, also write testcases for the calculator controller.

### Step 4: Create UI for Calculator API (20 mins)

The final step involves building a user interface (UI) for the calculator API. Create an Angular component that provides a user-friendly interface for users to input numbers and perform calculations. The results of these calculations are displayed to the user.
- Create Service for the Calculator API calls.
- Create the component for Calculator with the calculator service injected.

## Running the Project

To run the Calculator Application, follow these steps:

1. Open the solution Visual Studio. Make sure to have .NetCore 6 and Angular 14 installed on local machine.
2. Run npm instal with the base location to ClientApp as have striped the node module and uploaded.
2. Build and run the project CalculatorTest.
3. The project is already set up such a way that it will automatically start the Angular application also, no need to run the clientapp seperately.

Once started it should start the welcome page, navigate to the calculator page and click on the button to open the Calculator Application through your web browser.

## Areas of improvement
1. Addion of testcases for Angular UI project and its services.
2. Advantages to use SCSS over CSS as we are createing modular UI components.
3. Seperation of repository into seperate project.
4. Angular project took more than estimated time as got a bit stuck on model pop up. spent additional 15 mins to resolve it. 
