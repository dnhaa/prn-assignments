using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int MemberId) => MemberDAO.Instance.RemoveMember(MemberId);

        public Member GetMemberById(int memberId) => MemberDAO.Instance.GetMemberById(memberId);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMember(Member member) => MemberDAO.Instance.AddNewMember(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}
