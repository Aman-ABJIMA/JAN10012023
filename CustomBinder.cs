using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace ModelBinder
{
    public class CustomBinder:IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext) //here the parameter will help us to read the incoming data, manupulate it and bind with as it is work 
        {
            var data = bindingContext.HttpContext.Request.Query;
            var result = data.TryGetValue("countries",out var country);
            if (result)
            {
                var arr = country.ToString().Split('|');
                bindingContext.Result = ModelBindingResult.Success(arr);
            }
            return Task.CompletedTask;
        }
    }
}
