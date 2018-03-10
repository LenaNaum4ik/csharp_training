using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;
        private string middlename = "";
        private string lastname;
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private string address2 = "";
        private string phone2 = "";
        private string notes = "";
        private string text;
        private string allPhones;

        public ContactData(string firstname, string lastname)
        {
          this.firstname = firstname;
          this.lastname = lastname;

        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname && Lastname == other.Lastname;
            
        }

        public override int GetHashCode()
        {
            return
            Firstname.GetHashCode() + Lastname.GetHashCode();
            
        }
        public override string ToString() 
        {
            return "firstName" + FirstName + "\nlastName = " + LastName + "\nmiddleName =" + MiddleName + "\nnickName  = " + NickName + "\ncompany  =" + Company + "\ntittle   = " + Tittle + "\naddress   =" + Address + "\nHome = " + Home + "\nmobile =" + Mobile + "\nwork  = " + Work + "\nfax  =" + Fax + "\nemail   = " + Email + "\nemail2  =" + Email2 + "\nemail3  =" + Email3 + "\nhomepage =" + Homepage + "\nphone2  =" + Phone2 + "\nnotes  =" + Notes;
        }
       
        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return (FirstName + "," + LastName).CompareTo(other.FirstName + "," + other.LastName);
        }
        public ContactData(string firstname, string middlename, string lastname, string nickname, string title, string company, string address, string home, string mobile, string work, string fax, string email, string email2, string email3, string homepage, string address2, string phone2, string notes)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.nickname = nickname;
            this.title = title;
            this.company = company;
            this.address = address;
            this.home = home;
            this.mobile = mobile;
            this.work = work;
            this.fax = fax;
            this.email = email;
            this.email2 = email2;
            this.email3 = email3;
            this.homepage = homepage;
            this.address2 = address2;
            this.phone2 = phone2;
            this.notes = notes;

        }

        public ContactData(string text)
        {
            this.text = text;
        }

        public string Firstname
        {
            get
            {

                return firstname;
            }
            set
            {
                firstname = value;
            }   
         }

        public string Middlename
        {
            get
            {

                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public string Lastname
        {
            get
            {

                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Nickname
        {
            get
            {

                return nickname;
            }
            set
            {
                nickname = value;
            }
        }

        public string Title
        {
            get
            {

                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Company
        {
            get
            {

                return company;
            }
            set
            {
                company = value;
            }
        }

        public string Address
        {
            get
            {

                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Home
        {
            get
            {

                return home;
            }
            set
            {
                home = value;
            }
        }

        public string Mobile
        {
            get
            {

                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

        public string Work
        {
            get
            {

                return work;
            }
            set
            {
                work = value;
            }
        }

        public string Fax
        {
            get
            {

                return fax;
            }
            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {

                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Email2
        {
            get
            {

                return email2;
            }
            set
            {
                email2 = value;
            }
        }

        public string Email3
        {
            get
            {

                return email3;
            }
            set
            {
                email3 = value;
            }
        }

        public string Homepage
        {
            get
            {

                return homepage;
            }
            set
            {
                homepage = value;
            }
        }

        public string Address2
        {
            get
            {

                return address2;
            }
            set
            {
                address2 = value;
            }
        }

        public string Phone2
        {
            get
            {

                return phone2;
            }
            set
            {
                phone2 = value;
            }
        }

        public string Notes
        {
            get
            {

                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(Home) + CleanUp(Mobile) + CleanUp(Work)).Trim();
                }
                
            }
            set
            {
                allPhones = value;
            }
        }

        public string MiddleName { get; internal set; }
        public string NickName { get; internal set; }
        public string Tittle { get; internal set; }

        private string CleanUp(string phone)
        {
            if (phone==null|| phone == "")
            {
                return "";
            }
            return phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")+"\r\n";
        }
    }
}
