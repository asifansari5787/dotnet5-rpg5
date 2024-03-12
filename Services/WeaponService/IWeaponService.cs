using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet5_rpg5.Dtos.Character;
using dotnet5_rpg5.Dtos.Weapon;

namespace dotnet5_rpg5.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}