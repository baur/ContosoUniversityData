﻿using System;
using System.ComponentModel.DataAnnotations;

//namespace ContosoSite.Models
namespace ContosoUniversityData.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
    }
}