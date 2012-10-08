using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ModelBinding.Binders;

namespace EmptyOptionalParameterModelBinding.Controllers
{
    
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get(
            [FromUri(BinderType = typeof(TypeConverterModelBinder))] string q = null,
            [FromUri(BinderType = typeof(TypeConverterModelBinder))] int? value = null)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

           

            return new string[] { value.HasValue ? value.Value.ToString() : "", q };
        }

     
    }

    public class NullParamaterModelBinder : System.Web.Http.ModelBinding.IModelBinder
    {
        public NullParamaterModelBinder()
        {

        }

        public bool BindModel(
            System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext)
        {
           
                return true;
            
        }
    }
}