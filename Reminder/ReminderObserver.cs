using System;
using System.Windows.Forms;

namespace Reminder
{
    public sealed class ReminderObserver // sealed ve public olarak işaretlendi
    {
        private readonly Form _targetForm;
        private readonly System.Windows.Forms.Timer _shakeTimer;
        private int _shakeCount;
        private readonly Point _originalLocation;

        public ReminderObserver(Form form)
        {
            _targetForm = form ?? throw new ArgumentNullException(nameof(form));
            _shakeTimer = new System.Windows.Forms.Timer { Interval = 50 };
            _shakeTimer.Tick += ShakeForm;
            _originalLocation = form.Location;
        }

        // Kesinlikle public ve doğru imzaya sahip Update metodu
        public void Update(string summary, Reminder reminder)
        {
            if (_targetForm.IsDisposed) return;

            if (_targetForm.InvokeRequired)
            {
                _targetForm.BeginInvoke(new Action(() => Update(summary, reminder)));
                return;
            }

            try
            {
                _targetForm.Text = $"[Hatırlatıcı] {summary}";
                if (reminder.IsUrgent)
                {
                    _shakeCount = 0;
                    _shakeTimer.Start();
                    System.Media.SystemSounds.Exclamation.Play();
                }
            }
            catch (ObjectDisposedException) { /* Form kapatılmışsa sessizce geç */ }
        }

        private void ShakeForm(object sender, EventArgs e)
        {
            if (_shakeCount >= 40)
            {
                _shakeTimer.Stop();
                _targetForm.Location = _originalLocation;
                return;
            }

            int offset = (_shakeCount % 2 == 0) ? 10 : -10;
            _targetForm.Left += offset;
            _shakeCount++;
        }
    }
}