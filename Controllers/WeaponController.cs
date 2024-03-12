using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet5_rpg5.Dtos.Character;
using dotnet5_rpg5.Dtos.Weapon;
using dotnet5_rpg5.Services.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet5_rpg5.Controllers
{
    [Authorize]
    [ApiController]
    [Route("controller")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}