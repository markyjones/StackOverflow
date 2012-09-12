Related to question http://stackoverflow.com/questions/12374657/how-do-i-do-rpc-style-asp-net-web-api-calls-properly/12383845#12383845

Shows a self host webapi project handling RPC calls as well as rest end point.

This example can be tested by debuged and watching the output.

Request 1:

Fiddler params:

POST http://localhost:8080/api/TaskInstanceQueue/Queue
Headers: 

User-Agent: Fiddler
Content-Type: application/json
Host: localhost:8080
Content-Length: 18

Request Body:

{ "test": "value"}

Output to console "Queue Method entered!"

Request 2:

POST http://localhost:8080/api/TaskInstanceQueue
Headers: 

User-Agent: Fiddler
Content-Type: application/json
Host: localhost:8080
Content-Length: 18

Request Body:

{ "test": "value"}

Output to console "REST Post Method entered!"

Request 3:

Fiddler params:

GET http://localhost:8080/api/TaskInstanceQueue/1
Headers: 

User-Agent: Fiddler
Accept: application/json
Host: localhost:8080

Request Body:

NULL

Output to console "Method entered!1"
