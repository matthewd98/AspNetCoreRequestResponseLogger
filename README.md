# AspNetCoreRequestResponseLogger

Included in this git repo is an ASP.NET Core 3.1 Web API project with a custom middleware to log HTTP requests and responses.

It can be very helpful with debugging customer issues especially over HTTPS as it's difficult to get tools like Fiddler and Wireshark working.

It is recommended to only turn on the logging when needed, otherwise it will hurt performance and scalability.
