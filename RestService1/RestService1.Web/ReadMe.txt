WCF REST Template ReadMe

This is an improved version of the WCF REST Template published by Microsoft
on the Visual Studio Extensions gallery, which only provides a single web project.
This is a multi-project template designed by Tony Sneed that separates the Service
and Entities project from the Web project. It also provides a Client project for
consuming a RESTful service with LINQ to XML.

This template highlights features of WCF 4 which provide improved support for REST.
- simplified web.config file which configures the standard web http endpoint to
  include a help page and automatic format selection for XML or JSON based on
  the HTTP Content-Type and Accept headers
- integration with ASP.NET Routing with a Global.asax file that routes incoming
  requests for the "SampleService" uri to the web operations in SampleService

To run the service, set the .Web project as the Startup project and press Ctrl+F5
to start the ASP.NET development web server. When the root directory is displayed
in your default browser, append SampleService to the url and press Enter. This
should result is an HTTP GET request to the service invoking the GetCollection method.

With the service still running, you can set the .Client project as the Startup project
and press Ctrl+F5 to invoke the service GetCollection method and parse the result
using LINQ to XML to get a list of items and print them to the console.

For more information or to contact the author, visit http://blog.tonysneed.com