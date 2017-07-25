#region YeaJur.Core.Handlers 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：caceaf9c-5a15-4ae7-b7b1-43b136ce8c47
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:19:01
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Handlers
 * 类名称：ExcelHandler
 * 文件名：ExcelHandler
 * 文件描述：
 ***/

#endregion

using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using YeaJur.Core.Extensions;
using YeaJur.Mapper;

namespace YeaJur.Core.Handlers
{
    /// <summary>
    /// EXCEL助手类
    /// </summary>
	public class ExcelHandler
    {
        /// <summary>
        /// 将datatable数据写入excel
        /// </summary>
        /// <param name="sourceTable"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static Stream RenderDataTableToExcel(DataTable sourceTable, string title)
        {
            var workbook = new HSSFWorkbook();
            var ms = new MemoryStream();
            var sheet = workbook.CreateSheet();

            //在工作表中：建立行，参数为行号，从0计
            var row0 = sheet.CreateRow(0);
            //在行中：建立单元格，参数为列号，从0计
            var cell0 = row0.CreateCell(0);
            //设置单元格内容
            cell0.SetCellValue(title);

            var style1 = workbook.CreateCellStyle();
            //设置单元格的样式：水平对齐居中
            style1.Alignment = HorizontalAlignment.Center;
            //新建一个字体样式对象
            var font = workbook.CreateFont();
            //设置字体加粗样式
            font.Boldweight = short.MaxValue;
            font.FontHeightInPoints
                = 25;
            //使用SetFont方法将字体样式添加到单元格样式中 
            style1.SetFont(font);
            //将新的样式赋给单元格
            cell0.CellStyle = style1;

            //设置单元格的高度
            row0.Height = 30 * 20;

            //设置一个合并单元格区域，使用上下左右定义CellRangeAddress区域
            //CellRangeAddress四个参数为：起始行，结束行，起始列，结束列
            sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, sourceTable.Columns.Count - 1));

            // Style the cell with borders all around.
            var style = (HSSFCellStyle)workbook.CreateCellStyle();
            //设置边框格式  
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            var fonthead = workbook.CreateFont();
            //设置字体加粗样式
            fonthead.Boldweight = short.MaxValue;

            var headerRow = sheet.CreateRow(1);
            headerRow.Height = 20 * 20;
            var i = 0;

            // handling header. 
            foreach (DataColumn column in sourceTable.Columns)
            {
                //设置单元格的宽度
                sheet.SetColumnWidth(i++, 25 * 256);
                var cell = headerRow.CreateCell(column.Ordinal);
                cell.SetCellValue(column.ColumnName);
                cell.CellStyle = style;
            }

            // handling value. 
            var rowIndex = 2;
            foreach (DataRow row in sourceTable.Rows)
            {
                var dataRow = sheet.CreateRow(rowIndex);

                foreach (DataColumn column in sourceTable.Columns)
                {
                    // Create a cell and put a value in it.              
                    var cell = dataRow.CreateCell(column.Ordinal);
                    cell.SetCellValue(row[column].ToString());
                    cell.CellStyle = style;
                }
                rowIndex++;
            }

            workbook.Write(ms);
            ms.Flush();
            ms.Position = 0;

            return ms;
        }

        /// <summary>
        /// 将excel的数据写入datatable
        /// </summary>
        /// <param name="excelFileStream"></param>
        /// <param name="sheetIndex"></param>
        /// <param name="headerRowIndex"></param>
        /// <returns></returns>
        public static DataTable RenderDataTableFromExcel(Stream excelFileStream, int sheetIndex, int headerRowIndex)
        {
            var workbook = new HSSFWorkbook(excelFileStream);
            var sheet = workbook.GetSheetAt(sheetIndex);

            var table = new DataTable();

            var headerRow = sheet.GetRow(headerRowIndex);
            int cellCount = headerRow.LastCellNum;

            for (int i = headerRow.FirstCellNum; i < cellCount; i++)
            {
                var column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                table.Columns.Add(column);
            }

            var rowCount = sheet.LastRowNum;

            for (var i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                var row = sheet.GetRow(i);
                var dataRow = table.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)

                        dataRow[j] = row.GetCell(j).ToString();
                }

                table.Rows.Add(dataRow);
            }

            excelFileStream.Close();
            workbook = null;
            sheet = null;
            return table;
        }

        /// <summary>
        /// asp.net导出excel
        /// </summary>
        /// <param name="dt">数据</param>
        /// <param name="title">标题</param>
        /// <returns></returns>
        public static string ExportExcelByWeb(DataTable dt, string title)
        {
            var txt = title.Split('\\').Last().Split('.')[0];
            var ms = RenderDataTableToExcel(dt, txt) as MemoryStream;

            ///*情况1：在Asp.NET中，输出文件流，浏览器自动提示下载*/
            //Response.AddHeader("Content-Disposition", string.Format("attachment; filename=download.xls"));
            //Response.BinaryWrite(ms.ToArray());
            var path = "Excel/" + txt + ".xls";
            if (!Directory.Exists(title.Replace(txt + ".xls", string.Empty)))
            {
                Directory.CreateDirectory(title.Replace(txt + ".xls", string.Empty));
            }
            var fs = new FileStream(title, FileMode.Create);
            //获得字节数组
            if (ms != null)
            {
                var data = ms.ToArray(); // new UTF8Encoding().GetBytes(String);
                //开始写入
                fs.Write(data, 0, data.Length);
                ms.Close();
                ms.Dispose();
            }
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
            return path;
        }

        /// <summary>
        /// 获取导出数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">需要导出的数据集合</param>
        /// <returns></returns>
        public static DataTable GetExportData<T>(List<T> list)
        {
            var str = list.ToDataTable().ToJson();

            foreach (var item in DescriptionHandler.GetList<T>())
            {
                str = str.Replace(item.Key, item.Value);
            }
            return str.ToModel<DataTable>();
        }
    }
}