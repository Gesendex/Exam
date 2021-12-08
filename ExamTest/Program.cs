using System;
using System.Runtime.InteropServices;

namespace ExamTest
{
    class Program
    {
        enum MessageBoxFlags : int // объект, к которому применяем атрибут: теперь для MessageBoxFlags {0} - набор флагов, а
        { // 1) indicate the buttons displayed  /// ФЛАГИ НАЖАТОЙ КНОПКИ                         /// {0:D} - число типа int.   
            MB_OK = 0x0000 /* default!!! */, 
            MB_OKCANCEL = 0x0001, 
            MB_ABORTRETRYIGNORE = 0x0002,
            MB_YESNOCANCEL = 0x0003, 
            MB_YESNO = 0x0004, 
            MB_RETRYCANCEL = 0x0005, 
            MB_CANCELTRYCONTINUE = 0x0006,
            // 2) display an icon                /// ФЛАГИ ИКОНКИ                                  ///  
            MB_ICONERROR = 0x0010 /* MB_ICONSTOP, MB_ICONHAND */, 
            MB_ICONQUESTION = 0x0020,
            MB_ICONWARNING = 0x0030 /* MB_ICONEXCLAMATION */, 
            MB_ICONINFORMATION = 0x0040 /* MB_ICONASTERISK */,
            // 3) indicate the default button   /// ФЛАГИ КНОПКИ ПО УМОЛЧАНИЮ                      ///
            MB_DEFBUTTON1 = 0x0000 /* 1st - default!!! */, 
            MB_DEFBUTTON2 = 0x0100 /* 2nd */,
            MB_DEFBUTTON3 = 0x0200 /*3rd */, 
            MB_DEFBUTTON4 = 0x0300 /* 4th */,
            // 4) indicate the modality        /// ФЛАГИ МОДАЛЬНОСТИ (ВИДИМОСТИ И ПЕРЕКРЫТИЯ) ОКНА ///
            MB_APPLMODAL = 0x0000 /* default */, 
            MB_SYSTEMMODAL = 0x1000 /* freeze associated hWnd */,
            MB_TASKMODAL = 0x2000 /* thread windows are disabled */, 
            MB_HELP = 0x4000 /* add help (F1) using WM_HELP */,
            // 5) specify options              ///  ФЛАГИ ОПЦИЙ ФУНКЦИОНИРОВАНИЯ ОКНА              ///
            MB_SETFOREGROUND = 0x00010000 /*as foreground window*/, 
            MB_DEFAULT_DESKTOP_ONLY = 0x00020000 /*as default desktop*/,
            MB_TOPMOST = 0x00040000 /* WS_EX_TOPMOST style */, 
            MB_RIGHT = 0x00080000 /* right-justified text */,
            MB_RTLREADING = 0x00100000 /* right-to-left reading order */, 
            MB_SERVICE_NOTIFICATION = 0x00200000 /* service notifying of an event*/
        }

        [DllImport("User32.dll")]
         public static extern int MessageBox(int n, string t, string s, int f);
        static void Main(string[] args)
        {
            MessageBox(0, "Чтото", "Заголовок", 0x58255);
        }
    }
}
