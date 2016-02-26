using System;
namespace RoomCalculatorApplication
{
    class Room
    {
        
        double roomlength;
        double roomwidth;
        double roomheight;
        double doorwidth;
        double doorheight;
        double windowwidth;
        double windowheight;
        double paintneeded;
        public void Acceptdetails()
           {
           roomlength = 4.5;
           roomwidth = 3.5;
           roomheight = 2.5;
            doorwidth = 0.9;
            doorheight = 1.85;
             windowwidth = 1.0;
             windowheight = 1.3;
            paintneeded = GetRoomTrueArea() / 11;

           }

        public double GetFloorArea()
        {
            return roomlength * roomwidth;
        } 
        public double GetWallAreaWide()
        {
            return roomwidth * roomheight;
        }
        public double GetWallAreaLength()
        {
            return roomlength * roomheight;
        }
        public double GetDoorArea()
        {
            return doorheight * doorwidth;
        }
        public double GetWindowArea()
        {
            return windowheight * windowwidth;
        }
        public double GetRoomVolume()
        {
            return roomlength * roomwidth * roomheight;
        }
        public double GetRoomTrueArea()
        {
            return GetWallAreaWide() + GetWallAreaWide() + GetWallAreaLength() + GetWallAreaLength() - GetDoorArea() - GetWindowArea();
        }
      

    

        public void Display()
        {
            Console.WriteLine("Borwell Software Challenge Submission");
            Console.WriteLine("");
            Console.WriteLine("Room's length: {0} metres", roomlength);
            Console.WriteLine("Room's width: {0} metres", roomwidth);
            Console.WriteLine("Room's height: {0} metres", roomheight);
            Console.WriteLine("Room's floor Area: {0} metres squared", GetFloorArea());
            Console.WriteLine("Room's wall area widthways: {0} metres squared", GetWallAreaWide());
            Console.WriteLine("Room's wall area lengthways: {0} metres squared", GetWallAreaLength());
            Console.WriteLine("Room's volume: {0} metres cubed", GetRoomVolume());
            Console.WriteLine("Door area: {0} metres squared", GetDoorArea());
            Console.WriteLine("Window area: {0} metres squared", GetWindowArea());
            Console.WriteLine("Room's true area (room area not including floor, door and window): {0} metres squared", GetRoomTrueArea());
            Console.WriteLine("Room's total paint needed (1 litre per 11 square litres): {0} litres", paintneeded);

        }
    }

    class ExecuteRoom
     {
        static void Main(string[] args)
           {
            Room r = new Room();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
           }
     }
}