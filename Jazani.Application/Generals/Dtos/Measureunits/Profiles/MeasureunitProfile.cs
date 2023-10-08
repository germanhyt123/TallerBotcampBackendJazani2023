﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Jazani.Domain.Generals.Models;

namespace Jazani.Application.Generals.Dtos.Measureunits.Profiles
{
    public class MeasureunitProfile:Profile
    {
        public MeasureunitProfile() {

            CreateMap<Measureunit, MeasureunitDto>();
            
            CreateMap<Measureunit, MeasureunitSimpleDto>();
            
            CreateMap<Measureunit, MeasureunitSaveDto>();
        }
    }
}