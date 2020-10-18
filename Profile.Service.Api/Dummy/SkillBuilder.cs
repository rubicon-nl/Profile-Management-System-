using ProfileService.Api.ViewModels;

namespace ProfileService.Api.Dummy
{
    public class SkillBuilder
    {
        private Skill skill;

        private SkillBuilder()
        {

        }

        public static SkillBuilder Create(string name)
        {
            var bld = new SkillBuilder();
            bld.skill = new Skill { StandarizedName = name, TextCaption = new Caption() };
            
            return bld;
        }

        public SkillBuilder AddCaption(string textCaption, string country, string language)
        {
            skill.TextCaption = new Caption { Text = textCaption, Country = country, Language = language };
            return this;
        }

        public Skill Build()
        {
            return skill;
        }

        public static implicit operator Skill(SkillBuilder builder)
        {
            return builder.skill;
        }
    }
}
