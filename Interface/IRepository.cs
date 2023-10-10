using API.DTOs;
using API.Entities;

namespace API.Interface
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsynch();
        Task<AppUser> GetUserAsynch(int id);
        Task<IEnumerable<AppUser>> GetUsersAsynch();
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
    }
}