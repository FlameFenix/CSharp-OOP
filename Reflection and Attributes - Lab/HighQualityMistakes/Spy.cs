using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HighQualityMistakes
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] fieldInfos = classType.GetFields( BindingFlags.Instance
                                                    | BindingFlags.Static 
                                                    | BindingFlags.Public 
                                                    | BindingFlags.NonPublic);

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {Type.GetType(investigatedClass)}");

            foreach (var field in fieldInfos.Where(x => requestedFields.Contains(x.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance
                                                    | BindingFlags.Static
                                                    | BindingFlags.Public);

            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var publicMethod in publicMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{publicMethod.Name} have to be public!");
            }

            foreach (var privateMethod in nonPublicMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{privateMethod.Name} have to be private!");
            }
            return sb.ToString().Trim();
        }
    }
}
