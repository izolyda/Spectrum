using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Spectrum.Behaviors
{
	public class UsernameValidator : Behavior<Entry>
	{
		const string regex = "^[A-Z][a-zA-Z]*$";

		protected override void OnAttachedTo(Entry entry)
		{
			entry.TextChanged += TextChanged;
			base.OnAttachedTo(entry);
		}

		private void TextChanged(object sender, TextChangedEventArgs e)
		{
            var match = Regex.Match(e.NewTextValue.ToString(), regex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

            ((Entry)sender).TextColor = match.Success ? Color.Default : Color.Red;

        }

		protected override void OnDetachingFrom(Entry entry)
		{
			entry.TextChanged -= TextChanged;
			base.OnDetachingFrom(entry);
		}

	}
}

