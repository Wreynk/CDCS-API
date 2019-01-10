#region

using System.Collections.Generic;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

#endregion

namespace Cdcs.API.Helpers {

    public class LowercaseDocumentFilter : IDocumentFilter {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context) {
            var paths = swaggerDoc.Paths;

            //	generate the new keys
            var newPaths   = new Dictionary<string, OpenApiPathItem>();
            var removeKeys = new List<string>();

            foreach (KeyValuePair<string, OpenApiPathItem> path in paths) {
                string newKey = path.Key.ToLower();

                if (newKey == path.Key) continue;
                removeKeys.Add(path.Key);
                newPaths.Add(newKey, path.Value);
            }

            //	add the new keys
            foreach (KeyValuePair<string, OpenApiPathItem> path in newPaths) swaggerDoc.Paths.Add(path.Key, path.Value);

            //	remove the old keys
            foreach (string key in removeKeys) swaggerDoc.Paths.Remove(key);
        }
    }

}