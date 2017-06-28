
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
    [Activity(Label = "LoginMainActivity")]
    public class LoginMailActivity : AppCompatActivity, ITextWatcher
    {
        private EditText mEmailEditText;
        private EditText mPasswordEditText;
        private Button mLoginButton;
        private ImageButton mBackImageButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_login_mail);
			mLoginButton = FindViewById<Button>(Resource.Id.login_button);
			mBackImageButton = FindViewById<ImageButton>(Resource.Id.back_button_imagebutton);
            mEmailEditText = FindViewById<EditText>(Resource.Id.user_email_edittext);
            mPasswordEditText = FindViewById<EditText>(Resource.Id.user_password_edittext);
            mEmailEditText.AddTextChangedListener(this);
            mPasswordEditText.AddTextChangedListener(this);
            // click button login
           
            mLoginButton.Click += delegate
            {
                if (IsValidEmail())
                {
                    StartActivity(typeof(MainActivity));
                    this.Finish();
                }
            };
            mBackImageButton.Click += delegate {
                base.OnBackPressed();
            };
            // create account
            TextView createAccount = FindViewById<TextView>(Resource.Id.registriereAccount);
            createAccount.Click += delegate
            {
                StartActivity(typeof(RegisterActivity));
            };
        }

		#region ITextWatcher & Feild Validations
		private bool IsValidEmail()
		{
			return true;
		}
		void checkFieldsForEmptyValues()
		{
			string email = mEmailEditText.Text;
			string password = mPasswordEditText.Text;
			if (email.Equals("") || password.Equals(""))
			{
				mLoginButton.Alpha = 0.7f;
				mLoginButton.Enabled = false;
			}
			else
			{
				mLoginButton.Alpha = 1.0f;
				mLoginButton.Enabled = true;
			}
		}

        public void AfterTextChanged(IEditable s)
        {
            checkFieldsForEmptyValues(); 
        }
        public void BeforeTextChanged(ICharSequence s, int start, int count, int after){}
        public void OnTextChanged(ICharSequence s, int start, int before, int count){}
        #endregion 
    }
}
