using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace M.Helper.Swagger
{
    /// <summary>
    /// 自定义Swagger隐藏过滤器
    /// </summary>
    public class HiddenApiFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (ApiDescription apiDescription in context.ApiDescriptionsGroups.Items.SelectMany(e => e.Items))
            {
                if (apiDescription.ControllerAttributes().OfType<HiddenApiAttribute>().Count() == 0
                    && apiDescription.ActionAttributes().OfType<HiddenApiAttribute>().Count() == 0) continue;
                var key = "/" + apiDescription.RelativePath.TrimEnd('/');
                if (!key.Contains("/test/") && swaggerDoc.Paths.ContainsKey(key))
                {
                    swaggerDoc.Paths.Remove(key);
                }
            }
        }
    }
}