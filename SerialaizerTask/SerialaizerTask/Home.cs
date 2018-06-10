using System;
using System.Text;
using System.Reflection;

namespace SerialaizerTask
{
    public class Home<T> where T:class
    {
        public string Serialize (T item)
        {
            PropertyInfo[] properties = item.GetType().GetProperties();

            StringBuilder stringBuilder = new StringBuilder();

            foreach(PropertyInfo a in properties)
            {
                stringBuilder.Append(String.Format("<p><span>{0}</span><span>{1}</span><span>{2}</span></p>", a.Name,a.GetValue(item)));
            }
            return stringBuilder.ToString();
        }
    }
}
