using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Room
    {
      /// <summary>
      /// Instances
      /// </summary>
        private int RoomID;
        private int studentid;
        private int floorid;
        private bool isRoomAvailable;

        public int RoomID1 { get => RoomID; set => RoomID = value; }
        public bool IsRoomAvailable { get => isRoomAvailable; set => isRoomAvailable = value; }
        public int Studentid { get => studentid; set => studentid = value; }
        public int Floorid { get => floorid; set => floorid = value; }


        /// <summary>
        /// return the info about the room.
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"RoomID: {this.RoomID}  Available:{this.isRoomAvailable}";
        }

        


    }

    
}
