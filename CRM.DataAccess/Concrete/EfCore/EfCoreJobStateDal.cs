﻿using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class EfCoreJobStateDal : EfCoreGenericRepository<JobState, CrmContext>, IJobStateDal
    {
    }
}