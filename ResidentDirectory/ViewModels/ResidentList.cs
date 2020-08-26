using System.Collections.Generic;
using ResidentDirectory.Models;

namespace ResidentDirectory.ViewModels
{
    public class ResidentList
    {
        public List<ResidentModel> residents = new List<ResidentModel>();
        public ResidentList()
        {
            this.residents.Add(new ResidentModel("resident one", 123, false));
            this.residents.Add(new ResidentModel("resident two", 674, true));
            this.residents.Add(new ResidentModel("resident three", 333, false));
            this.residents.Add(new ResidentModel("resident four", 258, true));
        }
    }
}