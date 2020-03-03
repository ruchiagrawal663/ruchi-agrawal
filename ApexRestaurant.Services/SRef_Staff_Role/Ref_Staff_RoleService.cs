using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Repository.RRef_Staff_Role;

namespace ApexRestaurant.Services.SRef_Staff_Role
{ 
    public class Ref_Staff_RoleService : GenericService<Ref_Staff_Roles>, IRef_Staff_RoleService
    { 
        public Ref_Staff_RoleService(IRef_Staff_RoleRepository ref_staff_roleRepository) : base(ref_staff_roleRepository) 
        {
        }
    }
} 