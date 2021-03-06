﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AutoMapperTest.Bll
{
    public class Mappings
    {
        public static void RegisterMappings()
        {
            //获取所有IProfile实现类
            var allTypeInfo = Assembly
               .GetCallingAssembly();
            
            var allType = allTypeInfo//获取默认程序集
               .GetReferencedAssemblies()//获取所有引用程序集
               .Select(Assembly.Load)
               .SelectMany(y => y.DefinedTypes)
               .Where(type => typeof(IProfile).GetTypeInfo().IsAssignableFrom(type.AsType()));

            foreach (var typeInfo in allType)
            {
                var type = typeInfo.AsType();
                if (type.Equals(typeof(IProfile)))
                {
                    //注册映射
                    AutoMapper.Mapper.Initialize(y =>
                    {
                        y.AddProfiles(type); // Initialise each Profile classe
                    });
                }
            }
        }

    }
}