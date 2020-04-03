﻿using System;
using System.Data;

namespace BlogCore.Common
{
    /// <summary>
    /// 数据转换
    /// </summary>
    public class DataParser
    {
        #region 解析字符串到泛型

        /// <summary>
        /// 将字符串转为int（可空）
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static int? ParseIntT(string strValue)
        {
            int value;
            if (int.TryParse(strValue, out value))
            {
                return (int?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转为decimal（可空）
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static decimal? ParseDecimalT(string strValue)
        {
            decimal value;
            if (decimal.TryParse(strValue, out value))
            {
                return (decimal?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转为double（可空）
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static double? ParseDoubleT(string strValue)
        {
            double value;
            if (double.TryParse(strValue, out value))
            {
                return (double?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转为float（可空）
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static float? ParseFloatT(string strValue)
        {
            float value;
            if (float.TryParse(strValue, out value))
            {
                return (float?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转为DateTime（可空）
        /// </summary>
        /// <param name="strValue">需为有效的日期格式</param>
        /// <returns></returns>
        public static DateTime? ParseDateTimeT(string strValue)
        {
            if (strValue.IndexOf("0001-01-01") >= 0)
            {
                return null;
            }
            DateTime value;
            if (DateTime.TryParse(strValue, out value))
            {
                return (DateTime?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///将字符串转为short代表有符号的16位整数，范围从-32768 ～ 32767（可空）
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static short? ParseShortT(string strValue)
        {
            short value;
            if (short.TryParse(strValue, out value))
            {
                return (short?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///   long代表有符号的64位整数，范围从-9223372036854775808 ～ 9223372036854775808
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static long? ParseLongT(string strValue)
        {
            long value;
            if (long.TryParse(strValue, out value))
            {
                return (long?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///  将字符串转为byte 代表无符号的8位整数，数值范围从0～255
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static byte? ParseByteT(string strValue)
        {
            byte value;
            if (byte.TryParse(strValue, out value))
            {
                return (byte?)value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转为 bool 字符串true解析成True,其他为false,空串为null
        /// </summary>
        /// <param name="strValue">字符串true解析成True,其他为false,空串为null</param>
        /// <returns></returns>
        public static bool? ParseBoolT(string strValue)
        {
            if (string.IsNullOrEmpty(strValue))
            {
                return null;
            }
            else
            {
                bool value;
                if (bool.TryParse(strValue.ToLower(), out value))
                {
                    return (bool?)value;
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion 解析字符串到泛型

        #region 解析字符串到指定类型

        /// <summary>
        ///将字符串转为int
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static int ParseInt(string strValue)
        {
            return int.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为decimal
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static decimal ParseDecimal(string strValue)
        {
            return decimal.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为double
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static double ParseDouble(string strValue)
        {
            return double.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为float
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static float ParseFloat(string strValue)
        {
            return float.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为DateTime
        /// </summary>
        /// <param name="strValue">源字符串,需为有效的日期格式</param>
        /// <returns></returns>
        public static DateTime ParseDateTime(string strValue)
        {
            try
            {
                return DateTime.Parse(strValue);
            }
            catch
            {
                return DateTime.Parse("1900-01-01");
            }
        }

        /// <summary>
        /// 将字符串转为short
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static short ParseShort(string strValue)
        {
            return short.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为long
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static long ParseLong(string strValue)
        {
            return long.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为byte
        /// </summary>
        /// <param name="strValue">源字符串</param>
        /// <returns></returns>
        public static byte ParseByte(string strValue)
        {
            return byte.Parse(strValue);
        }

        /// <summary>
        /// 将字符串转为bool
        /// </summary>
        /// <param name="strValue">字符串true解析成True,其他为false,空串为null</param>
        /// <returns></returns>
        public static bool ParseBool(string strValue)
        {
            return bool.Parse(strValue);
        }

        #endregion 解析字符串到指定类型

        #region 将泛型的值转换成字符串

        /// <summary>
        /// int?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringIntT(int? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// short?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringShortT(short? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// long?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringLongT(long? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// byte?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringByteT(byte? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// bool?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringBoolT(bool? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// decimal?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringDecimalT(decimal? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// double?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringDoubleT(double? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// float?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringFloatT(float? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// DateTime?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <returns>符串</returns>
        public static string ToStringDateTimeT(DateTime? objValue)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        /// *********************          带格式参数的  **************************

        /// <summary>
        /// DateTime?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns></returns>
        public static string ToStringDateTimeT(DateTime? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return DateTime.Now.ToString(strFormat);
            }
        }

        /// <summary>
        /// int?
        /// </summary>
        /// <param name="objValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns></returns>
        public static string ToStringIntT(int? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// short?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns>符串</returns>
        public static string ToStringShortT(short? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// long?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns>符串</returns>
        public static string ToStringLongT(long? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// byte?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns>符串</returns>
        public static string ToStringByteT(byte? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// decimal?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns>符串</returns>
        public static string ToStringDecimalT(decimal? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// double?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns>符串</returns>
        public static string ToStringDoubleT(double? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// float?
        /// </summary>
        /// <param name="strValue">泛型数据</param>
        /// <param name="strFormat">格式参数</param>
        /// <returns>符串</returns>
        public static string ToStringFloatT(float? objValue, string strFormat)
        {
            if (objValue.HasValue)
            {
                return objValue.Value.ToString(strFormat);
            }
            else
            {
                return "";
            }
        }

        #endregion 将泛型的值转换成字符串

        #region 从datarow的某列取泛型值

        /// <summary>
        /// GetItemDecimalT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static decimal? GetItemDecimalT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (decimal)row[columnName];
            }
        }

        /// <summary>
        /// GetItemLongT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static long? GetItemLongT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (long)row[columnName];
            }
        }

        /// <summary>
        /// GetItemIntT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static int? GetItemIntT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (int)row[columnName];
            }
        }

        /// <summary>
        /// GetItemDoubleT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static double? GetItemDoubleT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (double)row[columnName];
            }
        }

        /// <summary>
        /// GetItemFloatT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static float? GetItemFloatT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (float)row[columnName];
            }
        }

        /// <summary>
        /// GetItemShortT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static short? GetItemShortT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (short)row[columnName];
            }
        }

        /// <summary>
        /// GetItemByteT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static byte? GetItemByteT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (byte)row[columnName];
            }
        }

        /// <summary>
        /// GetItemBoolT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static bool? GetItemBoolT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (bool)row[columnName];
            }
        }

        /// <summary>
        /// GetItemDateTimeT,无值返回空(null)
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static DateTime? GetItemDateTimeT(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return null;
            }
            else
            {
                return (DateTime)row[columnName];
            }
        }

        #endregion 从datarow的某列取泛型值

        #region 从datarow的某列取值,非泛型值

        /// <summary>
        /// GetItemString,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static string GetItemString(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return string.Empty;
            }
            else
            {
                return row[columnName].ToString();
            }
        }

        /// <summary>
        /// GetItemGuid,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static Guid GetItemGuid(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return Guid.Empty;
            }
            else
            {
                return (Guid)row[columnName];
            }
        }

        /// <summary>
        /// GetItemObject,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static object GetItemObject(DataRow row, string columnName)
        {
            return row[columnName];
        }

        /// <summary>
        /// GetItemByteArray,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static byte[] GetItemByteArray(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return new byte[] { };
            }
            else
            {
                return row[columnName] as byte[];
            }
        }

        /// <summary>
        /// GetItemDecimal,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static decimal GetItemDecimal(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (decimal)row[columnName];
            }
        }

        /// <summary>
        /// GetItemLong,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static long GetItemLong(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (long)row[columnName];
            }
        }

        /// <summary>
        /// GetItemInt,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static int GetItemInt(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (int)row[columnName];
            }
        }

        /// <summary>
        /// GetItemDouble,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static double GetItemDouble(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (double)row[columnName];
            }
        }

        /// <summary>
        /// GetItemFloat,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static float GetItemFloat(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (float)row[columnName];
            }
        }

        /// <summary>
        /// GetItemShort,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static short GetItemShort(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (short)row[columnName];
            }
        }

        /// <summary>
        /// GetItemByte,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static byte GetItemByte(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return 0;
            }
            else
            {
                return (byte)row[columnName];
            }
        }

        /// <summary>
        /// GetItemBool,无值返回该返回类型默认值
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static bool GetItemBool(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return false;
            }
            else
            {
                return (bool)row[columnName];
            }
        }

        /// <summary>
        /// GetItemDateTime,无值返回该返回1900-01-01
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="columnName">列名称</param>
        /// <returns></returns>
        public static DateTime GetItemDateTime(DataRow row, string columnName)
        {
            if (row.IsNull(columnName))
            {
                return DateTime.Parse("1900-01-01");
            }
            else
            {
                return (DateTime)row[columnName];
            }
        }

        #endregion 从datarow的某列取值,非泛型值
    }
}
