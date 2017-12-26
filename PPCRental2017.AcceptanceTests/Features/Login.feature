Feature: Login
	I want to be login successfully


Background:
	Given the following account
	| Email         | Password | FullName | Phone      | Address            | Role |
	| pet@gmail.com | 1        | Pet      | 0919413913 | 123456 Nguyễn Trãi | 1    |
Scenario: Login successfully
	When I am at Home page
	And I have navigate to Login page
	And I entered 'Pet@gmail.com' and '1'

