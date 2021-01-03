using boilerplate.Controllers;
using boilerplate.Tasks;
using boilerplate.Tasks.Dto;
using boilerplate.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace boilerplate.Web.Controllers
{
    public class TasksController : boilerplateControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(
            ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async System.Threading.Tasks.Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);

            return View(model);
        }
    }
}
