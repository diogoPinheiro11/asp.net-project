﻿using BusinessLogic.Entities;
using BusinessLogic.Models;
namespace BusinessLogic.Models;

public class JobProposalSkillModel
{
    public int JobProposalID { get; set; }
    public int SkillID { get; set; }
    public int MinYearsExperience { get; set; }
}
