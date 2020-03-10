// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2020 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Drawing;

namespace Greenshot.Gfx.Structs
{
    /// <summary>
    /// These are extensions to help with pixels
    /// </summary>
    public static class PixelExtensions
    {
        /// <summary>
        /// Make a Brga32 from the specified color
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>Bgr32</returns>
        public static Bgra32 FromColorWithAlpha(this Color color)
        {
            return new Bgra32
            {
                A = color.A,
                R = color.R,
                G = color.G,
                B = color.B,
            };
        }

        /// <summary>
        /// Make a Brg32 from the specified color
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>Bgr32</returns>
        public static Bgr32 FromColor(this Color color)
        {
            return new Bgr32
            {
                R = color.R,
                G = color.G,
                B = color.B,
            };
        } 
    }
}