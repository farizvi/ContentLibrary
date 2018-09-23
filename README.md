ContentLibrary
=====

**ContentLibrary** is a  WebAPI project which fetches data from database by invoking a stored procedure which takes type as a parameter.

Minimum requirements to run this application are
 * .Net Framework 4.5
 * Visual Studio 2013
 * SQL Server 2014 Express Edition

## Project Structure

### ContentLibrary.Core

The `ContentLibrary.Core` project contains the core logic of this application. It contains Contracts and Services.

### ContentLibrary.Data

The `ContentLibrary.Data` project contains all the database related code. Entity Framework Code First approach is used to develop this project. It contains the Database Context, Migrations and Repositories.

### ContentLibrary.Domain

The `ContentLibrary.Domain` project contains the domain entities.

### ContentLibrary.UnitTests

The `ContentLibrary.UnitTests` project contains all the Unit Tests for this application.

### ContentLibrary.WebAPI

The `ContentLibrary.WebAPI` project contains WebAPI implementation for this application. It is the startup project.

## Libraries used for this project

This application uses `Autofac` for Dependency Injection and `Moq` for mocking the repository for unit tests

## Database

The database file for this application exists in App_Data folder in `ContentLibrary.WebAPI` project.