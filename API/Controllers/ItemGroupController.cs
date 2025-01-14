﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemGroupController : ControllerBase
    {
        private IItemGroupBusiness _itemGroupBusiness;
        public ItemGroupController(IItemGroupBusiness itemGroupBusiness, IConfiguration configuration)
        {
            _itemGroupBusiness = itemGroupBusiness;
        }
        //vd
        [Route("get-menu")]
        [HttpGet]
        public IEnumerable<ItemGroupModel> GetAllMenu()
        {
            return _itemGroupBusiness.GetData();
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public ItemGroupModel GetDatabyID(string id)
        {
            return _itemGroupBusiness.GetDatabyID(id);
        }

    }
}
