﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member Login(string email, string password) => MemberDAO.Instance.Login(email, password);
        public Member GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();
        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
    }
}
