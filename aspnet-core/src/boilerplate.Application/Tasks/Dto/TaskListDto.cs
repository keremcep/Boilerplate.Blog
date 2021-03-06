﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using boilerplate.BlogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace boilerplate.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskListDto:EntityDto, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }
    }
}
