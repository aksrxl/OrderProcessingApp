using OrderProcessingApp.Data.IRepository;

namespace OrderProcessingApp.Data.Repository
{
    public class MembershipRepository : IMemberShipRepository
    {
        public string CreateNewMember(int productId)
        {
            return "Membership activated and an Email has been sent.";
        }
    }
}
