using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMemberObjects();
        MemberObject GetMemberObjectByID(int memberID);
        void InsertMember(MemberObject memberObject);
        void UpdateMember(MemberObject memberObject);
        void DeleteMember(int memberID);
        MemberObject SearchMemberByID(int memberID);
        MemberObject SearchMemberByEmail(string email);
        List<MemberObject> SearchMemberByName(string memberName);
        List<MemberObject> FilterMemberByCity(string city);
        List<MemberObject> FilterMemberByCountry(string country);
        int CheckLogin(string email, string password);
    }
}
