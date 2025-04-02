using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamBrowserBL.Models;

namespace TeamBrowserUI.Models
{
    public class TeamListModel
    {
        public TeamListModel() {
            Teams = new List<TeamModel>();
        }

        public List<TeamModel> Teams { get; set; }
    }
}