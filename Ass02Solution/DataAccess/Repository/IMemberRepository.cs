using System.Collections;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberById(int memberId);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}
