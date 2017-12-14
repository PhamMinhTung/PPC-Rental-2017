@automated
Feature: PostProject
	I input value and save successfull

Background:
	Given I am login
		| Email                    | Password |
		| lithihuyenchau@gmail.com | 123456   |
Scenario: Post Project successfull
	When I click button post
	And I input value into form
	| Name          | Value                                        |
	| Property Name | Coconut's Project                            |
	| Property Type | 1                                            |
	| Content       | You will feel comfortable when you come here |
	| Street        | 1                                            |
	| Ward          | 1                                            |
	| Ditrict       | 1                                            |
	| Price         | 1000                                         |
	| Area          | 1000                                         |
	| Bedroom       | 2                                            |
	| Bathroom      | 2                                            |
	| Packing Place | 1                                            |
	And I press create
	Then System show Home page
