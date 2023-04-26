﻿using System.Threading.Tasks;
using HogwartsPotions.Models.Entities;

namespace HogwartsPotions.Services.Interfaces;

public interface IStudentService
{
    Task<Student> GetStudentById(long studentId);
}
