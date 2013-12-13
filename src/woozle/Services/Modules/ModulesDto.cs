﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using ServiceStack.ServiceHost;
using Woozle.Model;

namespace Woozle.Services.Modules
{
    [Route("/modules", "GET, OPTIONS")]
    public class ModulesDto : WoozleDto, IReturn<List<ModuleForMandatorDto>>
    {
    }

    public class ModuleForMandatorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Icon { get; set; }
        public ObservableCollection<FunctionDto> Functions { get; set; }
        public Translation Translation { get; set; }
    }
}
