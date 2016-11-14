﻿/*======================================================================
 Copyright (c) 同程网络科技股份有限公司. All rights reserved.
 所属项目：Castle.AOP.Other
 创 建 人：hxfsp
 创建日期：2016/8/3 22:04:25
 用    途：
========================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;

namespace Castle.AOP.Other
{
    public class SimpleLogInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine(">>" + invocation.Method.Name);
            invocation.Proceed();
        }
    }
}