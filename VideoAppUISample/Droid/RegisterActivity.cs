
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Text;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "RegisterActivity" , ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class RegisterActivity : AppCompatActivity, ITextWatcher
	{
		private EditText mEmailEditText;
		private EditText mPasswordEditText;
        private ImageView mTermImageView;
		private Button mWeiterButton;
        bool ifTermsSelected = false;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_register_account);
            mTermImageView = FindViewById<ImageView>(Resource.Id.terms_imageview);
            mWeiterButton = FindViewById<Button>(Resource.Id.weiter_button);
			mEmailEditText = FindViewById<EditText>(Resource.Id.email_account_edittext);
			mPasswordEditText = FindViewById<EditText>(Resource.Id.password_account_edittext);
			mEmailEditText.AddTextChangedListener(this);
			mPasswordEditText.AddTextChangedListener(this);
           
			mWeiterButton.Click += delegate
			{
				StartActivity(typeof(AccountInfoActivity));
			};
            mTermImageView.Click += delegate {
                if (ifTermsSelected)
                {
					mTermImageView.SetBackgroundResource(Resource.Drawable.ic_check_circle_deactivate);
                    ifTermsSelected = false;
                }
                else
                {
					mTermImageView.SetBackgroundResource(Resource.Drawable.ic_check_circle_activate);
                    ifTermsSelected = true;
                }
				checkFieldsForEmptyValues();
               
            };
		}
		private bool IsValidEmail()
		{
			return true;
		}
		void checkFieldsForEmptyValues()
		{
			string email = mEmailEditText.Text;
			string password = mPasswordEditText.Text;
			if (email.Equals("") || password.Equals("") || !ifTermsSelected)
			{
				mWeiterButton.Alpha = 0.7f;
				mWeiterButton.Enabled = false;
			}
			else
			{
				mWeiterButton.Alpha = 1.0f;
				mWeiterButton.Enabled = true;
			}
		}
		#region ITextWatcher
		public void AfterTextChanged(IEditable s)
		{
			checkFieldsForEmptyValues();
		}
		public void BeforeTextChanged(ICharSequence s, int start, int count, int after) { }
		public void OnTextChanged(ICharSequence s, int start, int before, int count) { }
		#endregion
	}
}
