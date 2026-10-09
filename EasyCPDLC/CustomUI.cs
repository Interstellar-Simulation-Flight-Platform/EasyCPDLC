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
using System.Drawing;
using System.Windows.Forms;

namespace EasyCPDLC
{
    public class CustomUI
    {
        public static UITextBox CreateTextBox(string _text, int _maxLength, Color _controlFrontColor, Color _controlBackColor, Font _font)
        {
            UITextBox _temp = new(_controlFrontColor)
            {
                BackColor = _controlBackColor,
                ForeColor = _controlFrontColor,
                Font = _font,
                MaxLength = _maxLength,
                BorderStyle = BorderStyle.None,
                Text = _text,
                CharacterCasing = CharacterCasing.Upper,
                Top = 10,
                Padding = new Padding(3, 0, 3, -10),
                Margin = new Padding(3, 5, 3, -10),
                Height = 20,
                TextAlign = HorizontalAlignment.Center
            };

            using (Graphics G = _temp.CreateGraphics())
            {
                _temp.Width = (int)(_temp.MaxLength *
                              G.MeasureString("x", _temp.Font).Width);
            }

            return _temp;
        }

        public static Label CreateTemplate(string _text, Color _controlFrontColor, Color _controlBackColor, Font _font)
        {
            Label _temp = new()
            {
                BackColor = _controlBackColor,
                ForeColor = _controlFrontColor,
                Font = _font,
                AutoSize = true,
                Text = _text,
                Top = 10,
                Height = 20,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(0, 10, 0, 0),
                Margin = new Padding(0, 0, 0, 0)
            };

            return _temp;
        }
    }
}
