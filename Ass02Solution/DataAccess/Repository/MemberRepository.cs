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
        public int CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);

        public void DeleteMember(int MemberId) => MemberDAO.Instance.RemoveMember(MemberId);

        public Member GetMemberById(int memberId) => MemberDAO.Instance.GetMemberById(memberId);
        public Member GetMemberByEmail(string memberEmail) => MemberDAO.Instance.GetMemberByEmail(memberEmail);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMember(Member member) => MemberDAO.Instance.AddNewMember(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}
