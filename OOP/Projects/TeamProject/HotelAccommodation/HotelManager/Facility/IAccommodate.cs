using HotelManager.Person;

namespace HotelManager.Facility
{
    interface IAccommodate
    {
        string FacilityName { get; set; }

        Room CheckIn(Client client);

        bool CheckOut(Client client);

        void CreateRoom(Room room, ushort numberToCreate);

        void RemoveRoom(ushort roomNumber);

        void AddRoomsToFacility(Room room, ushort numberToCreate);
    }
}