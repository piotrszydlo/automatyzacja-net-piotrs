using System.Linq;

namespace PageObjectLibrary
{
    internal class PageOpen
    {
        
        internal static void Open(string url)
        {
            Browser.NavigateTo(url);
        }
    }
}