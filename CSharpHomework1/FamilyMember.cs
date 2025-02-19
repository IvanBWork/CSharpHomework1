﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework1
{

    public enum Gender { man, woman }

    internal class FamilyMembers
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get; set; }
        public FamilyMembers Mother { get; set; }
        public FamilyMembers Father { get; set; }

        public FamilyMembers[] GetGrandMotherName()
        {
            return new FamilyMembers[] { Mother?.Mother, Father?.Mother };
        }

        public FamilyMembers[] GetGrandFatherName()
        {
            return new FamilyMembers[] { Mother?.Father, Father?.Father };
        }

        public FamilyMembers[] GetMothersFamily()
        {
            return new FamilyMembers[] { Mother, Father };
        }

        public FamilyMembers[] GetFathersFamily()
        {
            return new FamilyMembers[] { Mother, Father };
        }
    }
}
