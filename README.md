# OrderProcessingApp
This app is a small demo system for Payment processing.

## Tech used
It is build on .Net core 2.2, I have used Xunit , fakeit easy for Unit test code.

## workflow
The Project uses Factory Patern to determine Payment Processing based on Product Type.
The Payment status changes to processed on Processing.
Hence is made extensible, as and when a new product type is available we need an enum  for the product and the corresponding business layer is instansiated based on reflection.


