﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IamPropertyTask.ViewModels.Task
{
    public class SubmitData
    {
        public string JavaScriptInput { get; set; }
        public string CSharpInput { get; set; }
        public string SqlInput { get; set; }
        public bool CSharpValidation { get; set; }
        public bool SqlValidation { get; set; }
    }
}