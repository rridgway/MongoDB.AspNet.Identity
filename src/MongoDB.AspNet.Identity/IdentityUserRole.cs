﻿using System;

namespace MongoDB.AspNet.Identity
{


    public class IdentityUserRole : IdentityUserRole<string>
    {
        public IdentityUserRole()
        {
        }
    }

    public class IdentityUserRole<TKey> where TKey : IEquatable<TKey>
    {
        public virtual TKey RoleId
        {
            get;
            set;
        }

        public virtual TKey UserId
        {
            get;
            set;
        }

        public IdentityUserRole()
        {
        }
    }
}