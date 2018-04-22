﻿using System.Collections.Generic;
using System.Text;

namespace FcmSharp.Http.Builder
{
    public static class HttpRequestUtils
    {
        public static string ReplaceSegments(string resource, IList<UrlSegment> segments)
        {
            string url = new string(resource.ToCharArray());

            foreach (var segment in segments)
            {
                url = url.Replace(segment.name, segment.value);
            }

            return url;
        }

        public static string BuildQueryString(string resource, IDictionary<string, string> parameters)
        {
            var builder = new StringBuilder();

            bool first = true;
            foreach (var parameter in parameters)
            {
                builder.Append(first ? "?" : "&");

                first = false;

                builder.Append(parameter.Key);
                builder.Append("=");
                builder.Append(parameter.Value);
            }

            return builder.ToString();
        }
    }
}
