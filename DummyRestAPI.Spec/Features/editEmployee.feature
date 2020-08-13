Feature: Edit Employee
	It is possible to edit existing employee, update should be sent in JSON format in request body.

Scenario: Edit employee of given id
	Given employee rest API
	When UPDATE endpoint is called with valid id 10
	Then employee of id 10 is updated