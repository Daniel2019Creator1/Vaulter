﻿/* 
 * Vaulter - Save Editor for the unpacked Fallout Shelter save files
 *
 * Copyright (C) 2015 Grahame White
 *
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*
* The full text of the license can be viewed at:
* http://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html
*
* Or in the LICENSE file
*/

using System;
using System.Collections.Generic;

namespace Valuter
{
	/// <summary>
	/// Description of Cycle.
	/// </summary>
	public class Cycle
	{
		public string cycleType { get; set; }
		public int taskId { get; set; }
		public List<Object> teamEncounters { get; set; }
		public List<Object> inProgress { get; set; }
		public List<Object> pendingCycles { get; set; }
		
		public Cycle()
		{
		}
	}
}
