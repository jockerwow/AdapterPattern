// See https://aka.ms/new-console-template for more information

using AdapterPattern.Core;
using System.Text;
using System.Text.Json;

var payrollCalculatorUrl = "http://localhost:5077/PayrollCalculator";
var reader = new EmployeesDataReader();
var employees = reader.GetEmployees();

var client= new HttpClient();
foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorUrl);
    request.Content = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

    var response = await client.SendAsync(request);
    var responseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJson);

    Console.WriteLine($"Salary for employee `{employee.FullName}` as of today = {salary}");
}
Console.ReadKey();