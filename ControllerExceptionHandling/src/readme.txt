Related to the following question http://stackoverflow.com/questions/11403028/how-should-i-handle-exceptions-within-a-controller-constructor-in-webapi/11633120#11633120

Ninject - NB the Lib folder contains a compiled version of this fork of niject https://github.com/azzlack/Ninject.Web.WebApi All the licences etc should be in the packages dir.

For option 1 demo ensure the following line is commented in NinjectWebCommon.cs:
	kernel.Bind<System.Web.Http.Dispatcher.IHttpControllerActivator>()
            .To<System.Web.Http.Dispatcher.DefaultHttpControllerActivator>().Intercept().With<ControllerCreationInterceptor>();

For option 2 ensure this line in Global.asax is commented in
	GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new YourCustomControllerActivator());

The example error is thrown at the following url: http://server/values
The example error is ArgumentNullException("TESTING")




