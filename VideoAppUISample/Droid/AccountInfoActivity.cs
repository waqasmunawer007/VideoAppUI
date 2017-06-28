
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
	[Activity(Label = "AccountInfoActivity",ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class AccountInfoActivity : AppCompatActivity, ITextWatcher
	{
		private EditText mVorNameEditText;
		private EditText mNachNameEditText;
		private Button mWeiterButton;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_account_info);
			mWeiterButton = FindViewById<Button>(Resource.Id.weiter_button);
			mVorNameEditText = FindViewById<EditText>(Resource.Id.vorname_edittext);
			mNachNameEditText = FindViewById<EditText>(Resource.Id.nachname_edittext);
			mVorNameEditText.AddTextChangedListener(this);
			mNachNameEditText.AddTextChangedListener(this);
			
			mWeiterButton.Click += delegate
			{
				StartActivity(typeof(SelectUserGroupActivity));
			};
		}
		
		void checkFieldsForEmptyValues()
		{
			string email = mVorNameEditText.Text;
			string password = mNachNameEditText.Text;
			if (email.Equals("") || password.Equals(""))
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
