using System;
namespace BenthanysPieShopHRM
{
	internal class Employee
	{
		public string firstName;
		public string lastName;
		public string email;

		public int numberOfHoursWorked;
		public double wage;
		public double hourlyWage;
		public DateTime birthDay;
		public double HourlyRate;
		public EmployeeType employeeType;

		const int minimalHoursWorkedUnit = 1;


		public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType empType)
		{
			firstName = first;
			lastName = last;
			email = em;
			birthDay = bd;
			HourlyRate = rate;
			employeeType = empType;



		}

		public void PerformWork() {
			PerformWork(minimalHoursWorkedUnit);
		}
		public void PerformWork(int numberOfHours) {
			numberOfHoursWorked += numberOfHours;
			Console.WriteLine($"{firstName}{lastName} has worked for {numberOfHours}");

		}
		public void DisplayEmployeeDetails()
		{

			Console.WriteLine($"first name: \t {firstName}\n lastname:\t{lastName}\n " +
				$"email:\t{email}\n Birthday:\t{birthDay.ToShortDateString()}");
		}





		
	}
  //  public double ReceiveWage(bool resetHourts = true)
  //  {
		//if (employeeType == EmployeeType.Manager) {
		//Console.WriteLine($"An extra was added to wage since {firstName}")}


  //  } Enumeration
};





// Employee employee = new Employee(); ==> somutlastirdik employee

// employee.PerformWork(); ==> method cagiriliyor

//employee.firstName= "Bethany"; ==> tanimi degistirme

//int wage= employee.ReceiveWage(); ==> returning value from a method


