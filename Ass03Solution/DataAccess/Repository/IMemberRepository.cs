using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        Member Login(string email, string password);
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int memberID);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberID);
    }
}
