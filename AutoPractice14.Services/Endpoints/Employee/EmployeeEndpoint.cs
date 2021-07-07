using RestSharp;

namespace AutoPractice14.Services.Endpoints.Employee
{
    public static class EmployeeEndpoint
    {
        public static RestRequest GetEmployee()
        {
            return new RestRequest("employees", Method.GET);
        }
    }
}
