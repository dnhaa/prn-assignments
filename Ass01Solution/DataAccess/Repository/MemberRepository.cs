
using BusinessObject;

namespace DataAccess.Repository;


public class MemberRepository : IMemberRepository
{
    public int CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);

    public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);

    public List<MemberObject> FilterMemberByCity(string city) => MemberDAO.Instance.FilterMemberByCity(city);

    public List<MemberObject> FilterMemberByCountry(string country) => MemberDAO.Instance.FilterMemberByCountry(country);

    public MemberObject GetMemberObjectByID(int memberID) => MemberDAO.Instance.GetMemberObjectByID(memberID);

    public IEnumerable<MemberObject> GetMemberObjects() => MemberDAO.Instance.GetMemberObjectList;

    public void InsertMember(MemberObject memberObject) => MemberDAO.Instance.AddNew(memberObject);

    public MemberObject SearchMemberByEmail(string email) => MemberDAO.Instance.SearchMemberByEmail(email);

    public MemberObject SearchMemberByID(int memberID) => MemberDAO.Instance.SearchMemberByID(memberID);

    public List<MemberObject> SearchMemberByName(string memberName) => MemberDAO.Instance.SearchMemberByName(memberName);

    public void UpdateMember(MemberObject memberObject) => MemberDAO.Instance.Update(memberObject);
}
