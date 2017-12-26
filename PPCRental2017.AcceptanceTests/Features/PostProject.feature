@automated
Feature: PostProject
	I input value and save successfull

Background:
	Given the following account
		| Email         | Password | FullName | Phone      | Address            | Role |
		| pet@gmail.com | 1        | Pet      | 0919413913 | 123456 Nguyễn Trãi | 1    |
	Given the following properties
	| PropertyName      | CodeType | Avatar | District | Street         | Ward        | Status     |
	| Coconut's Project | 1        |        | Ba Vì    | Điền Viên Thôn | TT Tây Đằng | Chưa duyệt |
Scenario: Post Project Successfully
	When I am at Home page
	And I have navigate to Login Page
	And I entered 'pet@gmail.com' and '1'
	And I have navigate to Post Page
	And I entered the following information
	| Name          | Value                                        |
	| PropertyName  | Banana's Project                             |
	| Property Type | 1                                            |
	| Content       | You will feel comfortable when you come here |
	| Street        | Điền Viên Thôn                               |
	| Ward          | TT Tây Đằng                                  |
	| Ditrict       | Ba Vì                                        |
	| Price         | 1000                                         |
	| Area          | 1000                                         |
	| Bedroom       | 2                                            |
	| Bathroom      | 2                                            |
	| Packing Place | 1                                            |
	And I have navigate to View List of Agency Project
	Then The list of properties shoul have my new property
	| PropertyName      | CodeType | Avatar | District | Street         | Ward        | Status     |
	| Coconut's Project | 1        |        | Ba Vì    | Điền Viên Thôn | TT Tây Đằng | Chưa duyệt |
	| Banana's Project  | 1        |        | Ba Vì    | Điền Viên Thôn | TT Tây Đằng | Chưa duyệt |
	
