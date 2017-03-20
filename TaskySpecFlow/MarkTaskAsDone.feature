Feature: Mark Task as Done
	This will mark the task as done
	
Scenario: Mark as Done
	Given I am on the Home screen
	When I add a new task called "Get Milk"
    And I save the task
    Then I should see the "Get Milk" task in the list
	And I tap the task "Get Milk"
	When I check it as done
	And I save the task
	Then I should see the "Get Milk" task marked as done in the list
