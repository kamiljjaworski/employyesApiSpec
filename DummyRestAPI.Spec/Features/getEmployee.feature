Feature: Get Employee
	It is possible to fetch list of employees present in the system. It is possible to get details of single employee.

Scenario: Get employee details
	Given employee rest API
	When GET endpoint is called with valid id 5
	Then employee of id 5 is returned

Scenario: Get non existing employee
	Given employee rest API
	When GET endpoint is called with an invalid id
	Then null is returned

Scenario: Get list of all employees
	Given employee rest API
	When GET endpoint is called
	Then list of employees is returned