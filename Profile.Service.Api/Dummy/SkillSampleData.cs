using ProfileService.Api.ViewModels;
using System.Collections.Generic;

namespace ProfileService.Api.Dummy
{
    public class SkillSampleData
    {
        public List<Skill> Skills { get; set; }

        public SkillSampleData()
        {
            Skills = new List<Skill>();
            Skills.Add(SkillBuilder.Create("XML").AddCaption("XML", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("C#").AddCaption("C#", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("F#").AddCaption("F#", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Python").AddCaption("Python", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Java").AddCaption("Java", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Microservices").AddCaption("Microservices", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Clean Architecture").AddCaption("Clean Architecture", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("ADFS").AddCaption("ADFS", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Azure").AddCaption("Azure", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Active Directory").AddCaption("Active Direcotry", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Programm").AddCaption("Programmeren", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Sales").AddCaption("Verkoper", "nl", "Dutch"));
            Skills.Add(SkillBuilder.Create("Coffee drinking").AddCaption("Koffie drinken", "nl", "Dutch"));
        }
    }
}
