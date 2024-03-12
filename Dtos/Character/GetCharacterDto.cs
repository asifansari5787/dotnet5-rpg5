using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet5_rpg5.Dtos.Skill;
using dotnet5_rpg5.Dtos.Weapon;


namespace dotnet5_rpg5.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string  Name { get; set; } = "Asif";
        public int Hitpoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto? Weapon { get; set; }
        public List<GetSkillDto>? Skills { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
        
    }
}