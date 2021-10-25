# Insurance-Calculator
Simple API to calculate insurance premiums

Insurance calculator is written in .NET Core. It accepts POST requests containing business information and returns a quote for a premium based on that information.

## Setup and Usage
- Clone to local repository `git clone https://github.com/Andy-Nelson-054/Insurance-Calculator.git`
- Open solution in Visual Studio 2019 and run in debug mode (this is currently the only way the application runs)
- Using Postman or some similar tool, send a POST request 

### URL
````
https://localhost:44317/api/Insurance?Content-Type=application/json
````
### Headers
````
Content-Type: application/json
````
### Body
````
{
    revenue: 6000000,
    state: 'TX',
    business: 'Plumber'
}
````
The response body will contain the premium as a decimal. In the example above, `11316.00`.

## Acceptable Values
The body must contain a value for revenu, state, and business. Acceptable state codes are `OH`, `FL`, and, `TX`. Acceptable businesses are `Architect`, `Plumber`, and `Programmer`.

## Fixes and Updates
- API currently only works in debug mode
- Before calculating, validate payload and add more robust error handling
- Remove unneccesary references to default template
- Configure the state factor, business factor, and hazard factor somewhere other than the premium calculator class.


    