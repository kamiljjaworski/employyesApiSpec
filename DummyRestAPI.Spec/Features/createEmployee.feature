Feature: Create Employee
	It is possible to add employee to system, employeedata should be sent in JSON format in request body.
	If body is missing/empty then default employee is added to the system.

Scenario: Create custom employee
	Given employee rest API
	When ADD endpoint is called
	Then added employee can be fetched

Scenario: Create default employee
	Given employee rest API
	When ADD endpoint is called without body
	Then default employee is added