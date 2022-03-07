Feature: JobSearch

@UIApp
Scenario Outline: Qa Automation Job
	Given Click on CareerLink
	And Enter "<JobTitle>" to search and Select Job from Results
	And Verify "<JobId>" "<JobTitle>" "<JobLocation>" and JobDecription and tools
	When Click on Apply now
	Then Verify "<JobId>" "<JobTitle>" "<JobLocation>" and Click Return job Search

	Examples:
		| JobId    | JobTitle               | JobLocation                          |
		| 22-78060 | QA Automation Engineer | Boston, Massachusetts, United States | 

@mytag
Scenario: API Post and Get
	Given Post request
	And Get Reuest