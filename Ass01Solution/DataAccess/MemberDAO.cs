using BusinessObject;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> MemberObjectList = new List<MemberObject>(){
            new MemberObject{MemberID = 1, MemberName = "Do Ngan Ha", Email = "ha@fpt.edu.vn", Password = "123", City = "Ho Chi Minh", Country = "Vietnam"},
            new MemberObject{MemberID = 2, MemberName = "Zhongli", Email = "zhongli@gmail.com", Password = "123", City = "Beijing", Country = "China"},
            new MemberObject{MemberID = 3, MemberName = "Riddle Roseheart", Email = "riddle@gmail.com", Password = "123", City = "London", Country = "England"},
            new MemberObject{MemberID = 4, MemberName = "Liam Gallagher", Email = "liam@gmail.com", Password = "123", City = "Manchester", Country = "England"},
            new MemberObject{MemberID = 5, MemberName = "Kamisato Ayaka", Email = "ayaka@gmail.com", Password = "123", City = "Tokyo", Country = "Japan"},
            new MemberObject{MemberID = 6, MemberName = "Raiden Ei", Email = "ei@gmail.com", Password = "123", City = "Osaka", Country = "Japan"},
            new MemberObject{MemberID = 7, MemberName = "Barack Obama", Email = "obama@gmail.com", Password = "123", City = "Los Angeles", Country = "United States"},
            new MemberObject{MemberID = 8, MemberName = "Taylor Swift", Email = "taylor@gmail.com", Password = "123", City = "New York", Country = "United States"},
            new MemberObject{MemberID = 9, MemberName = "Doinb", Email = "doinb@gmail.com", Password = "123", City = "Beijing", Country = "China"},
            new MemberObject{MemberID = 10, MemberName = "Nguyen Binh Khiem", Email = "khiem@gmail.com", Password = "123", City = "Hai Phong", Country = "Vietnam"},
            new MemberObject{MemberID = 11, MemberName = "Ngo Quyen", Email = "quyen@gmail.com", Password = "123", City = "Hai Phong", Country = "Vietnam"},
        };

        //---------------
        //Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //-----------------
        public List<MemberObject> GetMemberObjectList => MemberObjectList;
        //----------------------
        public MemberObject GetMemberObjectByID(int memberID)
        {
            //LINQ
            MemberObject memberObject = MemberObjectList.SingleOrDefault(memberObject => memberObject.MemberID == memberID);
            return memberObject;
        }
        //-------------------------
        //Check login + authorisation --> Return MemberID, MemberID > 0
        //If logging in as admin, return 0.
        public int CheckLogin(string email, string password)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var adminEmail = configuration.GetSection("DefaultAccount").GetSection("Email").Value;
            var adminPassword = configuration.GetSection("DefaultAccount").GetSection("Password").Value;

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                if (email.Equals(adminEmail) && password.Equals(adminPassword))
                {
                    return 0;
                }
                MemberObject memberObject = MemberObjectList.SingleOrDefault(memberObject => memberObject.Email == email);
                if (memberObject != null)
                {
                    if (memberObject.Password.Equals(password))
                    {
                        return memberObject.MemberID;
                    }
                    else
                    {
                        throw new Exception("Email or password is incorrect.");
                    }
                }
                else
                {
                    throw new Exception("Email or password is incorrect.");
                }

            }
            else
            {
                throw new Exception("Empty string.");
            }
        }
        

        //-------------------------
        //Search member by ID
        public MemberObject SearchMemberByID(int memberID)
        {
            MemberObject member = GetMemberObjectByID(memberID);
            if (member != null)
            {
                return member;
            } else
            {
                throw new Exception("Member does not exist.");
            }
        }

        //---------------------------
        //Search member by name
        public List<MemberObject> SearchMemberByName (string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                List<MemberObject> members = GetMemberObjectList.Where(memberObject => memberObject.MemberName.Contains(name)).ToList();
                            if (members != null && members.Count != 0)
                            {
                                return members;
                            }
                            else
                            {
                                throw new Exception("Member does not exist.");
                            }
            }
            else
            {
                throw new Exception("Empty string.");
            }
        }

        public MemberObject SearchMemberByEmail(string email)
        {
            MemberObject member = MemberObjectList.SingleOrDefault(memberObject => memberObject.Email == email);
            if (member != null)
            {
                return member;
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }
        //---------------------
        //Filter by city
        public List<MemberObject> FilterMemberByCity(string city)
        {
            List<MemberObject> members = GetMemberObjectList.Where(memberObject => memberObject.City ==  city).ToList();
            if (members != null && members.Count != 0)
            {
                return members;
            }
            else
            {
                throw new Exception("Member does not exist.");
            }           
        }
        //---------------------
        //Filter by country
        public List<MemberObject> FilterMemberByCountry(string country)
        {
            List<MemberObject> members = GetMemberObjectList.Where(memberObject => memberObject.Country == country).ToList();
            if (members != null && members.Count != 0)
            {
                return members;
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }
        //----------------------
        //Add a new member, memberID but be a positive number
        public void AddNew(MemberObject memberObject)
        {
            if (memberObject.MemberID > 0)
            {
                MemberObject member = GetMemberObjectByID(memberObject.MemberID);
                if (member == null)
                {
                    MemberObjectList.Add(memberObject);
                } else
                {
                    throw new Exception("Member already exists.");
                }
            }
            else
            {
                throw new Exception("MemberID should be a positive number.");
            }
            
        }

        //Update a member
        public void Update(MemberObject memberObject)
        {
            MemberObject member = GetMemberObjectByID(memberObject.MemberID);
            if (member != null)
            {
                var index = MemberObjectList.IndexOf(member);
                MemberObjectList[index] = memberObject;
            } else
            {
                throw new Exception("Member does not exist.");
            }
        }
        //--------------------
        //Remove a member
        public void Remove (int memberID)
        {
            MemberObject member = GetMemberObjectByID (memberID);
            if (member != null)
            {
                MemberObjectList.Remove(member);
            } else
            {
                throw new Exception("Member does not exist.");
            }
        }
        //---------------------------
        
        
    } // end class
}