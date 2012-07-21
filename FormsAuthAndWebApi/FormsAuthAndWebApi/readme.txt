The web config has forms enabled but don't put the Authorise nodes in the webconfig e.g. deny "?". 

Instead you need to use the two versions of the Authorise attribute MVC Web [System.Web.Mvc.Authorize] Web API [System.Web.Http.Authorize] in the controllers AND/OR in the global filters