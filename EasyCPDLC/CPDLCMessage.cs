/*  EASYCPDLC: CPDLC Client for the ISFP Network
    Copyright (C) 2021 Joshua Seagrave joshseagrave@googlemail.com
    ISFP edition Copyright (C) 2026 Interstellar Simulation Flight Platform
    https://github.com/Interstellar-Simulation-Flight-Platform/EasyCPDLC
    Modified under the GNU GPL v3; source must remain available under the same license.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyCPDLC
{
    public class CPDLCMessage : Label
    {

        public string type;
        public bool acknowledged = false;
        public string recipient;
        public string message;
        public bool outbound;
        private string storedText;

        public CPDLCResponse header;

        public CPDLCMessage()
        {

        }
        public CPDLCMessage(string _type, string _recipient, string _message, bool _outbound = false, CPDLCResponse _header = null)
        {
            type = _type;
            recipient = _recipient;
            message = _message;
            outbound = _outbound;
            header = _header;
            SetStyle(ControlStyles.Selectable, true);
        }

        public void OverrideText(string newText)
        {
            storedText = Text;
            Console.WriteLine(storedText);
            Invoke(new Action(() => Text = newText));
        }

        public void RestoreText()
        {
            Invoke(new Action(() => Text = storedText));
        }

        protected override void OnEnter(EventArgs e)
        {
            ForeColor = Color.Orange;
        }

        protected override void OnLeave(EventArgs e)
        {
            ForeColor = SystemColors.ControlDark;
        }
    }

    public class CPDLCResponse
    {
        public string DataType { get; set; }
        public int MessageID { get; set; }
        public int ResponseID { get; set; }
        public string Responses { get; set; }

    }

    public class AccessibleLabel : Label
    {
        private readonly Color foreColor;
        public AccessibleLabel(Color _foreColor)
        {
            SetStyle(ControlStyles.Selectable, true);
            foreColor = _foreColor;
        }

        protected override void OnEnter(EventArgs e)
        {
            ForeColor = Color.Orange;
        }

        protected override void OnLeave(EventArgs e)
        {
            ForeColor = foreColor;
        }
    }
}
