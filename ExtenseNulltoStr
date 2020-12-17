using System;
using System.Collections.Generic;
using System.Text;

namespace ExtenseNulltoStr
{

    /// <summary>
    /// 擴充方法便是物件是否為Null不是直接轉字串，是則轉為指定字串
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="replaceWord">指定字串</param>
    /// <returns></returns>
    public static class ExtenseNulltoStr
    {
        public static string NulltoStr(this Object obj, string replaceWord)
        {
            return obj == null ? replaceWord : obj.ToString();
        }
    }
    //待測試
    public static Object PropertyNulltoStr(this Object obj, string replaceWord)
   {
       var properties = obj.GetType().GetProperties();
       foreach (var item in properties)
       {
           if (item.GetType() == typeof(string))
           {
               var valueSetting = item.GetValue(item) == null ? replaceWord : item.GetValue(item);
               item.SetValue(item, valueSetting);
        
       }
       return obj;
   }
}


