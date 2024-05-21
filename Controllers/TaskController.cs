using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoApp.services;
using TodoApp.Model;
using Microsoft.EntityFrameworkCore;
using TodoApp.data;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }
        //******************************************************************************************************************
        /*
           [HttpGet]
           [Route ("All" , Name = "GetAllTasks")]                       
           [ProducesResponseType<Task>(StatusCodes)]
           [ProducesResponseType(StatusCodes.Status400BadRequest)]
           public ActionResult<Task> GetTask() {
               return Ok; 
           }
        */
        //****************************************************************************************************************
        [HttpGet("{id:long}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetTaskItem(long id)
        {
            if (id <= 0)
                return BadRequest("Not a proper request");  // if id is below 1 

            var TaskObjById =  _taskService.GetOneTaskObj(id);  // call service class to retreive data from database

            if (TaskObjById == null)
            {
                return NotFound();
            }

            return Ok(TaskObjById);
        }
        // ************************************************************************************************************8
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task <IActionResult> InsertTask(TaskDTO taskDTO)
        { 
            var savedObj =  await _taskService.CreateTaskObj(taskDTO);       // add entity OBj into database
            if (savedObj == false) return NoContent();                      //save and wait for confirmation
            return Ok(savedObj); 
        }
        
       //****************************************************************************************************************

        /*
        [HttpPut("{id:int}")]
            public void UpdateTaskItem(int id)
        {
            
        }
        */

        //****************************************************************************************************************8
        /*
         [HttpDelete("{id:int}")]
         public void RemoveTaskItem(int id)
         {

         }
        */
        //***************************************************************************************************************
    }
}
    