namespace ResidentDirectory.Models
{
    public class ResidentModel
    {
        public string name;
        public int apartmentID;
        public bool hasChildren;
        public ResidentModel(string name, int apartmentID, bool hasChildren)
        {
            this.name = name;
            this.apartmentID = apartmentID;
            this.hasChildren = hasChildren;
        }
    }
}