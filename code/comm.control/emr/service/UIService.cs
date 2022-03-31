﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Windows.Forms.Design;

namespace Common.Controls.Emr
{
    public class UIService : IUIService
    {
        System.Windows.Forms.Form mainForm = null;
        Hashtable styles = null;

        public UIService(System.Windows.Forms.Form mainForm)
        {
            this.mainForm = mainForm;

            styles = new Hashtable();
            styles.Add("DialogFont", new Font("Tahoma", 8.25F, FontStyle.Regular));
            styles.Add("HighlightColor", Color.FromArgb(255, 251, 233));
        }

        public bool CanShowComponentEditor(object component)
        {
            return false;
        }

        public System.Windows.Forms.IWin32Window GetDialogOwnerWindow()
        {
            return mainForm;
        }

        public void SetUIDirty()
        {
            
        }

        public bool ShowComponentEditor(object component, System.Windows.Forms.IWin32Window parent)
        {
            return false;
        }

        public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.Form form)
        {
            return form.ShowDialog(mainForm);
        }

        public void ShowError(System.Exception ex, string message)
        {
            MessageBox.Show(mainForm, "Piped error: " + message + Environment.NewLine + Environment.NewLine + ex.ToString());
        }

        public void ShowError(System.Exception ex)
        {
            MessageBox.Show(mainForm, "Piped error: " + ex.ToString());
        }

        public void ShowError(string message)
        {
            MessageBox.Show(mainForm, "Piped error: " + message);
        }

        public System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons buttons)
        {
            return MessageBox.Show(mainForm, message, caption, buttons, MessageBoxIcon.Information);
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(mainForm, message, caption);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(mainForm, message);
        }

        public bool ShowToolWindow(System.Guid toolWindow)
        {
            return false;
        }

        public System.Collections.IDictionary Styles
        {
            get
            {
                return styles;
            }
        }
    }
}
