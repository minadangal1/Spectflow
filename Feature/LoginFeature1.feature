Feature: LoginFeature1
	

@mytag
@mytag
Scenario: I try to Login account using Valid and invalid UserName and Password
	Given I am Navigate to the Url "http://demo.guru99.com/V1/index.php";
	And I enter the Login information
	| UserId     | Password | Status  |
	| mngr318486 | UrYgYpA  | Valid   |
	| asgdkdga   | sjvaam   | Invalid |
	|            | UrYgYpA  | Invalid |
	| mngr318486 | UrYgYpA  | Valid   |
    Then the click the login button

