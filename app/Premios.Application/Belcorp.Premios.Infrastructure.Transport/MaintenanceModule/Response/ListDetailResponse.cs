﻿using Belcorp.Premios.Infrastructure.CrossCutting.DTO;
using Belcorp.Premios.Infrastructure.Transport.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belcorp.Premios.Infrastructure.Transport.MaintenanceModule.Response
{
    public class ListDetailResponse : BaseResponse
    {
        public ICollection<DetailByTeam> Detail { get; set; }
        public ListDetailResponse()
        {
            Detail = new List<DetailByTeam>();
        }
    }
}
