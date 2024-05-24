﻿using JDM_Casus_Blok4.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDM_Casus_Blok4.Classes
{
    public class PhisicalTherapist : User
    {
        public List<Child> Patients { get; set; }

        public void ValidateAssessment()
        {
            Patients = new List<Child>();
        }

        public void EnterAssessment()
        {

        }
    }
}