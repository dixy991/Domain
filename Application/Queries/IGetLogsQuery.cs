﻿using Application.Dto;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public interface IGetLogsQuery : IQuery<LogSearch, PagedResponse<LogDto>>
    {
    }
}
