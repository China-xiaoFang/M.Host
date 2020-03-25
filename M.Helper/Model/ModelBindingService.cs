using System;
using System.Collections.Generic;

namespace M.Helper.Model
{
    /// <summary>
    /// 模型赋值（复制）服务
    /// </summary>
    public class ModelBindingService
    {
        /// <summary>
        /// 模型赋值（复制）
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <typeparam name="V">数据源类型</typeparam>
        /// <param name="source">数据源</param>
        /// <returns></returns>
        public static T CopyModel<T, V>(V source)
        {
            T t = Activator.CreateInstance<T>();
            try
            {
                Type targetType = typeof(T);
                Type sourceType = typeof(V);
                foreach (var key in sourceType.GetProperties())
                {
                    var des = targetType.GetProperty(key.Name);
                    if (des != null)
                    {
                        des.SetValue(t, key.GetValue(source, null), null);
                    }
                }
            }
            catch (Exception)
            {

            }
            return t;
        }

        /// <summary>
        /// 模型赋值（复制）
        /// </summary>
        /// <param name="target">目标</param>
        /// <param name="source">数据源</param>
        public static void CopyModel<T, V>(T target, V source)
        {
            try
            {
                Type targetType = typeof(T);
                Type sourceType = typeof(V);
                foreach (var key in sourceType.GetProperties())
                {
                    var des = targetType.GetProperty(key.Name);
                    if (des != null)
                    {
                        des.SetValue(target, key.GetValue(source, null), null);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 模型集合赋值（复制）
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <typeparam name="V">数据源类型</typeparam>
        /// <param name="source">数据源</param>
        /// <returns>目标结果集合</returns>
        public static List<T> CopyModelList<T, V>(List<V> source)
        {
            List<T> result = new List<T>();
            try
            {
                Type targetType = typeof(T);
                Type sourceType;
                T t;
                foreach (var list in source)
                {
                    sourceType = list.GetType();
                    t = Activator.CreateInstance<T>();
                    foreach (var key in sourceType.GetProperties())
                    {
                        var des = targetType.GetProperty(key.Name);
                        if (des != null)
                        {
                            des.SetValue(t, key.GetValue(list, null), null);
                        }
                    }
                    result.Add(t);
                }
            }
            catch (Exception)
            {

            }
            return result;
        }

        /// <summary>
        /// 模型集合赋值
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <typeparam name="V">数据源类型</typeparam>
        /// <param name="target">目标</param>
        /// <param name="source">数据源</param>
        public static void CopyModelList<T, V>(List<T> target, List<V> source)
        {
            try
            {
                Type targetType = typeof(T);
                Type sourceType;
                T result;
                foreach (var list in source)
                {
                    sourceType = list.GetType();
                    result = Activator.CreateInstance<T>();
                    foreach (var key in sourceType.GetProperties())
                    {
                        var des = targetType.GetProperty(key.Name);
                        if (des != null)
                        {
                            des.SetValue(result, key.GetValue(list, null), null);
                        }
                    }
                    target.Add(result);
                }
            }
            catch (Exception)
            {

            }
        }


    }
}
