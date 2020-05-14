using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckAlocation(int leaveTypeid, string employeeId);
        ICollection<LeaveAllocation> GetLeaveAllocationByEmployee(string employeeId);
        LeaveAllocation GetLeaveAllocationByEmployeeAndType(string employeeId, int leaveTypeId);
    }
}
