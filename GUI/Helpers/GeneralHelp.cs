using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GUI.Helpers
{
    public static class GeneralHelp
    {
        public static List<string> ReturnListOfClassNames(Type classType)
        {
            List<string> list = new List<string>();

            var ChildClasses = Assembly.GetAssembly(classType).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(classType));

            foreach (var instance in ChildClasses)
            {
                list.Add(instance.Name);
            }

            return list;
        }
    }
}