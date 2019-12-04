using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using static Android.App.DatePickerDialog;


namespace Study_Now
{
    [Activity(Label = "@string/Study_Now", Theme = "@style/MyTheme", Icon="@drawable/CalendarIcon", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnDateSetListener
    {
        private const int DATE_DIALOG = 1;
        private int year, month, day;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button add = FindViewById<Button>(Resource.Id.add);
            add.Click += delegate
            {
                ShowDialog(DATE_DIALOG);
            };

        }

        protected override Dialog OnCreateDialog(int id)
        {
            switch (id)
            {
                case DATE_DIALOG:
                    {
                        return new DatePickerDialog(this, this, year, month, day);
                    }
                    break;
                default:
                    break;
            }
            return null;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        // Will ouput to a user when a date has been selected
        public void OnDateSet(DatePicker view, int y, int m, int d)
        {
            this.year = y;
            this.month = m;
            this.day = d;
            Toast.MakeText(this, "You have selected: " + day + "/" + month + "/" + year, ToastLength.Short).Show();
        }
    }

}