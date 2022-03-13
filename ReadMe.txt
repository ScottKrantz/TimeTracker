Time Tracker is an ASP.NET MVC application that tracks the time spent on projects. It stores the data in a Postgres database and is capable of multiple user accounts. 

A user in the Administrator role can see the time each user has spent on a particular project. 

A user in the Project Manager role can see the time each user has spent on a project they manage.

The first screen is a log in page.

When an individual user has logged in they will see a list of their projects. They can start or stop the timer from this page.

When an Administrator or Project Manager logs in they will see a dashboard page that will give usage statistics. Administrators will see everyone's stats and Project Managers will only see stats for the people logging time on one of their projects.

Administrators and Project Managers can log time spent on projects.

A sidebar gives each user access to a Projects page where they can log time and to a statistics page. A non-Administrator or non-Project Manager will only see their statistics.

The statistics will include total time spent on each project, average session time, average daily total, daily total for each day, average total time for each day of the week, longest session, shortest session, longest session for each day of the week, shortest session for each day of the week, the number of days they've worked on the project, the age of the project in days, and daily goal.

Clicking on the project name goes to a page showing a history of time logged for it. Administrators can see the list with all users. Project Managers can see the list with all users but only for projects assigned to them. Individual users can only see their time.

The project page shows each project on a separate row with a green start button on the left. The project name appears in the middle. Clicking on the project name goes to the page showing a history of time logged for that project. The daily total appears on the right. This area is blank if the start button has not been clicked that day. When the start button is clicked, the daily total starts counting up. When the start button is clicked, it will turn into a red stop button. The daily total section will stop counting up when the stop button is clicked.

Administrators and Project Managers have a Create Project button at the top of the screen.

------------------------------------------------------------------------
|     -                                                                |
|    / \                                                               |
|   |   |                    Project Name              Daily Total     |
|    \ /                                                               |
|     -                                                                |
|----------------------------------------------------------------------|
|     -                                                                |
|    / \                                                               |
|   |   |                    Project Name              Daily Total     |
|    \ /                                                               |
|     -                                                                |
|----------------------------------------------------------------------|
|     -                                                                |
|    / \                                                               |
|   |   |                    Project Name              Daily Total     |
|    \ /                                                               |
|     -                                                                |
------------------------------------------------------------------------

The project history page shows a list of time logged for that project. Individual users will see the date, start time, end time, duration, an edit button, and a delete button. The value in the date column is end day for that time block. Clicking the edit button goes to another page that allows the user to update the start time and/or the end time. Clicking the delete button goes to another page that asks if the user is sure they want to delete the entry. An Administrator or Project Manager can remove a user's access to the edit and/or delete buttons.

Administrators and Project Managers see the user's name in the far left column. All the other columns are the same. Administrators can see everyone's logged time. Project Managers can see the logged time for everyone on their projects. Administrators and Project Managers can edit the start and/or end times they see on their lists. As well as delete them.

------------------------------------------------------------------------
|                                                                      |
|    Date       Start Time       End Time        Duration      Edit |  |
|                                                              Delete  |
|----------------------------------------------------------------------|
|                                                                      |
|    Date       Start Time       End Time        Duration      Edit |  |
|                                                              Delete  |
|----------------------------------------------------------------------|
|                                                                      |
|    Date       Start Time       End Time        Duration      Edit |  |
|                                                              Delete  |
------------------------------------------------------------------------

Administrators and Project Managers have access to a page that lists all the individual users with a Create User button at the top. Administrators can edit and delete user and Project Manager records.