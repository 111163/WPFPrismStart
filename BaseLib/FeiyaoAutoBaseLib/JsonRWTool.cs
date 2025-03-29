using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FeiyaoAutoBaseLib
{
    /// <summary>
    /// JSON读写工具类，使用Newtonsoft.Json库实现。
    /// </summary>
    public class JsonRWTool
    {
        private string _filePath;

        /// <summary>
        /// 初始化JsonRWTool类的新实例。
        /// </summary>
        /// <param name="filePath">要读写的JSON文件路径。</param>
        public JsonRWTool(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// 从指定路径读取JSON文件并反序列化为指定类型的对象。
        /// </summary>
        /// <typeparam name="T">要反序列化的对象类型。</typeparam>
        /// <returns>包含操作结果、消息和数据的JsonResult对象。</returns>
        public JsonRWResult<T> ReadJsonFile<T>()
        {
            var result = new JsonRWResult<T>();
            try
            {
                if (!File.Exists(_filePath))
                {
                    throw new FileNotFoundException($"The file {_filePath} does not exist.");
                }

                var json = File.ReadAllText(_filePath);
                var data = JsonConvert.DeserializeObject<T>(json);
                result.IsSuccess = true;
                result.Message = "File read successfully.";
                result.Data = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
                result.IsSuccess = false;
                result.Message = $"Error reading JSON file: {ex.Message}";
                result.Data = default(T);
            }
            return result;
        }

        /// <summary>
        /// 将指定类型的对象序列化为JSON格式并写入到指定路径的文件中。
        /// </summary>
        /// <typeparam name="T">要序列化的对象类型。</typeparam>
        /// <param name="data">要写入的对象数据。</param>
        /// <returns>包含操作结果、消息和数据的JsonResult对象。</returns>
        public JsonRWResult<T> WriteJsonFile<T>(T data)
        {
            var result = new JsonRWResult<T>();
            try
            {
                var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(_filePath, json);
                result.IsSuccess = true;
                result.Message = "File written successfully.";
                result.Data = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing JSON file: {ex.Message}");
                result.IsSuccess = false;
                result.Message = $"Error writing JSON file: {ex.Message}";
                result.Data = default(T);
            }
            return result;
        }
    }

    /// <summary>
    /// JSON读写结果。
    /// </summary>
    /// <typeparam name="T">读取或写入的对象类型。</typeparam>
    public struct JsonRWResult<T>
    {
        /// <summary>
        /// 执行结果。
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 执行信息。
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 读取或写入的数据。
        /// </summary>
        public T Data { get; set; }
    }
}
