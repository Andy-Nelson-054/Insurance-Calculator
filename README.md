# Insurance-Calculator
Simple API to calculate insurance premiums

Insurance calculator is written in .NET Core. It accepts POST requests containing business information and returns a quote for a premium based on that information.

## Setup and Usage
- Clone to local repository `git clone https://github.com/Andy-Nelson-054/Insurance-Calculator.git`
- Open solution in Visual Studio 2019 and build solution.
- Navigate to InsuranceCalculator.API\bin\Debug\netcoreapp3.1 and run InsuranceCalculator.API.exe.
- Alternatively, run from debug in Visual Studio.
- Using Postman or some similar tool, send a POST request .

### URL
````
https://localhost:44317/api/Insurance?Content-Type=application/json
````
- Ensure you are on the correct port. When running from debug mode in Visual Studio itwill be port 44317. When running the executable it will be port 5001. 
- If uncertain, the console output for the executable will show which port the the API is listening.  
### Headers
````
Content-Type: application/json
````
### Body
````
{
    "revenue": "6000000",
    "state": "TX",
    "business": "Plumber"
}
````
The response body will contain the premium as a decimal. In the example above, `11316.00`.

## Acceptable Values
The body must contain a value for revenu, state, and business. Acceptable state codes are `OH`, `FL`, and, `TX`. Acceptable businesses are `Architect`, `Plumber`, and `Programmer`.

## Fixes and Updates
- Before calculating, validate payload and add more robust error handling
- Remove unneccesary references to default template
- Configure the state factor, business factor, and hazard factor somewhere other than the premium calculator class


    