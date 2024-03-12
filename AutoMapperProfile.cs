using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet5_rpg5.Dtos.Character;
using dotnet5_rpg5.Dtos.Fight;
using dotnet5_rpg5.Dtos.Skill;
using dotnet5_rpg5.Dtos.Weapon;

namespace dotnet5_rpg5
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}