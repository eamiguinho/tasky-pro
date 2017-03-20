Feature: Adding a task
  I want to be able to quickly add a task


Scenario: Add a task
    Given I am on the Home screen
    When I add a new task called "Get Milk"
    And I save the task
    Then I should see the "Get Milk" task in the list


Scenario Outline: Add more than one task
    Given I am on the Home screen
    When I add a new task called <task_name>
    And I save the task
    Then I should see the <task_name> task in the list

    Examples:
    |task_name|
    |"Get Milk"|
    |"Get Pizza"|
