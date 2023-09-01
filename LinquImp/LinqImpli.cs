using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinquImp
{
    public class LinqImpli
    {

        public void Linq()
        {
            List<string> list = new List<string>() {
            " Hii JavaTpoint",
            " Welcome to JavaTpoint ",
            " The topic is LINQ ",
            " Any Queries "


        };
          //  var v = from i in list where i.Contains("JavaTpoint") select i;

            var v = list.Where(a => a.Contains(" JavaTpoint "));


            foreach ( var i in v )
            {
                Console.WriteLine( i );
            }
        }
    }
}