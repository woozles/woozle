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
//    public partial class UserMandator
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
    
//        public virtual int MandatorId
//        {
//            get { return _mandatorId; }
//            set
//            {
//                if (_mandatorId != value)
//                {
//                    if (Mandator != null && Mandator.Id != value)
//                    {
//                        Mandator = null;
//                    }
//                    _mandatorId = value;
//                }
//            }
//        }
//        private int _mandatorId;

//        #endregion
//        #region Navigation Properties
    
//        public virtual Mandator Mandator
//        {
//            get { return _mandator; }
//            set
//            {
//                if (!ReferenceEquals(_mandator, value))
//                {
//                    var previousValue = _mandator;
//                    _mandator = value;
//                //    FixupMandator(previousValue);
//                }
//            }
//        }
//        private Mandator _mandator;
    
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
