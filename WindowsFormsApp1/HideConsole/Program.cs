﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HideConsole
{
    class Program
    {
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        const int SW_Min = 2;
        const int SW_Max = 3;
        const int SW_Normal = 4;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [STAThread]
        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            //скрыть консоль
            ShowWindow(handle, SW_HIDE);

            //отобразить консоль
            ShowWindow(handle, SW_SHOW);

            //свернуть консоль
            ShowWindow(handle, SW_Min);

            //развернуть консоль
            ShowWindow(handle, SW_Max);

            //нормальный размер консоли
            ShowWindow(handle, SW_Normal);

        }
    }
}
