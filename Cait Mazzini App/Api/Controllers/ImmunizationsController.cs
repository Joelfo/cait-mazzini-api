﻿using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Controllers;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Api.Controllers
{
    public class ImmunizationsController : APIResourceController<ImmunizationDTO, ImmunizationViewModel, Immunization, IGenericRepository<Immunization, int>>
    {
        public ImmunizationsController(IGenericRepository<Immunization, int> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
