using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UEditorNetCore;

namespace BangBangFuli.API.MVCDotnet2.Controllers
{
    [Route("api/[controller]")] //配置路由
    public class UEditorController : Controller
    {
        private readonly UEditorService _ueditorService;
        public UEditorController(UEditorService ueditorService)
        {
            _ueditorService = ueditorService;
        }

        public void Do()
        {
            _ueditorService.DoAction(HttpContext);
        }

    }
}