﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FinalExamCorrection.Models;

public partial class Answer
{
    public string StudId { get; set; }

    public int QuestionId { get; set; }

    public int ExamId { get; set; }

    public int ChoiceId { get; set; }

    public virtual Choice Choice { get; set; }

    public virtual Exam Exam { get; set; }

    public virtual Question Question { get; set; }

    public virtual Student Stud { get; set; }
}