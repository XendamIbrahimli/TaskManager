using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Models;
using TaskManager.Core.Repositories;

namespace TaskManager.DAL.Repositories
{
    public class AssignmentRepository:GenericRepository<Assignment>, IAssignmentRepository
    {
    }
}
