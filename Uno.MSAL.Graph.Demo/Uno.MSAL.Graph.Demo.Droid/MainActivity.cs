using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Views;
using Microsoft.Identity.Client;

namespace Uno.MSAL.Graph.Demo.Droid
{
    [Activity(
            MainLauncher = true,
            ConfigurationChanges = Uno.UI.ActivityHelper.AllConfigChanges,
            WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden
        )]
    public class MainActivity : Windows.UI.Xaml.ApplicationActivity
    {
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            AuthenticationContinuationHelper.SetAuthenticationContinuationEventArgs(requestCode, resultCode, data);
        }
    }
}

