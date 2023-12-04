﻿using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class CulturesExamProfile : Profile
    {
        public CulturesExamProfile()
        {
            CreateMap<CulturesExam, CulturesExamViewModel>();
            CreateMap<CulturesExamDTO, CulturesExam>();
        }
    }
}
