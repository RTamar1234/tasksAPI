using lesson1.models;
using lesson1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lesson1.controllers
{
    public class ProjectController:ControllerBase
    {

        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        
    }
}
