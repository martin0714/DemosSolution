using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var str = Console.ReadLine();
            //str = HtmlStringEncode(str);
            //Console.WriteLine(str);
//            string str = @"&amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; width=&amp;quot;790&amp;quot; height=&amp;quot;316&amp;quot; src=&amp;quot;/Purchase/img/Description/迪士尼宝宝790(9).jpg&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; width=&amp;quot;790&amp;quot; height=&amp;quot;657&amp;quot; src=&amp;quot;/Purchase/img/Description/3(2136).jpg&amp;quot; /&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; width=&amp;quot;790&amp;quot; height=&amp;quot;657&amp;quot; src=&amp;quot;/Purchase/img/Description/4(1783).jpg&amp;quot; /&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3474.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3475.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3477.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3479.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3482.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3487.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;lt;img alt=&amp;quot;&amp;quot; width=&amp;quot;790&amp;quot; height=&amp;quot;527&amp;quot; src=&amp;quot;/Purchase/img/Description/828A3488.JPG&amp;quot; /&amp;gt;&amp;lt;/p&amp;gt;
//                            &amp;lt;p&amp;gt;&amp;amp;nbsp;&amp;lt;/p&amp;gt;";
//            str = HtmlStringDecode(HtmlStringDecode(str));
            var str =
                @"异常Sql:insert into T_ProductSKU([ProductId],[SKUId],[SKUProperty],[SkuStatus],[IsValid],[Creater],[Updater],[RowCreateTime],[RowModifyTime],[SkuPicDetailStatus]) values('141232','141248','<T_ProductSKU><SaleChannel><SaleChannel_Default><![CDATA[100]]></SaleChannel_Default></SaleChannel><SaleArea><SaleArea_Default><![CDATA[1]]></SaleArea_Default></SaleArea><ReturnType><ReturnType_Default><![CDATA[1]]></ReturnType_Default></ReturnType><Color><Color_Old><![CDATA[浅咖条纹]]></Color";
            var productId = GetProductIdFromMsg(str);
            Console.WriteLine(productId);
            Console.ReadLine();
        }


        //html转码
        public static string HtmlStringEncode(string str)
        {
            return HttpUtility.HtmlEncode(str);
        }

        //html解码
        public static string HtmlStringDecode(string htmlString)
        {
            return HttpUtility.HtmlDecode(htmlString);
        }


        public static string GetProductIdFromMsg(string errorMsg)
        {
            var startIndex = errorMsg.IndexOf("('");
            var endIndex = errorMsg.IndexOf("',");
            var productId = errorMsg.Substring(startIndex + 2, endIndex - startIndex-2);
            return productId;
        }



    }
}
