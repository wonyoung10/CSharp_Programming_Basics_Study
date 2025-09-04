using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace class_copy
{
    public class cClass
    {

        public static T Clone<T>(object sObj)
        {

            object nResultObj = null;
            Type nType = typeof(T);
            string nJson = "";

            try
            {
                nJson = Newtonsoft.Json.JsonConvert.SerializeObject(sObj);
                nResultObj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(nJson);

            }
            catch (Exception)
            {
            }


            return (T)nResultObj;

        }

        //public static void Clone<T>(object rObjSour, object rObjDest) {


        //    Type nType = typeof(T);
        //    string nJson = "";

        //    try {
        //        nJson = Newtonsoft.Json.JsonConvert.SerializeObject(rObjSour);
        //        rObjDest = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(nJson);

        //    } catch (Exception) {
        //    }


        //    return;
        //}


        public static void PropertyCopy<T>(object rObjSour, object rObjDest)
        {

            object? nObject = null;
            Type nType = typeof(T);
            List<PropertyInfo> nPropertyInfoList = new List<PropertyInfo>();
            nPropertyInfoList.AddRange(nType.GetProperties());
            PropertyInfo nPropertyInfo = null;


            for (int i = 0; i < nPropertyInfoList.Count; i++)
            {

                nPropertyInfo = nPropertyInfoList[i];

                nObject = nPropertyInfo.GetValue(rObjSour);
                try
                {
                    nPropertyInfo.SetValue(rObjDest, nObject, null);
                }
                catch
                {
                }

            }

        }



        public static void PropertyCopy(Type rSourType, object rSourObj, Type rDestType, object rDestObj)
        {

            object? nObject = null;
            List<PropertyInfo> nPropertyListSour = new List<PropertyInfo>();
            List<PropertyInfo> nPropertyListDest = new List<PropertyInfo>();
            nPropertyListSour.AddRange(rSourType.GetProperties());
            nPropertyListDest.AddRange(rDestType.GetProperties());
            PropertyInfo nPropertyInfoSour = null;
            PropertyInfo nPropertyInfoDest = null;


            for (int i = 0; i < nPropertyListSour.Count; i++)
            {

                nPropertyInfoSour = nPropertyListSour[i];

                nPropertyInfoDest = null;
                nPropertyInfoDest = nPropertyListDest.FirstOrDefault(x => x.Name == nPropertyInfoSour.Name);
                if (nPropertyInfoDest == null)
                {
                    continue;
                }
                else if (nPropertyInfoDest.Name == "")
                {
                    continue;
                }
                nObject = nPropertyInfoSour.GetValue(rSourObj);
                nPropertyInfoDest.SetValue(rDestObj, nObject, null);

            }

        }


    }
}
