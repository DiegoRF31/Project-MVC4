using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamBrowserBL.Models;
using System.ComponentModel.DataAnnotations;

namespace TeamBrowserUI.Models
{
    public class TeamModel
    {

        public TeamModel() {
            Roster = new List<PlayerModel>();
        }

        public int? Id { get; set; }

        [Required(ErrorMessage="Team's name is required")]
        [DataType(DataType.Text, ErrorMessage="Team name is a text field")]
        [StringLength(25, ErrorMessage="Team's name cannot contain more than 25 characters")]
        public String Name { get; set; }
        public String Avatar { get; set; }

        public List<PlayerModel> Roster { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}