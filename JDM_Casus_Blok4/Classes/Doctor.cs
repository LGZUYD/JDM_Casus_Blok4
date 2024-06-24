﻿using JDM_Casus_Blok4.Interfaces;
using JDM_Casus_Blok4.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDM_Casus_Blok4.Classes
{
    public class Doctor : User, IProvider
    {
        public List<Patient> Patients = new List<Patient>();

        public void GiveFeedback(Feedback feedback)
        {
            
        }
        public void CreatePatientAccount() { }
        public void CreateParentAccount(Patient patient) { }
    }
}
