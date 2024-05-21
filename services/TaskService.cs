using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoApp.data;
using TodoApp.Model;
using TodoApp.Repository;

namespace TodoApp.services;

public class TaskService
{
    private readonly Repository.TaskRepository _DataRepo;

    public TaskService(TaskRepository taskRepo)
    {
        _DataRepo = taskRepo;
    }

    //**********************************************************************************************************************
    //TODO implemen<t method from dataDB to dataDTO
    public async Task<Model.TaskObj> GetOneTaskObj(long id)
    {
        // var result =  _DataRepo.GetRepoTaskById(id);
        // TODO check if record exist
        // map record to Dto
        // return DTOns

        return await _DataRepo.GetRepoTaskById(id);
    }
    //*********************************************************************************************************************
    public async Task <bool> CreateTaskObj(TaskDTO taskDTO)
    {      
      return await _DataRepo.SaveToDatabase(convertDTO_ToObj(taskDTO)) ;   // convert DTO to entity and validate
    }
      //************************************************************************************************************************


    public TaskObj convertDTO_ToObj(TaskDTO taskDTO)
    {
        var taskObj = new TaskObj();
        taskObj.Name = taskDTO.Name;
        taskObj.Description = taskDTO.Description;
    
        return taskObj;
    }

    //**************************************************************************************************************************
} 
