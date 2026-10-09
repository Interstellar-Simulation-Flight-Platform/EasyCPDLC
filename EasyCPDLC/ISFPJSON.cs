#pragma warning disable IDE1006 // Naming Styles

/*  EASYCPDLC: CPDLC Client for the ISFP Network
    Copyright (C) 2022 Joshua Seagrave joshseagrave@googlemail.com
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

namespace EasyCPDLC
{

    public class ISFPRootobject
    {
        public ISFPGeneral general { get; set; }
        public Pilot[] pilots { get; set; }
        public Controller[] controllers { get; set; }
    }

    public class ISFPGeneral
    {
        public int version { get; set; }
        public string generate_time { get; set; }
        public int connected_clients { get; set; }
        public int online_pilot { get; set; }
        public int online_controller { get; set; }
    }

    public class Pilot
    {
        public int cid { get; set; }
        public string callsign { get; set; }
        public string real_name { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int altitude { get; set; }
        public int ground_speed { get; set; }
        public int heading { get; set; }
        public bool on_ground { get; set; }
        public string transponder { get; set; }
        public string assigned_squawk { get; set; }
        public string logon_time { get; set; }
        public ISFPFlight_Plan flight_plan { get; set; }
    }

    public class ISFPFlight_Plan
    {
        public int id { get; set; }
        public int cid { get; set; }
        public string callsign { get; set; }
        public string flight_rules { get; set; }
        public string aircraft { get; set; }
        public int cruise_tas { get; set; }
        public string departure { get; set; }
        public int departure_time { get; set; }
        public string altitude { get; set; }
        public string arrival { get; set; }
        public string route_time_hour { get; set; }
        public string route_time_minute { get; set; }
        public string fuel_time_hour { get; set; }
        public string fuel_time_minute { get; set; }
        public string alternate { get; set; }
        public string remarks { get; set; }
        public string route { get; set; }
        public bool locked { get; set; }
        public bool from_web { get; set; }
    }

    public class Controller
    {
        public int cid { get; set; }
        public string callsign { get; set; }
        public string real_name { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int rating { get; set; }
        public string rating_label { get; set; }
        public int facility { get; set; }
        public string facility_label { get; set; }
        public int frequency { get; set; }
        public int range { get; set; }
        public bool is_atis { get; set; }
        public string atis_letter { get; set; }
        public string logon_time { get; set; }
    }

}
