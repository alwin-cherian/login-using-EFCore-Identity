using Microsoft.AspNetCore.Authorization;

namespace Week6_Identity_CRUD.Authorization
{
    public class NicknameRequirement : IAuthorizationRequirement
    {
        public string Name { get; set; }
        public NicknameRequirement(string name)
        {
            Name = name;
        }
    }
}
