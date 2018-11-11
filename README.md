# Sales App

#### Chan Lee
##### 11/12/2018

# Description
* Sales application to manage sales amount per salesperson / sales region. User can perform CRUD functionality linked to the grid view. App is built on Microsoft Form and Entity Framework 6.2, with local database linked by Microsoft SQL server express.

# Layout
[Screenshot](/Sales-Application/screenshot.PNG)
* With Salesperson and Sales region data seeded, user can retrieve list of sales based on combinations of two variables by clicking refresh button.
* User can edit directly on the data grid view, focusing out of the grid will confirm the editing. 
* On the bottom, user can create new sale instance by setting Amount, Date, Salesperson and Sales region, then click New Sale button.
* User can delete row by putting cursor on the row intended and click delte button. This involves soft deletion based on IActive interface, by changing instance to active = false status.
* Each Salesperson has sales target which can be visited by clicking target button

## Setup/Installation Requirements
  * Window Forms application only runs under Window OS

  - Clone this repository from 
  https://github.com/goenchan/Sales-Application

  - Navigate to the "SalesApp" folder

  - Run SalesApp.application file

  - It will setup application along with packaged Entity Framework & Microsoft SQL Express 2012 LocalDB.

  - If error regarding cannot locate localDB or connectionstring, open terminal in home directory and type "SqlLocalDB create MSSQLLocalDB", which will create database path set under production.

## Support and contact details

  - Chan Lee - github.com/goenchan & chanethanlee@gmail.com


## Technologies Used

  - C# Windows Forms
  - Entity Framework 6.2
  - Microsoft SQL Express
  
This software is licensed under the MIT license.

Copyright (c) 2018 **Chan Lee**
