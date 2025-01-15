﻿using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Logic.Helper
{
    public class DtoProvider
    {
        public Mapper Mapper { get; }
        public DtoProvider() 
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<OrderUpdateDto, Order>();
                cfg.CreateMap<OrderCreateDto, Order>();
            });

            Mapper = new Mapper(config);
        }
    }
}
