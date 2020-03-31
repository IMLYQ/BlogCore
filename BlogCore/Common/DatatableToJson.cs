using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace BlogCore.Common
{
    /// <summary>
    /// DataTable转Json
    /// </summary>
    public class DatatableToJson
    {
        /// <summary>
        /// dataTable转换成Json格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTabletoJson(DataTable dt)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(dt.Rows[i][j].ToString());
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            if (dt.Rows.Count > 0)
            {
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            }
            jsonBuilder.Append("]");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// The  
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string DataTableToJsonWithJavaScriptSerializer(DataTable table)
        {
             
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return JsonConvert.SerializeObject(parentRow);
        }


        /// <summary>
        /// 将查询结果IEnumerable集合转换为DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varlist">The varlist<see cref="IEnumerable{T}"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        public static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            // column names 
            PropertyInfo[] oProps = null;


            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others   will follow

                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }
    }
}
