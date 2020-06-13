using Android.App;
using Android.Content;
using Microsoft.Identity.Client;

namespace Uno.MSAL.Graph.Demo.Droid
{
    [Activity]
    [IntentFilter(new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryBrowsable, Intent.CategoryDefault },
        DataHost = "Uno.MSAL.Graph.Demo",
        DataScheme = "msauth")]
    public class MsalActivity : BrowserTabActivity
    {
    }
}