using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrinterAPI;
using System.Collections;


namespace GetPrinterStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            //本机打印机列表
            ArrayList printerList = Printer.GetPrinterList();
            Console.WriteLine("本机打印机列表：");
        
            for (int i = 0; i < printerList .Count ; i++)
            {
                Console.WriteLine("打印机{0}：{1}",i+1,printerList [i]);
            }
            Console.WriteLine("---------------------------------------------------");


            //本机默认打印机名称
            string defaultPrinterName = Printer.GetDeaultPrinterName();

            if (Printer.PrinterInList(defaultPrinterName))//判断打印机是否在系统可用的打印机列表中 
            {
                //打印机可用则显示打印状态
              string printerStatus=  Printer.GetPrinterStatus(defaultPrinterName);
              Console.WriteLine("当前默认打印机为：{0}\n状态：{1}", defaultPrinterName, printerStatus);
              Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine("打印机不可用");
            }


           

        }
    }
}
