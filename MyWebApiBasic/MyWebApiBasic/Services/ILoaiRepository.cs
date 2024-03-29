﻿using MyWebApiBasic.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWebApiBasic.Services
{
    public interface ILoaiRepository
    {
        List<LoaiVM> GetAll();
        LoaiVM GetById(int id);
        LoaiVM Add(LoaiModel loai);
        void Update(LoaiVM loai);
        void Delete(int id);
    }
}
