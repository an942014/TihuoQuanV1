﻿using System;
using System.Collections.Generic;
using System.Text;
using BangBangFuli.H5.API.Core.Entities;
using BangBangFuli.Utils.ORM.Interface;

namespace BangBangFuli.H5.API.Core.IRepositories.BasicDatas
{
    public interface IProductDetailRepository: IBaseRepository<ProductDetail>
    {
        List<ProductDetail> GetDetailsByProductId(int productId);
    }
}
