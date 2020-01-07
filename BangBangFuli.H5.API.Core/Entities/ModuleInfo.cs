﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BangBangFuli.H5.API.Core.Entities
{
    /// <summary>
    /// 模块
    /// </summary>
    public class ModuleInfo
    {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 模块名称
        /// </summary>
        [StringLength(64)]
        public string Name { get; set; }
    }
}
