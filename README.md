Process and Technical Decisions

Purpose

The purpose of this project is to create a simple API that calculates Fibonacci numbers for a given index. This API aims to be a straight forward implementation to serve as a learning exercise and a basic example of how to build a RESTful API with ASP.NET Core.

Technical Stack
The following technical stack was chosen for this project:

ASP.NET Core: Chosen for its robustness and cross-platform capabilities.
C#: The primary programming language for ASP.NET Core.
GitHub: Used for version control and project collaboration.
Visual Studio: Chosen as the development environment for its simplicity and extensibility.
Implementation Details
The core logic for calculating Fibonacci numbers is implemented in the FibonacciController:

The CalculateFibonacci method handles incoming GET requests, performs input validation, and returns the calculated Fibonacci value.
The Fibonacci method calculates Fibonacci iteratively to avoid stack overflow errors for large indices.
input validation
To ensure the API handles invalid input gracefully, we check for negative indices. If a negative index is provided, the API returns a 400 Bad Request response with an appropriate error message.

Future Improvements
While this is a simple API, there are several potential improvements that can be made in the future:

Error Handling: Implement more comprehensive error handling to cover edge cases and provide informative error messages.
Caching: Add caching to store previously calculated Fibonacci values to improve response times for frequently requested indices.
Logging: Incorporate logging to record important events and errors for monitoring and debugging.
Authentication: If needed, introduce authentication and authorization mechanisms to secure the API.
Unit Tests: Develop unit tests to verify the correctness of the Fibonacci calculation and API endpoints.
Dockerization: Dockerize the application to make it easier to deploy and manage in different environments.
Deployment: Deploy the API to a cloud platform or container orchestration service for scalability and high availability.
Conclusion
This README documents the thought process, technical decisions, and potential improvements for the Fibonacci API project. The aim is to provide a simple yet functional API while leaving room for future enhancements and optimizations to make it more robust and production-ready.