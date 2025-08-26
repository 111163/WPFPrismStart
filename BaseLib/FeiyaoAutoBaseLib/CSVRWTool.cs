using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiyaoAutoBaseLib
{
    /// <summary>
    /// CSV读写工具类,使用第三方CsvHelper库实现
    /// </summary>
    public class CSVRWTool
    {
        public CSVRWTool()
        {

        }

        public CSVRWTool(string filePath)
        {
            _filePath = filePath;
        }

        private string _filePath = "";

        /// <summary>
        /// 从本地读取csv文件的泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public CsvResult<T> ReadCsvFile<T>()
        {
            var result = new CsvResult<T>();
            try
            {
                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<T>();
                    //return new List<T>(records);
                    result.IsSuccess = true;
                    result.Message = "File read successfully.";
                    result.Records = new List<T>(records);
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                result.IsSuccess = false;
                result.Message = $"Error reading CSV file: {ex.Message}";
                result.Records = new List<T>();

            }
            return result;
        }


        /// <summary>
        /// 写入本地csv文件的泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="records"></param>
        /// <returns></returns>
        public CsvResult<T> WriteCsvFile<T>(IEnumerable<T> records)
        {
            var result = new CsvResult<T>();
            try
            {
                using (var writer = new StreamWriter(_filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                    result.IsSuccess = true;
                    result.Message = "File written successfully.";
                    result.Records = records.ToList();
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                Console.WriteLine($"Error writing CSV file: {ex.Message}");
                result.IsSuccess = false;
                result.Message = $"Error writing CSV file: {ex.Message}";
                result.Records = new List<T>(records);
            }
            return result;
        }

        /// <summary>
        /// 追加写入一条csv数据的泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="record"></param>
        /// <returns></returns>
        public CsvResult<T> AppendWriteCsvRecord<T>(T record)
        {
            return AppendWriteCsvRecords(new List<T> { record });
        }

        /// <summary>
        /// 追加写入多条csv数据的泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="records"></param>
        /// <returns></returns>
        public CsvResult<T> AppendWriteCsvRecords<T>(IEnumerable<T> records)
        {
            bool fileExists = File.Exists(_filePath);
            //bool writeHeader = shouldWriteHeader ?? !fileExists;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // 只有当文件不存在或者明确指定要写入表头时才写表头
                HasHeaderRecord = !fileExists 
            };
            var result = new CsvResult<T>();
            try
            {
                using (var writer = new StreamWriter(_filePath, append: fileExists))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                    result.IsSuccess = true;
                    result.Message = "Records appended successfully.";
                    result.Records = records.ToList();
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                Console.WriteLine($"Error appending CSV records: {ex.Message}");
                result.IsSuccess = false;
                result.Message = $"Error appending CSV records: {ex.Message}";
                result.Records = new List<T>();
            }
            return result;
        }
    }

    /// <summary>
    /// CSV读写结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct CsvResult<T>
    {
        /// <summary>
        /// 执行结果
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 执行信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 读取或写入的记录
        /// </summary>
        public List<T> Records { get; set; }
    }
}
