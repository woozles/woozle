////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated from a template.
////
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using Woozle.Model;

//namespace Woozle.Persistence
//{
//    public partial class UserPerson
//    {
//        #region Primitive Properties
    
//        public virtual int Id
//        {
//            get;
//            set;
//        }
    
//        public virtual int UserId
//        {
//            get { return _userId; }
//            set
//            {
//                if (_userId != value)
//                {
//                    if (User != null && User.Id != value)
//                    {
//                        User = null;
//                    }
//                    _userId = value;
//                }
//            }
//        }
//        private int _userId;
    
//        public virtual int PersonId
//        {
//            get { return _personId; }
//            set
//            {
//                if (_personId != value)
//                {
//                    if (Person != null && Person.Id != value)
//                    {
//                        Person = null;
//                    }
//                    _personId = value;
//                }
//            }
//        }
//        private int _personId;
    
//        public virtual int MandatorId
//        {
//            get;
//            set;
//        }

//        #endregion
//        #region Navigation Properties
    
//        public virtual Person Person
//        {
//            get { return _person; }
//            set
//            {
//                if (!ReferenceEquals(_person, value))
//                {
//                    var previousValue = _person;
//                    _person = value;
//                //    FixupPerson(previousValue);
//                }
//            }
//        }
//        private Person _person;
    
//        public virtual User User
//        {
//            get { return _user; }
//            set
//            {
//                if (!ReferenceEquals(_user, value))
//                {
//                    var previousValue = _user;
//                    _user = value;
//                //    FixupUser(previousValue);
//                }
//            }
//        }
//        private User _user;

//        #endregion
//    }
//}
