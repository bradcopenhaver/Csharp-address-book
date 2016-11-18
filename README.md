# Address Book

#### This web app allows users to create a list of contacts and view details of each individual contact saved. {November 2016}

#### By **Brad Copenhaver**

## Description

This is a simple address book application. The user creates a contact entry by submitting a form. A confirmation page is shown for each contact created, and users can view a list of all contacts created so far. Details for individual contacts can be accessed by clicking on the entry in the list. The entire list can be also be cleared.

###Specifications
_This program will..._
* Save contact details that the user submits.
 * Input: Joe Wilson
 * Output: {"Joe", "Wilson"}

* Display saved contact details back to the user.
 * Input: {"Joe", "Wilson"}
 * Output: Joe Wilson

* Save multiple contacts.
 * Input: Joe Wilson, Fred Jones
 * Output: {"Joe", "Wilson"}, {"Fred", "Jones"}

* Display a list of all contacts entered.
  * Input: {"Joe", "Wilson"}, {"Fred", "Jones"}
  * Output: Joe Wilson, Fred Jones

* Allow the user to clear all saved contacts.
 * Input: Clear All
 * Output: {}

## Setup/Installation Requirements

Source code available at https://github.com/bradcopenhaver/Csharp-address-book
App can be viewed at https://bradcopenhaver.github.io/Csharp-address-book

## Known Bugs

Non-numeric input fields will accept any input.

## Support and contact details

If you have questions or comments, contact the author at bradcopenhaver@gmail.com

## Technologies Used

* C#
* Bootstrap
* Nancy framework
* Razor view engine
* html/css

### License

This project is licensed under the MIT license.

Copyright (c) 2016 **Brad Copenhaver**
