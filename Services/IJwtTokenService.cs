namespace ZeissEmpMgmt.Services
{
    interface IJwtTokenService
    {
        string GenerateSecurityToken();
    }
}
