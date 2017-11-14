using System.ComponentModel.DataAnnotations;

public enum ContactType
{
    [Display(Name = "Business Related")]
    BusinessRelated,
    [Display(Name = "Employment Opportunity")]
    EmploymentOpportunity,
    [Display(Name = "Coding Question")]
    CodingQuestion,
    [Display(Name = "Design Question")]
    DesignQuestion,
    General,
    [Display(Name="Irish Tech News")]
    IrishTechNews,
    [Display(Name = "Resume Related")]
    ResumeRelated,
    [Display(Name = "Software Portfolio")]
    SoftwarePortfolio,
    [Display(Name="Site Feedback")]
    SiteFeedback,
    [Display(Name = "Writing Related")]
    WritingRelated,
    [Display(Name = "Writing Portfolio")]
    WritingPortfolio
}
