using CypherMessageDashboard.Models;
using System.Collections.Generic;

namespace CypherMessageDashboard.Models
{
    public class DashBoardVM
    {
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }
}