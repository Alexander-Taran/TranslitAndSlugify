using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cyrillic2Slug
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".

    public static class Slugger
    {

        public static string ToSlug(this string s)
        {

            return Regex.Replace(new string(s.Select(
                c => char.IsLetterOrDigit(c) ? c : '-'
                ).ToArray()).Trim('-'), "-+", "-").Translit();

        }
    }
}
