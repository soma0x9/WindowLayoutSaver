using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using WindowLayoutSaver.Models;

namespace WindowLayoutSaver.Services
{
    public class WindowService
    {
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(
            EnumWindowsProc lpEnumFunc,
            IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(
            IntPtr hWnd,
            StringBuilder lpString,
            int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(
            IntPtr hWnd,
            out uint lpdwProcessId);

        public List<WindowInfo> GetOpenWindows()
        {
            var windows = new List<WindowInfo>();

            EnumWindows((hWnd, lParam) =>
            {
                if (!IsWindowVisible(hWnd))
                {
                    return true;
                }

                int titleLength = GetWindowTextLength(hWnd);

                if (titleLength == 0)
                {
                    return true;
                }

                var titleBuilder = new StringBuilder(titleLength + 1);

                GetWindowText(
                    hWnd,
                    titleBuilder,
                    titleBuilder.Capacity);

                GetWindowThreadProcessId(
                    hWnd,
                    out uint processId);

                string processName = string.Empty;

                try
                {
                    using var process =
                        Process.GetProcessById((int)processId);

                    processName = process.ProcessName;
                }
                catch
                {
                    // プロセス情報を取得できないウィンドウは
                    // 一旦空文字のまま扱う。
                }

                windows.Add(new WindowInfo
                {
                    Handle = hWnd,
                    Title = titleBuilder.ToString(),
                    ProcessName = processName
                });

                return true;
            }, IntPtr.Zero);

            return windows;
        }
    }
}