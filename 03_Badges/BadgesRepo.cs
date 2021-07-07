using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class BadgesRepo
    {
        private Dictionary<int, List<string>> _detailsDirectory = new Dictionary<int, List<string>>();

        public bool CreateNewBadge(int BadgeID, List<string> DoorNames)
        {
            int startingCount = _detailsDirectory.Count;
            _detailsDirectory.Add(BadgeID, DoorNames);
            bool wasAdded = (_detailsDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public Dictionary<int, List<string>> GetBadgeDetails()
        {
            return _detailsDirectory;
        }

        public List<string> FindBadgeByBadgeID(int badgeID)
        {
            foreach (KeyValuePair <int, List<string>> details in _detailsDirectory)
            {
                if (details.Key == badgeID)
                {
                    return details.Value;
                }
            }
            return null;
        }

        public bool UpdateExistingBadge(int originalBadgeID, List<string> newDetails)
        {
            List<string> oldDetails = FindBadgeByBadgeID(originalBadgeID);
            if (oldDetails != null)
            {
                _detailsDirectory[originalBadgeID] = newDetails;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteBadgeDoorAccess(int originalBadgeID, string doorToRemove)
        {
            List<string> oldDetails = FindBadgeByBadgeID(originalBadgeID);

            bool deleteResult = oldDetails.Remove(doorToRemove);
            return deleteResult;
        }
    }
}
