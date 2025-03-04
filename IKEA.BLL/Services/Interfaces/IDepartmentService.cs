﻿using IKEA.BLL.Models;

namespace IKEA.BLL.Services.Interfaces;

public interface IDepartmentService
{
    IEnumerable<DepartmentDto> GetAllDepartments();
    DepartmentDetailsDto? GetDepartmentById(int id);
    int CreateDepatment(CreatedDepartmentDto createdDepatmentDto);
    int UpdateDepartment(DepartmentDto depatmentDto);
    bool DeleteDepartment(int id);

}
