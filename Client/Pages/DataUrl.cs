using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Client.Pages
{
    public static class DataUrl
    {
        public static string ToDataUrl(this MemoryStream data, string format)
        {
            var span = new Span<byte>(data.GetBuffer()).Slice(0, (int)data.Length);
            return $"data:{format};base64,{Convert.ToBase64String(span)}";
        }

        public static byte[] ToBytes(string url)
        {
            var commaPos = url.IndexOf(',');
            if (commaPos >= 0)
            {
                var base64 = url.Substring(commaPos + 1);
                return Convert.FromBase64String(base64);
            }

            return null;
        }
    }
}
