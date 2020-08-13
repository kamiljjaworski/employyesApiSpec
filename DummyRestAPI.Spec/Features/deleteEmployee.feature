Feature: Delete Employee
	It is possible to delete employee record from the system.

Scenario: Delete employee of given id
	Given employee rest API
	When DELETE endpoint is called with valid id 10
	Then employee of id 10 is deleted