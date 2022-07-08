using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        //Properties IsAdmin, CurrentMemberID are for authorization purpose.
        public bool IsAdmin { get; set; }
        public int CurrentMemberID { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnCreate.Enabled = IsAdmin;
            btnSearchByID.Enabled = IsAdmin;
            btnSearchByName.Enabled = IsAdmin;
            btnFilterByCity.Enabled = IsAdmin;
            btnFilterByCountry.Enabled = IsAdmin;
            dvgMemberList.CellDoubleClick += dvgMemberList_CellContentClick;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                LoadMemberList();
            } else
            {
                LoadMemberListForMember();
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails 
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        //----------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = dvgMemberList_SelectionChanged(sender, e);
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
        

        private void btnSearchByID_Click(object sender, EventArgs e)
        {            
            try
            {
                var member = memberRepository.SearchMemberByID(int.Parse(txtSearchByID.Text));

                source = new BindingSource();
                source.DataSource = member;

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

                if (member == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member by ID");
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                var members = memberRepository.SearchMemberByName(txtSearchByName.Text);

                source = new BindingSource();
                source.DataSource = members;

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

                if (members == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member by name");
            }
        }

        private void btnFilterByCity_Click(object sender, EventArgs e)
        {
            try
            {
                var members = memberRepository.FilterMemberByCity(cboFilterByCity.Text);

                source = new BindingSource();
                source.DataSource = members;

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

                if (members == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter member by city");
            }
        }

        private void btnFilterByCountry_Click(object sender, EventArgs e)
        {
            try
            {
                var members = memberRepository.FilterMemberByCountry(cboFilterByCountry.Text);

                source = new BindingSource();
                source.DataSource = members;

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

                if (members == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter member by country");
            }
        }

        private void dvgMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                Member = dvgMemberList_SelectionChanged(sender, e),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                if (IsAdmin)
                {
                    LoadMemberList();
                }
                else
                {
                    LoadMemberListForMember();
                }
                
                source.Position = source.Count - 1;
            }
        }

        //------------------------
        //Clear Textbox
        private void ClearText()
        {
            txtSearchByID.Text = string.Empty;
            txtSearchByName.Text = string.Empty;
            cboFilterByCity.Text = string.Empty;
            cboFilterByCountry.Text = string.Empty;
        }

        //------------------------
        

        public void LoadMemberList()
        {
            var members = memberRepository.GetMemberObjects();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    if (IsAdmin)
                    {
                        btnDelete.Enabled = true;
                    }
                    
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        public void LoadMemberListForMember()
        {
            
            try
            {
                source = new BindingSource();
                source.DataSource = memberRepository.GetMemberObjectByID(CurrentMemberID);

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }

        }

        private MemberObject dvgMemberList_SelectionChanged(object sender, EventArgs e)
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(dvgMemberList.CurrentRow.Cells[0].Value.ToString()),
                    MemberName = dvgMemberList.CurrentRow.Cells[1].Value.ToString(),
                    Email = dvgMemberList.CurrentRow.Cells[2].Value.ToString(),
                    Password = dvgMemberList.CurrentRow.Cells[3].Value.ToString(),
                    City = dvgMemberList.CurrentRow.Cells[4].Value.ToString(),
                    Country = dvgMemberList.CurrentRow.Cells[5].Value.ToString()
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return memberObject;

            //-----------------------------------------
            //LOGIC OF NORMAL USER (NOT ADMIN)
            

        }
    }
}
