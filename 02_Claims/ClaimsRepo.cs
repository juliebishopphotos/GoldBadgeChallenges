using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class ClaimsRepo
    {
        private Queue<Claims> _claimsDirectory = new Queue<Claims>();

        public bool AddNewClaim(Claims input) 
        {
            int startingCount = _claimsDirectory.Count;
            _claimsDirectory.Enqueue(input);
            bool wasAdded = (_claimsDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public Queue<Claims> GetAllClaims() 
        {
            return _claimsDirectory;
        }

        public Claims FindInputByClaimID(int claimID)
        {
            foreach (Claims input in _claimsDirectory)
            {
                if (input.ClaimID == claimID)
                {
                    return input;
                }
            }
            return null;
        }

        public bool DeleteClaim()
        {
            int startingCount = _claimsDirectory.Count;
            _claimsDirectory.Dequeue();
            bool wasDeleted = (_claimsDirectory.Count < startingCount) ? true : false;
            return wasDeleted;
        }

    }
}
