# Basic MD syntax
https://www.markdownguide.org/cheat-sheet/#basic-syntax

# Extended MD syntax
https://www.markdownguide.org/cheat-sheet/#extended-syntax


# DDD
Domain Driven Design Practice

Ideas project

A Library Management System - https://itechindia.co/blog/what-features-should-your-library-management-system-have/

sale management system requirement

Inventory Management system
Core Functionality
Real-time inventory tracking: Accurate and up-to-date visibility of stock levels across multiple locations.
Purchase order management: Streamlined process for creating, tracking, and receiving purchase orders.
Sales order processing: Efficiently manage sales orders, including order fulfillment, shipping, and invoicing.   
Barcode scanning: Automate data entry and reduce errors using barcode technology.   
Lot and serial number tracking: Trace specific items for quality control, recalls, or warranty purposes.   
Advanced Features
Demand forecasting: Predict future inventory needs based on historical sales data and market trends.   
Reorder point management: Automatically generate purchase orders when stock levels reach predefined thresholds.   
Warehouse management: Optimize storage space and improve picking efficiency.   
Integration with other systems: Seamlessly connect with accounting, point-of-sale, and shipping software.   
Reporting and analytics: Generate customizable reports to analyze inventory performance, identify trends, and make data-driven decisions.   
Additional Considerations
Cloud-based or on-premise: Choose the deployment option that best suits your business needs and IT infrastructure.
Mobile access: Enable remote inventory management and real-time updates.   
Scalability: Ensure the system can accommodate future growth and changing requirements.
Security: Protect sensitive inventory data with robust security measures.
User-friendly interface: A simple and intuitive interface can improve adoption and productivity.


## Business requirements
<ul>
	<li>
		<b>these are the requirement from the business side</b>
	</li>
	<li>
		<b>Developers need to figure out who to build these features, and put those requirements into the system requirements</b>
	</li>
</ul>


### Core Functionality

#### Task Creation

- Users should be able to create new tasks with a tile, description, asignee, priority and due date.

#### Task Management

- Users should be able to view, edit, and delete existing tasks.
- User should be able to assign permission to view and edit to other users or groups.

#### Task Prioritization

- Users should be able to prioritize task based on the importance, urgency, effort, and time.

#### Task Completion

- Users Should be able to mark tasks as completed or incomplete.

#### Task Categorization

- Users should be able to categorize tasks into different projects or categories

#### Task Reminders

- Users should be able to set reminder for upcoming 

### Additional  Functionality

- Task Search and Filtering: Users should be able to search for tasks by keyword or filter tasks by category, due date, or priority.
- Multiple Users and Shared Tasks: Users should be able to create multiple user accounts and share tasks with other users.
- Integration with Other Applications: The app should be able to integrate with other productivity tools, such as calendars or email clients.
- Offline Functionality: The app should be able to function offline, allowing users to create, edit, and view tasks without an internet connection.
- Customization Options: Users should be able to customize the appearance of the app, such as changing the theme or font.


### Non-Functional Requirements

- User Interface: The app should have a clean, intuitive, and user-friendly interface.
- Performance: The app should perform well, even when handling a large number of tasks.
- Security: The app should have robust security measures to protect user data.
- Accessibility: The app should be accessible to users with disabilities.
- Scalability: The app should be able to scale to accommodate a growing user base.


## System requirements

- The system needs a mechanism to manage users, user roles and permissions, user machines potentially
- The system needs a mechanism to manage tasks, task belong to specific users, and all the details related to the tasks
- The system needs a queue service to manage all the flows events, and services interact with each other.


## System Quality Requirements

- Functionality/Efficiency/Usability
- Security
- Testability
- Observability
- Reliability
- Scalability
- Extendability
- Performance
- Portability
- Maintainability


## SDLC requirements

	Development
		FrontEnd:
			VueJS
		Backend:
			dotnet API
		Service Queue
			RabbitMQ
			masstransit

	Testing
		Unit Testing
		Integration testing

	Deployment
		CI/CD - github action, Azure
			again: 
				 CI is about automation of Integration
					In this stage (very important during development), you can 
					- check the version control, 
					- build the application, 
					- run the test, run the ingration test, run all sort of test
					- Run code analysis, code coverage (Sonarqube), Security Check - container or bundler (Snyk)
				 CD is about automation of deployment
					In this state, you can
					- build the app,
					- run the checks, tests
					- publish the actifact and deploy it to production mode
					- Run the monitoring to ensure the system is working properly.
	Monitoring
		- dashboard to check error logs, error rate, through put, performance metrics
