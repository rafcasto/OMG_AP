Feature: AP_ADMIN_ADS
	As an advertiser,
	I want to be able to add a Group Buying Tipping level to my promotional offer 
	so that my deal would only take effect if the specified Tipping level is reached

Background: 
Given User navigate to the AP's admin website 
When User authenticates as "admin"
Then User lands in the admin dashboard



@UI @Ads @GroupBuying
Scenario: Create a Group buying deal
	Given User Navigates to "Ads" menu
		And User clicks on "Add Ads" submenu
	When User completes the form 
	| key   |
	| value |
	Then User Success message 